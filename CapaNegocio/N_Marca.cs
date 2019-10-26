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
    public class N_Marca
    {
        D_Marca dMarca = new D_Marca();

        public DataTable N_ListMarcas()
        {
            return dMarca.D_ListMarcas();
        }
        public void InsertMarca(E_Marca mar) {

            dMarca.D_InsertMarca(mar);
        }
    }
}
