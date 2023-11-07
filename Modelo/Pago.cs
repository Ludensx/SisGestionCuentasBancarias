using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pago
    {
        private int pagoId, pagoMonto, compraId, cuentaId;
        //Falta pagoFecha
        public Pago() { }
        public Pago(int pagoId, int pagoMonto, int compraId, int cuentaId) {
            this.pagoId = pagoId;
            this.pagoId = pagoMonto;
            this.compraId = compraId;
            this.cuentaId = cuentaId;
        }
    }
}
