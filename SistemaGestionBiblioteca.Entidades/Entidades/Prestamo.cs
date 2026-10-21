using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestionBiblioteca.Entidades.Entidades
{
    public class Prestamo
    {
        public int PrestamoId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaPrestamo { get; set; } = DateTime.Now;
        public DateTime? FechaDevolucion { get; set; }
        public string Estado { get; set; } = "Prestado";
    }
}
