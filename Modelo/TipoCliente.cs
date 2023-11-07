using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class TipoCliente
    {
        private int tipoClienteId;
        private string tipoClienteDescripcion = "";

        public TipoCliente() { }
        public TipoCliente(int tipoClienteId, string tipoClienteDescripcion) {
            this.tipoClienteId = tipoClienteId;
            this.tipoClienteDescripcion = tipoClienteDescripcion;
        }
    }
}
