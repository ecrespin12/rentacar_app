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
    public class N_Color
    {
        D_Color dColor = new D_Color();

        public DataTable N_ListColor()
        {
            return dColor.D_ListColor();
        }
    }
}
