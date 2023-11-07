using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DetallesCompra
    {
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
    }
}
