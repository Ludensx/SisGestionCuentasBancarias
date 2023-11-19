namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTipoCliente_Click(object sender, EventArgs e)
        {
            FrmTipoCliente newfrm = new FrmTipoCliente();
            newfrm.Show();   
        }
    }
}