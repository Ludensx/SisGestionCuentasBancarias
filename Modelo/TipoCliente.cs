using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;

namespace Modelo
{
    public class TipoCliente
    {
        Datos dt = new Datos();
        public TipoCliente() { }

        public int ingresarTipoCliente(string tipoClienteDescripcion) {
            int res;
            string cadena;
            cadena = "begin crudtipocliente.insertartipocliente('" + tipoClienteDescripcion+"'); end;";
            res = dt.ejecutarDML(cadena);
            return res;
        }

        public int eliminarTipoCliente(int tipoClienteid) {
            int res;
            string cadena;
            cadena = "begin crudtipocliente.eliminartipocliente("+ tipoClienteid+"); end;";
            res = dt.ejecutarDML(cadena);
            return res;
        }

        public int actualizarTipoCliente(int tipoClienteid, string tipoClienteDescripcion) {
            int res;
            string cadena;
            cadena = "begin crudtipocliente.actualizartipocliente(" + tipoClienteid+",'"+ tipoClienteDescripcion 
                + "'); end;";
            res = dt.ejecutarDML(cadena);
            return res;
        }

        public DataSet consultarTipoClientes() {
            DataSet ds = new DataSet();
            string consulta;
            consulta = "select * from tipo_cliente where tipo_cliente_estado = 'Activo' ";
            //consulta = "declare cur sys_refcursor; begin cur := crudtipocliente.consultartipoclientes; end;";
            ds = dt.ejecutarSELECT(consulta);
            return ds;
        }

        public DataSet consultarTipoCliente(int tipoClienteId) {
            DataSet ds = new DataSet();
            string consulta;
            consulta = "select * from Tipo_Cliente where Tipo_Cliente_Id ="+tipoClienteId+" AND tipo_cliente_estado = 'Activo'";
            ds = dt.ejecutarSELECT(consulta);
            return ds;
        }
    }
}
