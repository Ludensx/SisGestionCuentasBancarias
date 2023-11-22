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
    public partial class FrmTipoCuentaEliminar : Form
    {
        public FrmTipoCuentaEliminar()
        {
            InitializeComponent();
        }

        private void FrmTipoCuentaEliminar_Load(object sender, EventArgs e)
        {

        }

        private void lbID_Click(object sender, EventArgs e)
        {

        }
        TipoCuenta tc = new TipoCuenta();
        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                tc.eliminarTipoCuenta(int.Parse(txtID.Text));
                MessageBox.Show("Tipo Cuenta Eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Tipo Cuenta No Eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
