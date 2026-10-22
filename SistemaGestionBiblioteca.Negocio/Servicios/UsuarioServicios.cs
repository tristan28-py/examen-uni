using SistemaGestionBiblioteca.Entidades.Entidades;
using SistemaGestionBiblioteca.Entidades.Interfaces;
using System;
using System.Collections.Generic;

namespace SistemaGestionBiblioteca.Negocio.Servicios
{
    public class UsuarioServicios
    {
        private readonly IRepositorio<Usuario> _usuarioRepositorio;

        public UsuarioServicios(IRepositorio<Usuario> usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public List<Usuario> ObtenerTodos()
        {
            return _usuarioRepositorio.ObtenerTodos();
        }

        public void Insertar(Usuario usuario)
        {
            ValidarUsuario(usuario);
            _usuarioRepositorio.Insertar(usuario);
        }

        public void Actualizar(Usuario usuario)
        {
            if (usuario.Id <= 0)
            {
                throw new ArgumentException("El ID del usuario debe ser un número positivo.");
            }

            ValidarUsuario(usuario);
            _usuarioRepositorio.Actualizar(usuario);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID del usuario debe ser un número positivo.");
            }

            _usuarioRepositorio.Eliminar(id);
        }

        private void ValidarUsuario(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Nombre))
            {
                throw new ArgumentException("El nombre del usuario no puede estar vacío.");
            }

            if (string.IsNullOrWhiteSpace(usuario.Correo))
            {
                throw new ArgumentException("El correo del usuario no puede estar vacío.");
            }

            if (!usuario.Correo.Contains("@") || !usuario.Correo.Contains("."))
            {
                throw new ArgumentException("El formato del correo electrónico no es válido.");
            }
        }
    }
}
