using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestionBiblioteca.Entidades.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> ObtenerTodos();

        void Insertar(T entidad);

        void Actualizar(T entidad);

        void Eliminar(int id);
    }
}
