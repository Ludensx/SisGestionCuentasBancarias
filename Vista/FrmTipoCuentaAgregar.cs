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
    public partial class FrmTipoCuentaAgregar : Form
    {
        public FrmTipoCuentaAgregar()
        {
            InitializeComponent();
        }

        TipoCuenta tc = new TipoCuenta();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //tc.ingresarTipoCuenta(textBox1.Text);
                MessageBox.Show("Tipo Cuenta Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Tipo Cuenta No Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmTipoCuentaAgregar_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
