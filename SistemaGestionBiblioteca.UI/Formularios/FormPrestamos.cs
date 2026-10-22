using SistemaGestionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaGestionBiblioteca.UI.Formularios
{
    public partial class FormPrestamos : Form
    {
        public FormPrestamos()
        {
            InitializeComponent();
        }

        private void FormPrestamos_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarLibros();
            CargarPrestamos();
        }

        private void CargarUsuarios()
        {
            try
            {
                var usuarios = ServiciosContext.UsuarioServicio.ObtenerTodos().Where(u => u.Activo).ToList();
                cmbUsuarios.DataSource = usuarios;
                cmbUsuarios.DisplayMember = "Nombre";
                cmbUsuarios.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarLibros()
        {
            try
            {
                var libros = ServiciosContext.LibroServicio.ObtenerTodos().Where(l => l.Activo).ToList();
                cmbLibros.DataSource = libros;
                cmbLibros.DisplayMember = "Titulo";
                cmbLibros.ValueMember = "LibroId";
                ActualizarTextoStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar libros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPrestamos()
        {
            try
            {
                dgvPrestamos.DataSource = null;
                dgvPrestamos.DataSource = ServiciosContext.PrestamoServicio.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTextoStock();
        }

        private void ActualizarTextoStock()
        {
            if (cmbLibros.SelectedItem is Libro libro)
            {
                lblInfoStock.Text = $"Existencias disponibles: {libro.Existencias}";
                lblInfoStock.ForeColor = libro.Existencias > 0 ? Color.ForestGreen : Color.Crimson;
            }
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUsuarios.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbLibros.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un libro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int usuarioId = Convert.ToInt32(cmbUsuarios.SelectedValue);
                int libroId = Convert.ToInt32(cmbLibros.SelectedValue);

                Prestamo nuevoPrestamo = new Prestamo
                {
                    UsuarioId = usuarioId,
                    LibroId = libroId
                };

                ServiciosContext.PrestamoServicio.Insertar(nuevoPrestamo);
                ServiciosContext.HistorialServicio.RegistrarAccion($"Préstamo registrado - Libro ID: {libroId} a Usuario ID: {usuarioId}");

                MessageBox.Show("Préstamo registrado correctamente.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarLibros();
                CargarPrestamos();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Sin existencias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrestamos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un préstamo de la tabla para registrar su devolución.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int prestamoId = Convert.ToInt32(dgvPrestamos.CurrentRow.Cells["PrestamoId"].Value);
                string estado = dgvPrestamos.CurrentRow.Cells["Estado"].Value?.ToString() ?? "";

                if (estado == "Devuelto")
                {
                    MessageBox.Show("Este libro ya fue devuelto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult respuesta = MessageBox.Show($"¿Desea registrar la devolución del préstamo #{prestamoId}?", "Confirmar devolución", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    ServiciosContext.PrestamoServicio.RegistrarDevolucion(prestamoId);
                    ServiciosContext.HistorialServicio.RegistrarAccion($"Devolución procesada - Préstamo ID: {prestamoId}");

                    MessageBox.Show("Devolución registrada correctamente.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarLibros();
                    CargarPrestamos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar devolución: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarLibros();
            CargarUsuarios();
            CargarPrestamos();
        }
    }
}
