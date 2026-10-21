
using System;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace SistemaGestionBiblioteca.Datos.Conexion
{
    public static class ConexionBD
    {
        private static string _cadenaConexion =
            @"Server=KEITY\SQLEXPRESS;Database=BibliotecaDB;Integrated Security=True;TrustServerCertificate=True;";

        static ConexionBD()
        {
            try
            {
                var cadenaConfigurada =
                    ConfigurationManager.ConnectionStrings["BibliotecaConnection"]?.ConnectionString;

                if (!string.IsNullOrWhiteSpace(cadenaConfigurada))
                {
                    _cadenaConexion = cadenaConfigurada;
                }
            }
            catch
            {
             
            }
        }

        public static string CadenaConexion
        {
            get => _cadenaConexion;

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _cadenaConexion = value;
                }
            }
        }

        public static SqlConnection CrearConexion()
        {
            return new SqlConnection(_cadenaConexion);
        }
      
        public static (bool Exito, string Mensaje) ProbarConexion()
        {
            try
            {
                using var conexion = CrearConexion();
                conexion.Open();
                return (true,
                    "¡Conexión establecida correctamente con BibliotecaDB!");
            }
            catch (Exception ex)
            {
                return (false,
                    $"Error al conectar con SQL Server: {ex.Message}");
            }
        }
    }
}
