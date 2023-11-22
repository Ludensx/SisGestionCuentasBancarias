using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;

namespace Modelo
{
    public class TipoCuenta
    {
        Datos dt = new Datos();
        public TipoCuenta() { }

        public int ingresarTipoCuenta(string tipoCuentaDescripcion)
        {
            int res;
            string cadena;
            cadena = "begin crudtipo_cuenta.insertartipo_cuenta('" + tipoCuentaDescripcion + "'); end;";
            res = dt.ejecutarDML(cadena);
            return res;
        }

        public int eliminarTipoCuenta(int tipoCuentaid)
        {
            int res;
            string cadena;
            cadena = "begin crudtipo_cuenta.eliminartipo_cuenta(" + tipoCuentaid + "); end;";
            res = dt.ejecutarDML(cadena);
            return res;
        }
        public int actualizarTipoCuenta(int tipoCuentaid, string tipoCuentaDescripcion)
        {
            int res;
            string cadena;
            cadena = "begin crudtipo_cuenta.actualizartipo_cuenta(" + tipoCuentaid + ",'" + tipoCuentaDescripcion
                + "'); end;";
            res = dt.ejecutarDML(cadena);
            return res;
        }

        public DataSet consultarTipoCuentas()
        {
            DataSet ds = new DataSet();
            string consulta;
            consulta = "select * from tipo_cuenta";
            ds = dt.ejecutarSELECT(consulta);
            return ds;
        }

        public DataSet consultarTipoCuenta(int tipoCuentaId)
        {
            DataSet ds = new DataSet();
            string consulta;
            consulta = "select * from Tipo_Cuenta where Tipo_Cuenta_Id =" + tipoCuentaId;
            ds = dt.ejecutarSELECT(consulta);
            return ds;
        }
    }
}
