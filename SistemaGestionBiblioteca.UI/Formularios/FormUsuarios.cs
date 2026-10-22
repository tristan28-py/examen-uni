using SistemaGestionBiblioteca.Entidades.Entidades;
using System;
using System.Windows.Forms;

namespace SistemaGestionBiblioteca.UI.Formularios
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            try
            {
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = ServiciosContext.UsuarioServicio.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario nuevoUsuario = new Usuario
                {
                    Nombre = txtNombre.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
                    Activo = chkActivo.Checked
                };

                ServiciosContext.UsuarioServicio.Insertar(nuevoUsuario);
                ServiciosContext.HistorialServicio.RegistrarAccion($"Usuario registrado: {nuevoUsuario.Nombre}");

                MessageBox.Show("Usuario guardado con éxito.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarUsuarios();
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
                if (string.IsNullOrWhiteSpace(txtUsuarioId.Text))
                {
                    MessageBox.Show("Seleccione un usuario de la tabla para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Usuario usuarioEditado = new Usuario
                {
                    Id = int.Parse(txtUsuarioId.Text),
                    Nombre = txtNombre.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
                    Activo = chkActivo.Checked
                };

                ServiciosContext.UsuarioServicio.Actualizar(usuarioEditado);
                ServiciosContext.HistorialServicio.RegistrarAccion($"Usuario modificado: {usuarioEditado.Nombre}");

                MessageBox.Show("Usuario modificado con éxito.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarUsuarios();
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
                if (string.IsNullOrWhiteSpace(txtUsuarioId.Text))
                {
                    MessageBox.Show("Seleccione un usuario de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = int.Parse(txtUsuarioId.Text);
                DialogResult confirm = MessageBox.Show("¿Está seguro de eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    ServiciosContext.UsuarioServicio.Eliminar(id);
                    ServiciosContext.HistorialServicio.RegistrarAccion($"Usuario eliminado ID: {id}");

                    MessageBox.Show("Usuario eliminado con éxito.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvUsuarios.CurrentRow != null)
            {
                DataGridViewRow fila = dgvUsuarios.CurrentRow;
                txtUsuarioId.Text = fila.Cells["Id"].Value?.ToString() ?? "";
                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? "";
                txtCorreo.Text = fila.Cells["Correo"].Value?.ToString() ?? "";
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString() ?? "";
                chkActivo.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value ?? true);
            }
        }

        private void btnAgregarACola_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsuarioId.Text))
                {
                    MessageBox.Show("Seleccione un usuario de la tabla primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Usuario usuario = new Usuario
                {
                    Id = int.Parse(txtUsuarioId.Text),
                    Nombre = txtNombre.Text,
                    Correo = txtCorreo.Text,
                    Telefono = txtTelefono.Text,
                    Activo = chkActivo.Checked
                };

                ServiciosContext.ColaServicio.Encolar(usuario);
                ServiciosContext.HistorialServicio.RegistrarAccion($"Usuario encolado: {usuario.Nombre}");

                MessageBox.Show($"Usuario '{usuario.Nombre}' agregado a la cola de espera.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtUsuarioId.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            chkActivo.Checked = true;
            txtNombre.Focus();
        }
    }
}
