using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Compra
    {
        private int compraId, compraCantidad, clienteId;
        //Falta compraFecha

        public Compra() { }
        public Compra(int compraId, int compraCantidad, int clienteId) {
            this.compraId = compraId;
            this.compraCantidad = compraCantidad;
            this.clienteId = clienteId;
        }
    }
}
