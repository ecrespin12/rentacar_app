using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Auto
    {
        //constructor
        public E_Auto() { }

        public int codAuto { get; set; }
        public int codMarca { get; set; }
        public int codColor { get; set; }
        public int codTipoAuto { get; set; }
        public String modelo { get; set; }
        public DateTime anio { get; set; }
        public String placa { get; set; }
        public String estado { get; set; }
    }
}
