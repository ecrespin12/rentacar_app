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

        D_Renta dRenta = new D_Renta();
        public static DataSet N_GetAutosDisponibles(E_Renta renta, DataGridView grid)
        {
            return D_Renta.D_GetAutosDisponibles(renta, grid);
        }

        public static List<E_Conductor> ListaConductores()
        {
            return D_Renta.ListaConductores();
        }
        public DataSet N_GetTarifasAuto(int codigo)
        {
            return dRenta.D_GetTarifasAutos(codigo);
        }


        public static void  N_InsertRenta(E_Renta rent, string codAuto)
        {

             D_Renta.D_InsertRenta(rent, codAuto);
        }
    }
}
