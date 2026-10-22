using SistemaGestionBiblioteca.Entidades.Entidades;
using SistemaGestionBiblioteca.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGestionBiblioteca.Negocio.Servicios
{
    public class PrestamoServicios
    {
        private readonly IRepositorio<Prestamo> _repositorioPrestamo;
        private readonly IRepositorio<Libro> _repositorioLibro;

        public PrestamoServicios(IRepositorio<Prestamo> repositorioPrestamo, IRepositorio<Libro> repositorioLibro)
        {
            _repositorioLibro = repositorioLibro;
            _repositorioPrestamo = repositorioPrestamo;
        }

        public List<Prestamo> ObtenerTodos()
        {
            return _repositorioPrestamo.ObtenerTodos();
        }

        public void Insertar(Prestamo prestamo)
        {
            // Validaciones al insertar un préstamo
            if (prestamo.UsuarioId <= 0)
            {
                throw new ArgumentException("Debe seleccionar un usuario válido.");
            }

            if (prestamo.LibroId <= 0)
            {
                throw new ArgumentException("Debe seleccionar un libro válido.");
            }

            // Validar que el libro tenga existencias disponibles
            var libro = _repositorioLibro.ObtenerTodos().FirstOrDefault(l => l.LibroId == prestamo.LibroId);

            if (libro == null)
            {
                throw new ArgumentException("El libro seleccionado no existe.");
            }

            if (libro.Existencias <= 0)
            {
                throw new InvalidOperationException("No se puede realizar el préstamo. El libro no tiene existencias disponibles (Existencias = 0).");
            }

            // Configuración de la fecha de préstamo y devolución
            prestamo.FechaPrestamo = DateTime.Now;
            prestamo.FechaDevolucion = null;
            prestamo.Estado = "Prestado";

            // Actualizar las existencias del libro
            libro.Existencias -= 1;
            _repositorioLibro.Actualizar(libro);

            _repositorioPrestamo.Insertar(prestamo);
        }

        public void RegistrarDevolucion(int prestamoId)
        {
            var prestamo = _repositorioPrestamo.ObtenerTodos().FirstOrDefault(p => p.PrestamoId == prestamoId);

            if (prestamo == null)
            {
                throw new ArgumentException("El préstamo especificado no existe.");
            }

            if (prestamo.Estado == "Devuelto")
            {
                throw new InvalidOperationException("El préstamo ya ha sido devuelto.");
            }

            // Actualizar el estado del préstamo y la fecha de devolución
            prestamo.Estado = "Devuelto";
            prestamo.FechaDevolucion = DateTime.Now;
            _repositorioPrestamo.Actualizar(prestamo);

            // Actualizar las existencias del libro
            var libro = _repositorioLibro.ObtenerTodos().FirstOrDefault(l => l.LibroId == prestamo.LibroId);
            if (libro != null)
            {
                libro.Existencias += 1;
                _repositorioLibro.Actualizar(libro);
            }
        }
    }
}
