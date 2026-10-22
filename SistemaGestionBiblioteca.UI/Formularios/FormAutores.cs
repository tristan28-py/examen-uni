using SistemaGestionBiblioteca.Entidades.Entidades;
using System;
using System.Windows.Forms;

namespace SistemaGestionBiblioteca.UI.Formularios
{
    public partial class FormAutores : Form
    {
        public FormAutores()
        {
            InitializeComponent();
        }

        private void FormAutores_Load(object sender, EventArgs e)
        {
            CargarAutores();
        }

        private void CargarAutores()
        {
            try
            {
                dgvAutores.DataSource = null;
                dgvAutores.DataSource = ServiciosContext.AutorServicio.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar autores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Autor nuevoAutor = new Autor
                {
                    Nombre = txtNombre.Text.Trim(),
                    Nacionalidad = string.IsNullOrWhiteSpace(txtNacionalidad.Text) ? null : txtNacionalidad.Text.Trim(),
                    Activo = chkActivo.Checked
                };

                ServiciosContext.AutorServicio.Insertar(nuevoAutor);
                ServiciosContext.HistorialServicio.RegistrarAccion($"Autor agregado: {nuevoAutor.Nombre}");

                MessageBox.Show("Autor guardado con éxito.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarAutores();
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
                if (string.IsNullOrWhiteSpace(txtAutorId.Text))
                {
                    MessageBox.Show("Seleccione un autor de la tabla para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Autor autorEditado = new Autor
                {
                    AutorId = int.Parse(txtAutorId.Text),
                    Nombre = txtNombre.Text.Trim(),
                    Nacionalidad = string.IsNullOrWhiteSpace(txtNacionalidad.Text) ? null : txtNacionalidad.Text.Trim(),
                    Activo = chkActivo.Checked
                };

                ServiciosContext.AutorServicio.Actualizar(autorEditado);
                ServiciosContext.HistorialServicio.RegistrarAccion($"Autor modificado: {autorEditado.Nombre}");

                MessageBox.Show("Autor modificado con éxito.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarAutores();
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
                if (string.IsNullOrWhiteSpace(txtAutorId.Text))
                {
                    MessageBox.Show("Seleccione un autor de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = int.Parse(txtAutorId.Text);
                DialogResult confirm = MessageBox.Show("¿Está seguro de eliminar este autor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    ServiciosContext.AutorServicio.Eliminar(id);
                    ServiciosContext.HistorialServicio.RegistrarAccion($"Autor eliminado ID: {id}");

                    MessageBox.Show("Autor eliminado con éxito.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarAutores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAutores.CurrentRow != null)
            {
                DataGridViewRow fila = dgvAutores.CurrentRow;
                txtAutorId.Text = fila.Cells["AutorId"].Value?.ToString() ?? "";
                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? "";
                txtNacionalidad.Text = fila.Cells["Nacionalidad"].Value?.ToString() ?? "";
                chkActivo.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value ?? true);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtAutorId.Clear();
            txtNombre.Clear();
            txtNacionalidad.Clear();
            chkActivo.Checked = true;
            txtNombre.Focus();
        }
    }
}
