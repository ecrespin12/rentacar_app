using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Usuario
    {
        public int usr_codigo { get; set; }
        public string usr_nombre { get; set; }
        public string usr_apellido { get; set; }
        public string usr_correo { get; set; }
        public string usr_clave { get; set; }
        public DateTime usr_fecha_crea { get; set; }
        public string usr_codigo_aux { get; set; }
        public string usr_estado_usuario { get; set; }
        public string usr_pais { get; set; }
        public string usr_estado { get; set; }
        public string usr_ciudad { get; set; }
    }
}
