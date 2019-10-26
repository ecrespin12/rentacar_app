using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_Renta
    {
        public static DataSet N_GetAutosDisponibles(E_Renta renta, DataGridView grid)
        {
            return D_Renta.D_GetAutosDisponibles(renta, grid);
        }
    }
}
