using SistemaGestionBiblioteca.UI.Formularios;
using System;
using System.Windows.Forms;

namespace SistemaGestionBiblioteca.UI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin());
        }    
    }
}
