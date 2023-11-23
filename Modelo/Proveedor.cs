using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Proveedor
    {
        
        Datos dt = new Datos();
        private int proveedorId, proveedorTelefono;
        private string proveedorNombre = "", proveedorEmail = "", proveedorDescripcion = "";

        public Proveedor() { }
        public Proveedor(int proveedorId, int proveedorTelefono, string proveedorNombre, string proveedorEmail, string proveedorDescripcion) {
            this.proveedorId = proveedorId;
            this.proveedorTelefono = proveedorTelefono;
            this.proveedorNombre = proveedorNombre;
            this.proveedorEmail = proveedorEmail;
            this.proveedorDescripcion = proveedorDescripcion;
        }
        public int ingresarProveedor(int proveedorId, int proveedorTelefono, string proveedorNombre, string proveedorEmail, string proveedorDescripcion)
        {
            int res;
            string cadena;
            cadena = "begin crudProveedor.insertarProveedor(" + proveedorId + ", " + proveedorTelefono + ", '" + proveedorNombre + "', " + ", '" + proveedorEmail + "', " + ", '" + proveedorDescripcion + "'); end;";
            res = dt.ejecutarDML(cadena);
            return res;
        }
        public int actualizarEstadoProveedor(int Proveedorid)
        {
            int res;
            string cadena;
            cadena = "begin crudProveedor.actualizarEstadoProveedor(" + Proveedorid + "); end;";
            res = dt.ejecutarDML(cadena);
            return res;
        }
        public int eliminarProveedor(int Proveedorid)
        {
            int res;
            string cadena;
            cadena = "begin crudProveedor.eliminarProveedor(" + Proveedorid + "); end;";
            res = dt.ejecutarDML(cadena);
            return res;
        }
        
        public int actualizarProveedor(int proveedorId, int proveedorTelefono, string proveedorNombre, string proveedorEmail, string proveedorDescripcion)
        {
            int res;
            string cadena;
            cadena = "begin crudProveedor.actualizarProveedor(" + proveedorId + ", " + proveedorTelefono + ", '" + proveedorNombre + "', " + ", '" + proveedorEmail + "', " + ", '" + proveedorDescripcion + "'); end;";
            res = dt.ejecutarDML(cadena);
            return res;
        }
        
        public DataSet consultarProveedor()
        {
            DataSet ds = new DataSet();
            string consulta;
            consulta = "select * from Proveedor";
            ds = dt.ejecutarSELECT(consulta);
            return ds;
        }
        
        public DataSet consultarProveedor(int ProveedorId)
        {
            DataSet ds = new DataSet();
            string consulta;
            consulta = "select * from Proveedor where Proveedor_Id =" + ProveedorId;
            ds = dt.ejecutarSELECT(consulta);
            return ds;
        }
    }
}
