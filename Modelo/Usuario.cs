using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        private int usuarioId;
        private string usuarioEmail = "", usuarioClave = "";

        public Usuario() { }
        public Usuario(int usuarioId, string usuarioEmail, string usuarioClave) {
            this.usuarioId = usuarioId;
            this.usuarioEmail = usuarioEmail;
            this.usuarioClave = usuarioClave;
        }
    }
}
