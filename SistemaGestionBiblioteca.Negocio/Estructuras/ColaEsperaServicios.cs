using SistemaGestionBiblioteca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGestionBiblioteca.Negocio.Estructuras
{
    public class ColaEsperaServicios
    {
        // Cola compartida en memoria (FIFO)
        private static readonly Queue<Usuario> _colaUsuarios = new Queue<Usuario>();

        // Agregar usuario a la lista de espera (Enqueue)
        public void Encolar(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new ArgumentNullException(nameof(usuario), "El usuario no puede ser nulo.");
            }

            // Validar que no esté ya en la cola para no duplicar
            if (_colaUsuarios.Any(u => u.Id == usuario.Id))
            {
                throw new InvalidOperationException("El usuario ya se encuentra en la cola de espera.");
            }

            _colaUsuarios.Enqueue(usuario);
        }

        // Consultar el siguiente usuario sin extraerlo (Peek)
        public Usuario? VerSiguiente()
        {
            if (_colaUsuarios.Count == 0)
            {
                return null;
            }

            return _colaUsuarios.Peek();
        }

        // Atender y despachar al siguiente usuario (Dequeue - FIFO)
        public Usuario Despachar()
        {
            if (_colaUsuarios.Count == 0)
            {
                throw new InvalidOperationException("No hay usuarios en la cola de espera para atender.");
            }

            return _colaUsuarios.Dequeue();
        }

        // Cantidad de usuarios en espera (Count)
        public int CantidadEnEspera()
        {
            return _colaUsuarios.Count;
        }

        // Obtener la lista completa para mostrarla en pantalla (DataGridView o ListBox)
        public List<Usuario> ObtenerCola()
        {
            return _colaUsuarios.ToList();
        }

        // Limpiar la cola si se requiere
        public void Limpiar()
        {
            _colaUsuarios.Clear();
        }
    }
}
