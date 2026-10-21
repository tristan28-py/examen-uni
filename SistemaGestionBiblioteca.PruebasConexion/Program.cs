
using System;
using SistemaGestionBiblioteca.Datos.Conexion;

var resultado = ConexionBD.ProbarConexion();

Console.WriteLine(resultado.Mensaje);
