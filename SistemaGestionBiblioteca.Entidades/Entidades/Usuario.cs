using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestionBiblioteca.Entidades.Entidades
{
    public class Usuario : Persona
    {
        public string Correo { get; set; }

        public bool Activo { get; set; } = true;

    }
}
