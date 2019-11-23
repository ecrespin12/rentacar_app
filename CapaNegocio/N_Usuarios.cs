using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Usuarios
    {
        D_Usuario dUsuarios = new D_Usuario();

        public DataTable Select()
        {
            return dUsuarios.Select();
        }

        public void Insertar(E_Usuario instancia)
        {

            dUsuarios.Insertar(instancia);
        }

        public void Actualizar(E_Usuario instancia)
        {

            dUsuarios.Actualizar(instancia);
        }

        public DataSet ObtenerEntidad(int codigo)
        {
            return dUsuarios.ObtenerEntidad(codigo);
        }

        public DataSet ExisteUsuario(string correo, string password) {

            return dUsuarios.ExisteUsuario(correo, password);
        }
    }
}
