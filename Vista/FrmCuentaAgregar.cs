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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class FrmCuentaAgregar : Form
    {
        public FrmCuentaAgregar()
        {
            InitializeComponent();
        }

        Cuenta c = new Cuenta();

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                c.ingresarCuenta(dateTimePicker1.Value, int.Parse(txtSaldo.Text), int.Parse(txtTipoCuentaID.Text), int.Parse(txtClienteID.Text));
                MessageBox.Show("Cuenta Registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Cuenta No Registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
