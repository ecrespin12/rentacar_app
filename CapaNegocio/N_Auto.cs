using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_Auto
    {
        D_Auto dAuto = new D_Auto();

        public DataTable N_ListAuto()
        {
            return dAuto.D_ListAuto();
        }

        public void InsertAuto(E_Auto instancia)
        {

            dAuto.D_InsertAuto(instancia);
        }

        public void ActualizarAuto(E_Auto instancia)
        {

            dAuto.D_ActualizarAuto(instancia);
        }

        public void EliminarAuto(E_Auto instancia)
        {
            dAuto.D_EliminarAuto(instancia);
        }

        public DataSet GetAuto(int codigo)
        {
            return dAuto.D_GetAuto(codigo);
        }
    }
}
