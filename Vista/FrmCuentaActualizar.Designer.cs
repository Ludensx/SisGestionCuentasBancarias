namespace Vista
{
    partial class FrmCuentaActualizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtidcuenta = new TextBox();
            txtsaldo = new TextBox();
            txtIdtipoCuenta = new TextBox();
            txtIdcliente = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 36);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Id Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 75);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Saldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 111);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "ID tipo Cuenta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 150);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Id Cliente";
            // 
            // txtidcuenta
            // 
            txtidcuenta.Location = new Point(108, 32);
            txtidcuenta.Name = "txtidcuenta";
            txtidcuenta.Size = new Size(100, 23);
            txtidcuenta.TabIndex = 4;
            // 
            // txtsaldo
            // 
            txtsaldo.Location = new Point(107, 72);
            txtsaldo.Name = "txtsaldo";
            txtsaldo.Size = new Size(100, 23);
            txtsaldo.TabIndex = 5;
            // 
            // txtIdtipoCuenta
            // 
            txtIdtipoCuenta.Location = new Point(107, 108);
            txtIdtipoCuenta.Name = "txtIdtipoCuenta";
            txtIdtipoCuenta.Size = new Size(100, 23);
            txtIdtipoCuenta.TabIndex = 6;
            // 
            // txtIdcliente
            // 
            txtIdcliente.Location = new Point(107, 147);
            txtIdcliente.Name = "txtIdcliente";
            txtIdcliente.Size = new Size(100, 23);
            txtIdcliente.TabIndex = 7;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(90, 194);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmCuentaActualizar
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(btnAceptar);
            Controls.Add(txtIdcliente);
            Controls.Add(txtIdtipoCuenta);
            Controls.Add(txtsaldo);
            Controls.Add(txtidcuenta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCuentaActualizar";
            Text = "Actualizar Cuenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtidcuenta;
        private TextBox txtsaldo;
        private TextBox txtIdtipoCuenta;
        private TextBox txtIdcliente;
        private Button btnAceptar;
    }
}