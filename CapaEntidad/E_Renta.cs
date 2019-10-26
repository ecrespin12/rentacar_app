using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Renta
    {
        public E_Renta() { }


        public int CodigoRenta { get; set; }
        public int CodigoUsuario { get; set; }
        public int CodigoAuto { get; set; }
        public decimal DepositoRenta { get; set; }
        public DateTime FechaInicioRenta { get; set; }
        public DateTime FechaFinRenta { get; set; }
        public int CodigoConductor { get; set; }
        public string Status { get; set; }
        public int tarifaRenta { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public int CreateByUserId { get; set; }
        public int UpdateById { get; set; }
    }
}
