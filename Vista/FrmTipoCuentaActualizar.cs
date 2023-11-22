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
    public partial class FrmTipoCuentaActualizar : Form
    {
        public FrmTipoCuentaActualizar()
        {
            InitializeComponent();
        }

        TipoCuenta tc = new TipoCuenta();

   

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                tc.actualizarTipoCuenta(int.Parse(textId.Text), textDescripcion.Text);
                MessageBox.Show("Tipo Cuenta Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Tipo Cuenta No Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
    }
    }
}
