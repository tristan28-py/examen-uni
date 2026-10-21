using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestionBiblioteca.Entidades.Entidades
{
    public class Libro
    {
        public int LibroId { get; set; }

        public string Titulo { get; set; } = "";

        public string ISBN { get; set; }

        public int Existencias { get; set; }

        public int AutorId { get; set; }

        public bool Activo { get; set; } = true;

    }
}
