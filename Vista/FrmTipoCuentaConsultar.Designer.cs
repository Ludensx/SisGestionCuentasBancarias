namespace Vista
{
    partial class FrmTipoCuentaConsultar
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
            lbId = new Label();
            txtId = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dgvConsulta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(31, 24);
            lbId.Name = "lbId";
            lbId.Size = new Size(20, 15);
            lbId.TabIndex = 0;
            lbId.Text = "Id:";
            lbId.Click += lbId_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(58, 20);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(189, 20);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(281, 19);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 3;
            button2.Text = "Buscar todos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dgvConsulta
            // 
            dgvConsulta.AllowUserToAddRows = false;
            dgvConsulta.AllowUserToDeleteRows = false;
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(7, 79);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.ReadOnly = true;
            dgvConsulta.RowTemplate.Height = 25;
            dgvConsulta.Size = new Size(388, 208);
            dgvConsulta.TabIndex = 4;
            dgvConsulta.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmTipoCuentaConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 295);
            Controls.Add(dgvConsulta);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtId);
            Controls.Add(lbId);
            Name = "FrmTipoCuentaConsultar";
            Text = "Consultar Tipo Cuenta";
            Load += FrmTipoCuentaConsultar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbId;
        private TextBox txtId;
        private Button button1;
        private Button button2;
        private DataGridView dgvConsulta;
    }
}