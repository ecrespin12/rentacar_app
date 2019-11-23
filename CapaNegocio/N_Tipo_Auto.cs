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
    public class N_Tipo_Auto
    {
        D_Tipo_Auto dTipoAuto = new D_Tipo_Auto();

        public DataTable N_ListTipoAuto()
        {
            return dTipoAuto.D_ListTipoAuto();
        }

        public void InsertTipoAuto(E_Tipo_Auto instancia)
        {

            dTipoAuto.D_InsertTipoAuto(instancia);
        }

        public void ActualizarTipoAuto(E_Tipo_Auto instancia)
        {

            dTipoAuto.D_ActualizarTipoAuto(instancia);
        }

        public void EliminarTipoAuto(E_Tipo_Auto instancia)
        {
            dTipoAuto.D_EliminarTipoAuto(instancia);
        }

        public DataSet GetTipoAuto(int codigo)
        {
            return dTipoAuto.D_GetTipoAuto(codigo);
        }
    }
}
