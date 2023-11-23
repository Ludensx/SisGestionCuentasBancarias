namespace Vista
{
    public partial class FrmPaginaPcpal : Form
    {
        public FrmPaginaPcpal()
        {
            InitializeComponent();
        }

        #region Tipo_Cuenta
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoClienteAgregar newfrm = new FrmTipoClienteAgregar();
            newfrm.MdiParent = this;
            newfrm.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoClienteEliminar newfrm = new FrmTipoClienteEliminar();
            newfrm.MdiParent = this;
            newfrm.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoClienteActualizar newfrm = new FrmTipoClienteActualizar();
            newfrm.MdiParent = this;
            newfrm.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoClienteConsultar newfrm = new FrmTipoClienteConsultar();
            newfrm.MdiParent = this;
            newfrm.Show();
        }
        #endregion

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTipoCuentaAgregar newfrm = new FrmTipoCuentaAgregar();
            newfrm.MdiParent = this;
            newfrm.Show();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FrmTipoCuentaEliminar newfrm = new FrmTipoCuentaEliminar();
            newfrm.MdiParent = this;
            newfrm.Show();
        }


        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTipoCuentaActualizar newfrm = new FrmTipoCuentaActualizar();
            newfrm.MdiParent = this;
            newfrm.Show();

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTipoCuentaConsultar newfrm = new FrmTipoCuentaConsultar();
            newfrm.MdiParent = this;
            newfrm.Show();
        }

        private void agregarTipoCuentaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmTipoCuentaAgregar newfrm = new FrmTipoCuentaAgregar();
            newfrm.MdiParent = this;
            newfrm.Show();

        }

        private void eliminarTipoCuentaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmTipoCuentaEliminar newfrm = new FrmTipoCuentaEliminar();
            newfrm.MdiParent = this;
            newfrm.Show();
        }

        private void actualizarTipoCuentaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmTipoCuentaActualizar newfrm = new FrmTipoCuentaActualizar();
            newfrm.MdiParent = this;
            newfrm.Show();
        }

        private void consultarTipoCuentaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmTipoCuentaConsultar newfrm = new FrmTipoCuentaConsultar();
            newfrm.MdiParent = this;
            newfrm.Show();
        }

        private void agregarCuentaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmCuentaAgregar newfrm = new FrmCuentaAgregar();
            newfrm.MdiParent = this;
            newfrm.Show();
        }

        private void eliminarCuentaToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void actualizarCuentaToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void consultarCuentaToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
    }
}