using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using SistemaGestionBiblioteca.Datos.Conexion;
using SistemaGestionBiblioteca.Entidades.Entidades;
using SistemaGestionBiblioteca.Entidades.Interfaces;

namespace SistemaGestionBiblioteca.Datos.Repositorios
{
    public class AutorRepositorio : IRepositorio<Autor>
    {
        // Obtener todos los autores
        public List<Autor> ObtenerTodos()
        {
            List<Autor> listaAutores = new List<Autor>();

            string consulta = "SELECT * FROM Autor";

            using (SqlConnection conexion = ConexionBD.CrearConexion())
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataReader datos = comando.ExecuteReader())
                    {
                        while (datos.Read())
                        {
                            Autor autor = new Autor();

                            autor.AutorId = Convert.ToInt32(datos["AutorId"]);
                            autor.Nombre = datos["Nombre"].ToString() ?? "";
                            autor.Nacionalidad = datos["Nacionalidad"] == DBNull.Value
                                ? null
                                : datos["Nacionalidad"].ToString();
                            autor.Activo = Convert.ToBoolean(datos["Activo"]);

                            listaAutores.Add(autor);
                        }
                    }
                }
            }

            return listaAutores;
        }

        // Insertar un nuevo autor
        public void Insertar(Autor autor)
        {
            string consulta = @"INSERT INTO Autor
                                (Nombre, Nacionalidad, Activo)
                                VALUES (@Nombre, @Nacionalidad, @Activo)";

            using (SqlConnection conexion = ConexionBD.CrearConexion())
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", autor.Nombre);
                    comando.Parameters.AddWithValue("@Nacionalidad",
                        (object?)autor.Nacionalidad ?? DBNull.Value);
                    comando.Parameters.AddWithValue("@Activo", autor.Activo);

                    comando.ExecuteNonQuery();
                }
            }
        }

        // Actualizar los datos de un autor
        public void Actualizar(Autor autor)
        {
            string consulta = @"UPDATE Autor
                                SET Nombre = @Nombre,
                                    Nacionalidad = @Nacionalidad,
                                    Activo = @Activo
                                WHERE AutorId = @AutorId";

            using (SqlConnection conexion = ConexionBD.CrearConexion())
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@AutorId", autor.AutorId);
                    comando.Parameters.AddWithValue("@Nombre", autor.Nombre);
                    comando.Parameters.AddWithValue("@Nacionalidad",
                        (object?)autor.Nacionalidad ?? DBNull.Value);
                    comando.Parameters.AddWithValue("@Activo", autor.Activo);

                    comando.ExecuteNonQuery();
                }
            }
        }

        // Desactivar un autor
        public void Eliminar(int id)
        {
            string consulta = @"UPDATE Autor
                                SET Activo = 0
                                WHERE AutorId = @AutorId";

            using (SqlConnection conexion = ConexionBD.CrearConexion())
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@AutorId", id);

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
