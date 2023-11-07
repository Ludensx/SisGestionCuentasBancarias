using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class TipoCuenta
    {
        private int tipoCuentaId;
        private string tipoCuentaDescripcion = "";

        public TipoCuenta() { }
        public TipoCuenta(int tipoCuentaId, string tipoCuentaDescripcion) {
            this.tipoCuentaId = tipoCuentaId;
            this.tipoCuentaDescripcion = tipoCuentaDescripcion;
        }

    }
}
