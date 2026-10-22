using SistemaGestionBiblioteca.Entidades.Entidades;
using SistemaGestionBiblioteca.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGestionBiblioteca.Negocio.Servicios
{
    public class LibroServicios
    {
        private readonly IRepositorio<Libro> _libroRepositorio;

        public LibroServicios(IRepositorio<Libro> libroRepositorio)
        {
            _libroRepositorio = libroRepositorio;
        }

        public List<Libro> ObtenerTodos()
        {
            return _libroRepositorio.ObtenerTodos();
        }

        // Búsqueda por título o autor con LINQ (Módulo 1)
        public List<Libro> BuscarPorTitulo(string criterio)
        {
            if (string.IsNullOrWhiteSpace(criterio))
            {
                return _libroRepositorio.ObtenerTodos();
            }

            return _libroRepositorio.ObtenerTodos()
                                    .Where(l => l.Titulo.Contains(criterio, StringComparison.OrdinalIgnoreCase))
                                    .ToList();
        }

        public void Insertar(Libro libro)
        {
            ValidarLibro(libro);
            _libroRepositorio.Insertar(libro);
        }

        public void Actualizar(Libro libro)
        {
            if (libro.LibroId <= 0)
            {
                throw new ArgumentException("El ID del libro debe ser un número positivo.");
            }

            ValidarLibro(libro);
            _libroRepositorio.Actualizar(libro);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID del libro debe ser un número positivo.");
            }

            _libroRepositorio.Eliminar(id);
        }

        private void ValidarLibro(Libro libro)
        {
            if (string.IsNullOrWhiteSpace(libro.Titulo))
            {
                throw new ArgumentException("El título del libro no puede estar vacío.");
            }

            if (string.IsNullOrWhiteSpace(libro.ISBN))
            {
                throw new ArgumentException("El ISBN del libro no puede estar vacío.");
            }

            if (libro.Existencias < 0)
            {
                throw new ArgumentException("Las existencias del libro no pueden ser negativas.");
            }

            if (libro.AutorId <= 0)
            {
                throw new ArgumentException("El ID del autor debe ser un número positivo.");
            }
        }
    }
}
