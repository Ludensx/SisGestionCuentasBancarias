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
    public partial class FrmCuentaActualizar : Form
    {
        public FrmCuentaActualizar()
        {
            InitializeComponent();
        }

        Cuenta c = new Cuenta();
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                c.actualizarCuenta(int.Parse(txtidcuenta.Text),int.Parse(txtsaldo.Text), int.Parse(txtIdtipoCuenta.Text), int.Parse(txtIdcliente.Text));
                MessageBox.Show("Tipo Cliente Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Tipo Cliente No Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
