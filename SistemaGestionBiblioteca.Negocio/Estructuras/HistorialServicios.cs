using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGestionBiblioteca.Negocio.Estructuras
{
    public class HistorialServicios
    {
        // Pila compartida en memoria para bitácora y deshacer (LIFO)
        private static readonly Stack<string> _pilaHistorial = new Stack<string>();

        // Registrar acción en la pila (Push)
        public void RegistrarAccion(string accion)
        {
            if (string.IsNullOrWhiteSpace(accion))
            {
                return;
            }

            string entrada = $"[{DateTime.Now:HH:mm:ss}] {accion}";
            _pilaHistorial.Push(entrada);
        }

        // Consultar la última acción registrada sin retirarla (Peek)
        public string? VerUltimaAccion()
        {
            if (_pilaHistorial.Count == 0)
            {
                return null;
            }

            return _pilaHistorial.Peek();
        }

        // Deshacer / retirar la última acción registrada (Pop - LIFO)
        public string DeshacerUltimaAccion()
        {
            if (_pilaHistorial.Count == 0)
            {
                throw new InvalidOperationException("No hay acciones en el historial para deshacer.");
            }

            return _pilaHistorial.Pop();
        }

        // Cantidad total de acciones apiladas (Count)
        public int TotalAcciones()
        {
            return _pilaHistorial.Count;
        }

        // Obtener todas las acciones para visualizarlas en un ListBox
        public List<string> ObtenerHistorial()
        {
            return _pilaHistorial.ToList();
        }

        // Limpiar el historial
        public void Limpiar()
        {
            _pilaHistorial.Clear();
        }
    }
}
