using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente
    {
        private int clienteId,clienteTelefono,tipoClienteId;
        private string clienteNombre = "", clienteApellido = "";
        //Faltan clienteFechaNacimiento y fechaAdicionBanco

        public Cliente() { }
        public Cliente(int clienteId, int clienteTelefono, int tipoClienteId, string clienteNombre, string clienteApellido) {
            this.clienteId = clienteId;
            this.clienteTelefono = clienteTelefono;
            this.tipoClienteId = tipoClienteId;
            this.clienteNombre= clienteNombre;
            this.clienteApellido= clienteApellido;
        }
    }
}
