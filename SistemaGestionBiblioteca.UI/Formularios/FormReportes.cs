using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaGestionBiblioteca.UI.Formularios
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            ActualizarMetricaTotal();
            btnBajoStock_Click(sender, e);
        }

        private void ActualizarMetricaTotal()
        {
            try
            {
                int totalPrestados = ServiciosContext.ReporteServicio.ObtenerCantidadPrestamosActuales();
                lblTotalLibrosPrestados.Text = totalPrestados.ToString();
            }
            catch (Exception ex)
            {
                lblTotalLibrosPrestados.Text = "0";
                MessageBox.Show("Error al calcular total de libros prestados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBajoStock_Click(object sender, EventArgs e)
        {
            try
            {
                lblDetalleReporte.Text = "Libros con existencias menores a 5:";
                var librosBajoStock = ServiciosContext.ReporteServicio.ObtenerLibrosBajoStock();
                dgvReporte.DataSource = null;
                dgvReporte.DataSource = librosBajoStock;
                ActualizarMetricaTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOrdenados_Click(object sender, EventArgs e)
        {
            try
            {
                lblDetalleReporte.Text = "Libros ordenados por título:";
                var librosOrdenados = ServiciosContext.ReporteServicio.ObtenerLibrosOrdenadosPorTitulo();
                dgvReporte.DataSource = null;
                dgvReporte.DataSource = librosOrdenados;
                ActualizarMetricaTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrestamosUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                lblDetalleReporte.Text = "Préstamos realizados por usuario:";

                var conteoDict = ServiciosContext.ReporteServicio.ObtenerCantidadPrestamosPorUsuario();
                var usuarios = ServiciosContext.UsuarioServicio.ObtenerTodos();

                var reporteUsuarios = conteoDict.Select(item =>
                {
                    var u = usuarios.FirstOrDefault(x => x.Id == item.Key);
                    return new
                    {
                        UsuarioId = item.Key,
                        Nombre = u != null ? u.Nombre : "Usuario #" + item.Key,
                        Correo = u != null ? u.Correo : "N/D",
                        TotalPrestamos = item.Value
                    };
                }).OrderByDescending(x => x.TotalPrestamos).ToList();

                dgvReporte.DataSource = null;
                dgvReporte.DataSource = reporteUsuarios;
                ActualizarMetricaTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
