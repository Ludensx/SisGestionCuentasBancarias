using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Proveedor
    {
        private int proveedorId, proveedorTelefono;
        private string proveedorNombre = "", proveedorEmail = "", proveedorDescripcion = "";

        public Proveedor() { }
        public Proveedor(int proveedorId, int proveedorTelefono, string proveedorNombre, string proveedorEmail, string proveedorDescripcion) {
            this.proveedorId = proveedorId;
            this.proveedorTelefono = proveedorTelefono;
            this.proveedorNombre = proveedorNombre;
            this.proveedorEmail = proveedorEmail;
            this.proveedorDescripcion = proveedorDescripcion;
        }
    }
}
