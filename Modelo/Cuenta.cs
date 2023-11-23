using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;

namespace Modelo
{
    public class Cuenta
    {
        Datos dt = new Datos();
              
        public Cuenta() { }
        public int ingresarCuenta(DateTime FechaApertura, int saldo, int tipoCuentaId, int clienteId)
        {
            int res;
            string cadena;
            cadena = "begin crudcuenta.insertarcuenta('" + FechaApertura.ToString("dd-MM-yyyy") + "' , " + saldo + "," + tipoCuentaId + " , " + clienteId + "); end;";
            res = dt.ejecutarDML(cadena);
            return res;
        }

        public int eliminarCuenta(int tipoCuenta)
        {
            int res;
            string cadena;
            cadena = "begin crudcuenta.eliminarcuenta(" + tipoCuenta + "); end;";
            res = dt.ejecutarDML(cadena);
            return res;
        }

        public int actualizarCuenta(int CuentaId, int saldo, int tipoCuentaId, int clienteId)
        {
            int res;
            string cadena;
            cadena = "begin crudcuenta.actualizarcuenta(" + CuentaId + "," + saldo + ","+ tipoCuentaId 
                + ","+ clienteId + "); end;";
            res = dt.ejecutarDML(cadena);
            return res;
        }

        public DataSet consultarCuentas()
        { 
            DataSet ds = new DataSet();
            string consulta;
            consulta = "select * from Cuenta";
            ds = dt.ejecutarSELECT(consulta);
            return ds;
        }

        public DataSet consultarCuenta(int CuentaId)
        {
            DataSet ds = new DataSet();
            string consulta;
            consulta = "select * from Cuenta where cuenta_id=" + CuentaId;
            ds = dt.ejecutarSELECT(consulta);
            return ds;
        }
    }
}
