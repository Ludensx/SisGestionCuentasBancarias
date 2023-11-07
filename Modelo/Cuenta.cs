using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cuenta
    {
        private int cuentaId,cuentaSaldo,tipoCuentaId,clienteId;
        //Falta cuentaFechaApertura

        public Cuenta() { }
        public Cuenta(int cuentaId, int cuentaSaldo, int tipoCuentaId, int clienteId) {
            this.cuentaId = cuentaId;
            this.cuentaSaldo = cuentaSaldo;
            this.tipoCuentaId = tipoCuentaId;
            this.clienteId = clienteId;
        }
    }
}
