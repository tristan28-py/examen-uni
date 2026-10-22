using SistemaGestionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaGestionBiblioteca.UI.Formularios
{
    public partial class FormLibros : Form
    {
        public FormLibros()
        {
            InitializeComponent();
        }

        private void FormLibros_Load(object sender, EventArgs e)
        {
            CargarAutoresCombo();
            CargarLibros();
        }

        private void CargarAutoresCombo()
        {
            try
            {
                var autores = ServiciosContext.AutorServicio.ObtenerTodos();
                cmbAutores.DataSource = autores;
                cmbAutores.DisplayMember = "Nombre";
                cmbAutores.ValueMember = "AutorId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lista de autores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarLibros()
        {
            try
            {
                dgvLibros.DataSource = null;
                dgvLibros.DataSource = ServiciosContext.LibroServicio.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar libros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAutores.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un autor para el libro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Libro nuevoLibro = new Libro
                {
                    Titulo = txtTituloLibro.Text.Trim(),
                    ISBN = txtISBN.Text.Trim(),
                    Existencias = (int)numExistencias.Value,
                    AutorId = Convert.ToInt32(cmbAutores.SelectedValue),
                    Activo = chkActivo.Checked
                };

                ServiciosContext.LibroServicio.Insertar(nuevoLibro);
                ServiciosContext.HistorialServicio.RegistrarAccion($"Libro agregado: {nuevoLibro.Titulo}");

                MessageBox.Show("Libro guardado con éxito.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarLibros();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLibroId.Text))
                {
                    MessageBox.Show("Seleccione un libro de la tabla para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Libro libroEditado = new Libro
                {
                    LibroId = int.Parse(txtLibroId.Text),
                    Titulo = txtTituloLibro.Text.Trim(),
                    ISBN = txtISBN.Text.Trim(),
                    Existencias = (int)numExistencias.Value,
                    AutorId = Convert.ToInt32(cmbAutores.SelectedValue),
                    Activo = chkActivo.Checked
                };

                ServiciosContext.LibroServicio.Actualizar(libroEditado);
                ServiciosContext.HistorialServicio.RegistrarAccion($"Libro modificado: {libroEditado.Titulo}");

                MessageBox.Show("Libro modificado con éxito.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarLibros();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLibroId.Text))
                {
                    MessageBox.Show("Seleccione un libro de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = int.Parse(txtLibroId.Text);
                DialogResult confirm = MessageBox.Show("¿Está seguro de eliminar este libro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    ServiciosContext.LibroServicio.Eliminar(id);
                    ServiciosContext.HistorialServicio.RegistrarAccion($"Libro eliminado ID: {id}");

                    MessageBox.Show("Libro eliminado con éxito.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarLibros();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = txtBuscar.Text.Trim();
                dgvLibros.DataSource = null;
                dgvLibros.DataSource = ServiciosContext.LibroServicio.BuscarPorTitulo(criterio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarLibros();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar_Click(sender, e);
                e.Handled = true;
            }
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLibros.CurrentRow != null)
            {
                DataGridViewRow fila = dgvLibros.CurrentRow;
                txtLibroId.Text = fila.Cells["LibroId"].Value?.ToString() ?? "";
                txtTituloLibro.Text = fila.Cells["Titulo"].Value?.ToString() ?? "";
                txtISBN.Text = fila.Cells["ISBN"].Value?.ToString() ?? "";

                if (int.TryParse(fila.Cells["Existencias"].Value?.ToString(), out int existencias))
                {
                    numExistencias.Value = Math.Max(0, existencias);
                }

                if (int.TryParse(fila.Cells["AutorId"].Value?.ToString(), out int autorId))
                {
                    cmbAutores.SelectedValue = autorId;
                }

                chkActivo.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value ?? true);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtLibroId.Clear();
            txtTituloLibro.Clear();
            txtISBN.Clear();
            numExistencias.Value = 0;
            chkActivo.Checked = true;
            txtTituloLibro.Focus();
        }
    }
}
