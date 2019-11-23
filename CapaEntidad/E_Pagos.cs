using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Pagos
    {
        public E_Pagos()
        {
        }
        public int par_codigo { get; set; }
        public int par_codusr { get; set; }
        public string par_forma_pago { get; set; }
        public decimal par_monto { get; set; }
        public DateTime par_fecha_pago { get; set; }
        public string par_estado { get; set; }

    }
}
