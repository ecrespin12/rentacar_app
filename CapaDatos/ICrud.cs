using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    interface ICrud<T>
    {
        DataTable Select();
        void Insertar(T entity);
        void Actualizar(T entity);
        DataSet ObtenerEntidad(int id);
    }
}
