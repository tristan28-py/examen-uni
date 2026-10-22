using System;
using System.Windows.Forms;

namespace SistemaGestionBiblioteca.UI.Formularios
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            FormLibros form = new FormLibros();
            form.ShowDialog();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            FormAutores form = new FormAutores();
            form.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios form = new FormUsuarios();
            form.ShowDialog();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            FormPrestamos form = new FormPrestamos();
            form.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes form = new FormReportes();
            form.ShowDialog();
        }

        private void btnColaEspera_Click(object sender, EventArgs e)
        {
            FormColaEspera form = new FormColaEspera();
            form.ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial form = new FormHistorial();
            form.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
