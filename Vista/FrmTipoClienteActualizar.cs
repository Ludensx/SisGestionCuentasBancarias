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
    public partial class FrmTipoClienteActualizar : Form
    {
        public FrmTipoClienteActualizar()
        {
            InitializeComponent();
        }
        TipoCliente tp = new TipoCliente();
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                tp.actualizarTipoCliente(int.Parse(txtId.Text), txtDescripcion.Text);
                MessageBox.Show("Tipo Cliente Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Tipo Cliente No Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmTipoClienteActualizar_Load(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
