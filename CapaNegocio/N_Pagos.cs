using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Pagos
    {
        D_Pagos dPagos = new D_Pagos();

        public DataTable N_List()
        {
            return dPagos.D_List();
        }
        public DataTable N_List(string estado)
        {
            return dPagos.D_List(estado);
        }

        public DataTable N_Rentas()
        {
            return dPagos.D_Rentas();
        }
        //public DataTable N_List(string estado)
        //{
        //    return dPagos.D_List(estado);
        //}
    }
}
