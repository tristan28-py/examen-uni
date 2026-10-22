using SistemaGestionBiblioteca.Entidades.Entidades;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaGestionBiblioteca.UI.Formularios
{
    public partial class FormColaEspera : Form
    {
        public FormColaEspera()
        {
            InitializeComponent();
        }

        private void FormColaEspera_Load(object sender, EventArgs e)
        {
            CargarUsuariosCombo();
            ActualizarVistaCola();
        }

        private void CargarUsuariosCombo()
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

        private void ActualizarVistaCola()
        {
            try
            {
                dgvCola.DataSource = null;
                dgvCola.DataSource = ServiciosContext.ColaServicio.ObtenerCola();

                int total = ServiciosContext.ColaServicio.CantidadEnEspera();
                lblTotalCola.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la lista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUsuarios.SelectedItem is Usuario usuario)
                {
                    ServiciosContext.ColaServicio.Encolar(usuario);
                    ServiciosContext.HistorialServicio.RegistrarAccion($"Usuario agregado a cola: {usuario.Nombre}");

                    MessageBox.Show($"Usuario '{usuario.Nombre}' agregado a la cola.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarVistaCola();
                }
                else
                {
                    MessageBox.Show("Seleccione un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVerSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario? siguiente = ServiciosContext.ColaServicio.VerSiguiente();

                if (siguiente == null)
                {
                    MessageBox.Show("No hay usuarios en la cola de espera.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"El siguiente usuario es:\n\nNombre: {siguiente.Nombre}\nCorreo: {siguiente.Correo}", "Siguiente en turno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDespachar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario atendido = ServiciosContext.ColaServicio.Despachar();
                ServiciosContext.HistorialServicio.RegistrarAccion($"Usuario atendido: {atendido.Nombre}");

                MessageBox.Show($"Se atendió al usuario: {atendido.Nombre}", "Atendido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarVistaCola();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al atender: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
