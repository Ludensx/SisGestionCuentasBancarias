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
    public partial class FrmTipoCuentaConsultar : Form
    {
        public FrmTipoCuentaConsultar()
        {
            InitializeComponent();
        }

        TipoCuenta tc = new TipoCuenta();
        private void lbId_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = tc.consultarTipoCuenta(int.Parse(txtId.Text));
                dgvConsulta.DataSource = ds;
                dgvConsulta.DataMember = "ResultadoDatos";
            }
            catch
            {
                MessageBox.Show("No se Puede Realizar la Consulta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = tc.consultarTipoCuentas();
                dgvConsulta.DataSource = ds;
                dgvConsulta.DataMember = "ResultadoDatos";
            }
            catch
            {
                MessageBox.Show("No se Puede Realizar la Consulta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmTipoCuentaConsultar_Load(object sender, EventArgs e)
        {

        }
    }
}
