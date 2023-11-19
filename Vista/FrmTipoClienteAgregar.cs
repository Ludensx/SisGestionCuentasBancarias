using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Vista
{
    public partial class FrmTipoClienteAgregar : Form
    {
        public FrmTipoClienteAgregar()
        {
            InitializeComponent();
        }

        TipoCliente tp = new TipoCliente();
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try {
                tp.ingresarTipoCliente(txtDescripcion.Text);
                MessageBox.Show("Tipo Cliente Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch
            {
                MessageBox.Show("Tipo Cliente No Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
