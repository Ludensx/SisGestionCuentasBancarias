using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmTipoClienteConsultar : Form
    {
        public FrmTipoClienteConsultar()
        {
            InitializeComponent();
        }
        TipoCliente tp = new TipoCliente();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
             try
             {
                DataSet ds = new DataSet();
                ds = tp.consultarTipoCliente(int.Parse(txtId.Text));
                dgvConsulta.DataSource = ds;
                dgvConsulta.DataMember = "ResultadoDatos";
            }
             catch
             {
                MessageBox.Show("No se Puede Realizar la Consulta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            try {
                DataSet ds = new DataSet();
                ds = tp.consultarTipoClientes();
                dgvConsulta.DataSource = ds;
                dgvConsulta.DataMember = "ResultadoDatos";
            }
            catch{
                MessageBox.Show("No se Puede Realizar la Consulta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
