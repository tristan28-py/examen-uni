using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using SistemaGestionBiblioteca.Datos.Conexion;
using SistemaGestionBiblioteca.Entidades.Entidades;
using SistemaGestionBiblioteca.Entidades.Interfaces;

namespace SistemaGestionBiblioteca.Datos.Repositorios
{
    public class UsuarioRepositorio : IRepositorio<Usuario>
    {
        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            string sql = "SELECT * FROM Usuario";

            using (SqlConnection conexion = ConexionBD.CrearConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(dr["UsuarioId"]);
                        usuario.Nombre = dr["Nombre"].ToString() ?? "";
                        usuario.Correo = dr["Correo"].ToString() ?? "";
                        usuario.Telefono = dr["Telefono"] == DBNull.Value ? null : dr["Telefono"].ToString();
                        usuario.Activo = Convert.ToBoolean(dr["Activo"]);
                        usuarios.Add(usuario);
                    }
                }
            }
            return usuarios;
        }

        public void Insertar(Usuario usuario)
        {
            string sql = "INSERT INTO Usuario (Nombre, Correo, Telefono, Activo) VALUES (@Nombre, @Correo, @Telefono, @Activo)";

            using (SqlConnection conexion = ConexionBD.CrearConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", (object?)usuario.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Activo", usuario.Activo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Usuario usuario)
        {
            string sql = "UPDATE Usuario SET Nombre=@Nombre, Correo=@Correo, Telefono=@Telefono, Activo=@Activo WHERE UsuarioId=@UsuarioId";

            using (SqlConnection conexion = ConexionBD.CrearConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@UsuarioId", usuario.Id);
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", (object?)usuario.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Activo", usuario.Activo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            string sql = "UPDATE Usuario SET Activo=0 WHERE UsuarioId=@UsuarioId";

            using (SqlConnection conexion = ConexionBD.CrearConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@UsuarioId", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

