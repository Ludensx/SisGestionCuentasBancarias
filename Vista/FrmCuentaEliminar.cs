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
    public partial class FrmCuentaEliminar : Form
    {
        public FrmCuentaEliminar()
        {
            InitializeComponent();
        }
         Cuenta c = new Cuenta();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                c.eliminarCuenta(int.Parse(txtID.Text));
                MessageBox.Show("Cuenta Eliminada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Cuenta No Eliminada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
