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
    }
}
