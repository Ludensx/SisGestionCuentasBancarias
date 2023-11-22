namespace Vista
{
    partial class FrmTipoCuentaEliminar
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
            lbID = new Label();
            txtID = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(28, 29);
            lbID.Name = "lbID";
            lbID.Size = new Size(20, 15);
            lbID.TabIndex = 0;
            lbID.Text = "Id:";
            lbID.Click += lbID_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(54, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 1;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(42, 64);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmTipoCuentaEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 213);
            Controls.Add(btnAceptar);
            Controls.Add(txtID);
            Controls.Add(lbID);
            Name = "FrmTipoCuentaEliminar";
            Text = "Eliminar un tipo de cuenta";
            Load += FrmTipoCuentaEliminar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbID;
        private TextBox txtID;
        private Button btnAceptar;
    }
}