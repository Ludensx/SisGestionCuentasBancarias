namespace Vista
{
    partial class FrmCuentaAgregar
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
            lbfecha = new Label();
            label1 = new Label();
            txtSaldo = new TextBox();
            lbcuentaid = new Label();
            txtTipoCuentaID = new TextBox();
            lbClienteID = new Label();
            txtClienteID = new TextBox();
            Aceptar = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // lbfecha
            // 
            lbfecha.AutoSize = true;
            lbfecha.Location = new Point(26, 35);
            lbfecha.Name = "lbfecha";
            lbfecha.Size = new Size(87, 15);
            lbfecha.TabIndex = 2;
            lbfecha.Text = "Fecha Apertura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 76);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 4;
            label1.Text = "Saldo";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(119, 73);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(100, 23);
            txtSaldo.TabIndex = 5;
            // 
            // lbcuentaid
            // 
            lbcuentaid.AutoSize = true;
            lbcuentaid.Location = new Point(12, 126);
            lbcuentaid.Name = "lbcuentaid";
            lbcuentaid.Size = new Size(101, 15);
            lbcuentaid.TabIndex = 6;
            lbcuentaid.Text = "Id Tipo de cuenta:";
            // 
            // txtTipoCuentaID
            // 
            txtTipoCuentaID.Location = new Point(119, 123);
            txtTipoCuentaID.Name = "txtTipoCuentaID";
            txtTipoCuentaID.Size = new Size(100, 23);
            txtTipoCuentaID.TabIndex = 7;
            // 
            // lbClienteID
            // 
            lbClienteID.AutoSize = true;
            lbClienteID.Location = new Point(37, 179);
            lbClienteID.Name = "lbClienteID";
            lbClienteID.Size = new Size(60, 15);
            lbClienteID.TabIndex = 8;
            lbClienteID.Text = "Id Cliente:";
            // 
            // txtClienteID
            // 
            txtClienteID.Location = new Point(119, 179);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.Size = new Size(100, 23);
            txtClienteID.TabIndex = 9;
            // 
            // Aceptar
            // 
            Aceptar.Location = new Point(166, 235);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(75, 23);
            Aceptar.TabIndex = 10;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            Aceptar.Click += Aceptar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(119, 29);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // FrmCuentaAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 306);
            Controls.Add(dateTimePicker1);
            Controls.Add(Aceptar);
            Controls.Add(txtClienteID);
            Controls.Add(lbClienteID);
            Controls.Add(txtTipoCuentaID);
            Controls.Add(lbcuentaid);
            Controls.Add(txtSaldo);
            Controls.Add(label1);
            Controls.Add(lbfecha);
            Name = "FrmCuentaAgregar";
            Text = "Agregar una cuenta";
            //Load += FrmCuentaAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbfecha;
        private Label label1;
        private TextBox txtSaldo;
        private Label lbcuentaid;
        private TextBox txtTipoCuentaID;
        private Label lbClienteID;
        private TextBox txtClienteID;
        private Button Aceptar;
        private DateTimePicker dateTimePicker1;
    }
}