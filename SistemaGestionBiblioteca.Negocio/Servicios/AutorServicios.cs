using SistemaGestionBiblioteca.Entidades.Entidades;
using SistemaGestionBiblioteca.Entidades.Interfaces;
using System;
using System.Collections.Generic;

namespace SistemaGestionBiblioteca.Negocio.Servicios
{
    public class AutorServicios
    {
        private readonly IRepositorio<Autor> _autorRepositorio;

        public AutorServicios(IRepositorio<Autor> autorRepositorio)
        {
            _autorRepositorio = autorRepositorio;
        }

        public List<Autor> ObtenerTodos()
        {
            return _autorRepositorio.ObtenerTodos();
        }

        public void Insertar(Autor autor)
        {
            if (string.IsNullOrWhiteSpace(autor.Nombre))
            {
                throw new ArgumentException("El nombre del autor no puede estar vacío.");
            }
            
            _autorRepositorio.Insertar(autor);
        }

        public void Actualizar(Autor autor)
        {
            if (autor.AutorId <= 0)
            {
                throw new ArgumentException("El ID del autor debe ser un número positivo.");
            }

            if (string.IsNullOrWhiteSpace(autor.Nombre))
            {
                throw new ArgumentException("El nombre del autor no puede estar vacío.");
            }

            _autorRepositorio.Actualizar(autor);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID del autor debe ser un número positivo.");
            }

            _autorRepositorio.Eliminar(id);
        }
    }
}
