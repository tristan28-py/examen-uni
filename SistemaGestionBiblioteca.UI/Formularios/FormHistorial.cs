using System;
using System.Windows.Forms;

namespace SistemaGestionBiblioteca.UI.Formularios
{
    public partial class FormHistorial : Form
    {
        public FormHistorial()
        {
            InitializeComponent();
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
            ActualizarVistaHistorial();
        }

        private void ActualizarVistaHistorial()
        {
            try
            {
                lstHistorial.Items.Clear();
                var historial = ServiciosContext.HistorialServicio.ObtenerHistorial();

                foreach (var item in historial)
                {
                    lstHistorial.Items.Add(item);
                }

                lblTotalPila.Text = ServiciosContext.HistorialServicio.TotalAcciones().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerUltima_Click(object sender, EventArgs e)
        {
            try
            {
                string? ultima = ServiciosContext.HistorialServicio.VerUltimaAccion();

                if (ultima == null)
                {
                    MessageBox.Show("No hay acciones en el historial.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Última acción:\n\n{ultima}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            try
            {
                string accionRetirada = ServiciosContext.HistorialServicio.DeshacerUltimaAccion();

                MessageBox.Show($"Se deshizo la acción:\n\n{accionRetirada}", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarVistaHistorial();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshacer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarHistorial_Click(object sender, EventArgs e)
        {
            ServiciosContext.HistorialServicio.Limpiar();
            ActualizarVistaHistorial();
        }
    }
}
