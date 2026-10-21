using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using SistemaGestionBiblioteca.Datos.Conexion;
using SistemaGestionBiblioteca.Entidades.Entidades;
using SistemaGestionBiblioteca.Entidades.Interfaces;

namespace SistemaGestionBiblioteca.Datos.Repositorios
{
    public class PrestamoRepositorio : IRepositorio<Prestamo>
    {
        public List<Prestamo> ObtenerTodos()
        {
            List<Prestamo> prestamos = new List<Prestamo>();
            string sql = "SELECT * FROM Prestamo";

            using (SqlConnection conexion = ConexionBD.CrearConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Prestamo prestamo = new Prestamo();
                        prestamo.PrestamoId = Convert.ToInt32(dr["PrestamoId"]);
                        prestamo.UsuarioId = Convert.ToInt32(dr["UsuarioId"]);
                        prestamo.FechaPrestamo = Convert.ToDateTime(dr["FechaPrestamo"]);
                        prestamo.FechaDevolucion = dr["FechaDevolucion"] == DBNull.Value
                            ? null : Convert.ToDateTime(dr["FechaDevolucion"]);
                        prestamo.Estado = dr["Estado"].ToString() ?? "";
                        prestamos.Add(prestamo);
                    }
                }
            }
            return prestamos;
        }

        public void Insertar(Prestamo prestamo)
        {
            string sql = "INSERT INTO Prestamo (UsuarioId, FechaPrestamo, FechaDevolucion, Estado) VALUES (@UsuarioId, @FechaPrestamo, @FechaDevolucion, @Estado)";

            using (SqlConnection conexion = ConexionBD.CrearConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@UsuarioId", prestamo.UsuarioId);
                    cmd.Parameters.AddWithValue("@FechaPrestamo", prestamo.FechaPrestamo);
                    cmd.Parameters.AddWithValue("@FechaDevolucion", (object?)prestamo.FechaDevolucion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Estado", prestamo.Estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Prestamo prestamo)
        {
            string sql = "UPDATE Prestamo SET UsuarioId=@UsuarioId, FechaPrestamo=@FechaPrestamo, FechaDevolucion=@FechaDevolucion, Estado=@Estado WHERE PrestamoId=@PrestamoId";

            using (SqlConnection conexion = ConexionBD.CrearConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@PrestamoId", prestamo.PrestamoId);
                    cmd.Parameters.AddWithValue("@UsuarioId", prestamo.UsuarioId);
                    cmd.Parameters.AddWithValue("@FechaPrestamo", prestamo.FechaPrestamo);
                    cmd.Parameters.AddWithValue("@FechaDevolucion", (object?)prestamo.FechaDevolucion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Estado", prestamo.Estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            string sql = "DELETE FROM Prestamo WHERE PrestamoId=@PrestamoId";

            using (SqlConnection conexion = ConexionBD.CrearConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@PrestamoId", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
