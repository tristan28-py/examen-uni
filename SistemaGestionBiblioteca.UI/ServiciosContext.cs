using SistemaGestionBiblioteca.Datos.Repositorios;
using SistemaGestionBiblioteca.Entidades.Entidades;
using SistemaGestionBiblioteca.Entidades.Interfaces;
using SistemaGestionBiblioteca.Negocio.Estructuras;
using SistemaGestionBiblioteca.Negocio.Servicios;

namespace SistemaGestionBiblioteca.UI
{
    public static class ServiciosContext
    {
        // 4. POLIMORFISMO: Programación contra abstracciones (Sección 7 del PDF)
        public static readonly IRepositorio<Libro> LibroRepo = new LibroRepositorio();
        public static readonly IRepositorio<Autor> AutorRepo = new AutorRepositorio();
        public static readonly IRepositorio<Usuario> UsuarioRepo = new UsuarioRepositorio();
        public static readonly IRepositorio<Prestamo> PrestamoRepo = new PrestamoRepositorio();

        // Capa de Negocio
        public static readonly LibroServicios LibroServicio = new LibroServicios(LibroRepo);
        public static readonly AutorServicios AutorServicio = new AutorServicios(AutorRepo);
        public static readonly UsuarioServicios UsuarioServicio = new UsuarioServicios(UsuarioRepo);
        public static readonly PrestamoServicios PrestamoServicio = new PrestamoServicios(PrestamoRepo, LibroRepo);
        public static readonly ReporteServicios ReporteServicio = new ReporteServicios(LibroRepo, PrestamoRepo);

        // Estructuras en memoria (Cola FIFO y Pila LIFO)
        public static readonly ColaEsperaServicios ColaServicio = new ColaEsperaServicios();
        public static readonly HistorialServicios HistorialServicio = new HistorialServicios();
    }
}
