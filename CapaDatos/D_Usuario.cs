using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_Usuario : DataHelper<E_Usuario>, ICrud<E_Usuario>
    {
        public void Actualizar(E_Usuario entity)
        {
            IDictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("codigo", entity.usr_codigo);
            parameters.Add("nombre",entity.usr_nombre);
            parameters.Add("apellido", entity.usr_apellido);
            parameters.Add("correo", entity.usr_correo);
            parameters.Add("clave", entity.usr_clave);
            parameters.Add("fechacreacion", entity.usr_fecha_crea);
            parameters.Add("codigoaux", entity.usr_codigo_aux);
            parameters.Add("estadousr", entity.usr_estado_usuario);
            parameters.Add("pais", entity.usr_pais);
            parameters.Add("estado", entity.usr_estado);
            parameters.Add("ciudad", entity.usr_ciudad);
            this.ExecuteProcedure("usuario_update_sp", parameters);
        }

        public void Insertar(E_Usuario entity)
        {
            IDictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("nombre", entity.usr_nombre);
            parameters.Add("apellido", entity.usr_apellido);
            parameters.Add("correo", entity.usr_correo);
            parameters.Add("clave", entity.usr_clave);
            parameters.Add("fechacreacion", entity.usr_fecha_crea);
            parameters.Add("codigoaux", entity.usr_codigo_aux);
            parameters.Add("estadousr", entity.usr_estado_usuario);
            parameters.Add("pais", entity.usr_pais);
            parameters.Add("estado", entity.usr_estado);
            parameters.Add("ciudad", entity.usr_ciudad);
            this.ExecuteProcedure("usuario_insert_sp", parameters);
        }

        public DataSet ObtenerEntidad(int id)
        {
            IDictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("codigo", id);
            return getEntity("SELECT * FROM tbl_usr_usuario WHERE usr_codigo = @codigo", parameters);
        }

        public DataTable Select()
        {
            return getAll("select * from tbl_usr_usuario");
        }


        public DataSet ExisteUsuario(string correo, string password) {

            IDictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("correo", correo);
            parameters.Add("password", password);
            return getEntity("SELECT * FROM tbl_usr_usuario WHERE usr_correo = @correo and usr_clave = @password and usr_estado_usuario = '1' ", parameters);
        }
    }
}
