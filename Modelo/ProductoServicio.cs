using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ProductoServicio
    {
        private int productoServicioId, proveedorId;
        private string productoServicioDescripcion = "";

        public ProductoServicio() { }
        public ProductoServicio(int productoServicioId, int proveedorId, string productoServicioDescripcion) { 
            this.productoServicioId = productoServicioId;
            this.proveedorId = proveedorId;
            this.productoServicioDescripcion = productoServicioDescripcion;
        }
    }
}
