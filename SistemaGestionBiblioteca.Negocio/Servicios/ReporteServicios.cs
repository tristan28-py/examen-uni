using SistemaGestionBiblioteca.Entidades.Entidades;
using SistemaGestionBiblioteca.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGestionBiblioteca.Negocio.Servicios
{
    public class ReporteServicios
    {
        private readonly IRepositorio<Libro> _libroRepositorio;
        private readonly IRepositorio<Prestamo> _prestamoRepositorio;

        public ReporteServicios(IRepositorio<Libro> libroRepositorio, IRepositorio<Prestamo> prestamoRepositorio)
        {
            _libroRepositorio = libroRepositorio;
            _prestamoRepositorio = prestamoRepositorio;
        }

        // 1. Libros con existencias menores a 5 unidades (Where)
        public List<Libro> ObtenerLibrosBajoStock()
        {
            return _libroRepositorio.ObtenerTodos()
                                    .Where(l => l.Existencias < 5)
                                    .ToList();
        }

        // 2. Libros ordenados alfabéticamente por título (OrderBy)
        public List<Libro> ObtenerLibrosOrdenadosPorTitulo()
        {
            return _libroRepositorio.ObtenerTodos()
                                    .OrderBy(l => l.Titulo)
                                    .ToList();
        }

        // 3. Cantidad de préstamos realizados por cada usuario (GroupBy y Count)
        public Dictionary<int, int> ObtenerCantidadPrestamosPorUsuario()
        {
            return _prestamoRepositorio.ObtenerTodos()
                                       .GroupBy(p => p.UsuarioId)
                                       .ToDictionary(g => g.Key, g => g.Count());
        }

        // 4. Total general de libros prestados actualmente en la biblioteca (Count con Where)
        public int ObtenerCantidadPrestamosActuales()
        {
            return _prestamoRepositorio.ObtenerTodos()
                                       .Count(p => p.Estado == "Prestado");
        }
    }
}
