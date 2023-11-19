namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
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
    }
}