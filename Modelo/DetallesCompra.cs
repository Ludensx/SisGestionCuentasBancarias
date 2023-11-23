using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DetallesCompra
    {
        
        Datos dt = new Datos();
        private int detallesId, detallesCantidad, detallesPrecioUnitario, detallesTotal
            ,compraId,productoServicioId;
        public DetallesCompra() { }
        public DetallesCompra(int detallesId, int detallesCantidad, int detallesPrecioUnitario, int detallesTotal, int compraId, int productoServicioId) {
            this.detallesId = detallesId;
            this.detallesCantidad = detallesCantidad;
            this.detallesPrecioUnitario = detallesPrecioUnitario;
            this.detallesTotal = detallesTotal;
            this.compraId = compraId;
            this.productoServicioId = productoServicioId;
        }

        public int ingresarDETALLES_COMPRA(int prm_detalles_cantidad, int prm_compra_id, int prm_producto_servicio_id)
        {
            int res;
            string cadena;
            cadena = "begin crudDETALLES_COMPRA.insertarDETALLES_COMPRA(" + prm_detalles_cantidad + ", " + prm_compra_id + ", " + prm_producto_servicio_id + "); end;";
            res = dt.ejecutarDML(cadena);
            return res;
        }
        public int actualizarEstadoDETALLES_COMPRA(int DETALLES_COMPRAid)
        {
            int res;
            string cadena;
            cadena = "begin crudDETALLES_COMPRA.actualizarEstadoDETALLES_COMPRA(" + DETALLES_COMPRAid + "); end;";
            res = dt.ejecutarDML(cadena);
            return res;
        }
        public int eliminarDETALLES_COMPRA(int DETALLES_COMPRAid)
        {
            int res;
            string cadena;
            cadena = "begin crudDETALLES_COMPRA.eliminarDETALLES_COMPRA(" + DETALLES_COMPRAid + "); end;";
            res = dt.ejecutarDML(cadena);
            return res;
        }
        
        public int actualizarDETALLES_COMPRA(int prm_detalles_id, int prm_detalles_cantidad, int prm_compra_id, int prm_producto_servicio_id, string prm_detalles_compra_estado)
        {
            int res;
            string cadena;
            cadena = "begin crudDETALLES_COMPRA.actualizarDETALLES_COMPRA(" + prm_detalles_id + ", " + prm_detalles_cantidad + ", " + prm_compra_id + ", " + prm_producto_servicio_id + ", '" + prm_detalles_compra_estado + "'); end;";
            res = dt.ejecutarDML(cadena);
            return res;
        }
        
        public DataSet consultarDETALLES_COMPRA()
        {
            DataSet ds = new DataSet();
            string consulta;
            consulta = "select * from DETALLES_COMPRA";
            ds = dt.ejecutarSELECT(consulta);
            return ds;
        }
        
        public DataSet consultarDETALLES_COMPRA(int DETALLES_COMPRAId)
        {
            DataSet ds = new DataSet();
            string consulta;
            consulta = "select * from DETALLES_COMPRA where DETALLES_COMPRA_Id =" + DETALLES_COMPRAId;
            ds = dt.ejecutarSELECT(consulta);
            return ds;
        }
    }
}
