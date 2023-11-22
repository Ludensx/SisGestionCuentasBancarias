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
    public partial class FrmTipoClienteEliminar : Form
    {
        public FrmTipoClienteEliminar()
        {
            InitializeComponent();
        }
        TipoCliente tp = new TipoCliente();
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                tp.eliminarTipoCliente(int.Parse(txtId.Text));
                MessageBox.Show("Tipo Cliente Eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Tipo Cliente No Eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmTipoClienteEliminar_Load(object sender, EventArgs e)
        {

        }
    }
}
