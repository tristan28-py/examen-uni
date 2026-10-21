using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using SistemaGestionBiblioteca.Datos.Conexion;
using SistemaGestionBiblioteca.Entidades.Entidades;
using SistemaGestionBiblioteca.Entidades.Interfaces;

namespace SistemaGestionBiblioteca.Datos.Repositorios
{
    public class LibroRepositorio : IRepositorio<Libro>
    {
        public List<Libro> ObtenerTodos()
        {
            List<Libro> libros = new List<Libro>();
            string sql = "SELECT * FROM Libro";

            using (SqlConnection conexion = ConexionBD.CrearConexion())
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(sql, conexion);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Libro libro = new Libro();
                        libro.LibroId = Convert.ToInt32(dr["LibroId"]);
                        libro.Titulo = dr["Titulo"].ToString() ?? "";
                        libro.ISBN = dr["ISBN"].ToString() ?? "";
                        libro.Existencias = Convert.ToInt32(dr["Existencias"]);
                        libro.AutorId = Convert.ToInt32(dr["AutorId"]);
                        libro.Activo = Convert.ToBoolean(dr["Activo"]);
                        libros.Add(libro);
                    }
                }
            }
            return libros;
        }

        public void Insertar(Libro libro)
        {
            string sql = "INSERT INTO Libro (Titulo, ISBN, Existencias, AutorId, Activo) VALUES (@Titulo, @ISBN, @Existencias, @AutorId, @Activo)";

            using (SqlConnection conexion = ConexionBD.CrearConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@Titulo", libro.Titulo);
                    cmd.Parameters.AddWithValue("@ISBN", libro.ISBN);
                    cmd.Parameters.AddWithValue("@Existencias", libro.Existencias);
                    cmd.Parameters.AddWithValue("@AutorId", libro.AutorId);
                    cmd.Parameters.AddWithValue("@Activo", libro.Activo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Libro libro)
        {
            string sql = "UPDATE Libro SET Titulo=@Titulo, ISBN=@ISBN, Existencias=@Existencias, AutorId=@AutorId, Activo=@Activo WHERE LibroId=@LibroId";

            using (SqlConnection conexion = ConexionBD.CrearConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@LibroId", libro.LibroId);
                    cmd.Parameters.AddWithValue("@Titulo", libro.Titulo);
                    cmd.Parameters.AddWithValue("@ISBN", libro.ISBN);
                    cmd.Parameters.AddWithValue("@Existencias", libro.Existencias);
                    cmd.Parameters.AddWithValue("@AutorId", libro.AutorId);
                    cmd.Parameters.AddWithValue("@Activo", libro.Activo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            string sql = "UPDATE Libro SET Activo=0 WHERE LibroId=@LibroId";

            using (SqlConnection conexion = ConexionBD.CrearConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@LibroId", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
