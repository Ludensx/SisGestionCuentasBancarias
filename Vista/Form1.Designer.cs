namespace Vista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTipoCliente = new Button();
            SuspendLayout();
            // 
            // btnTipoCliente
            // 
            btnTipoCliente.Location = new Point(12, 12);
            btnTipoCliente.Name = "btnTipoCliente";
            btnTipoCliente.Size = new Size(97, 37);
            btnTipoCliente.TabIndex = 0;
            btnTipoCliente.Text = "Tipo Cliente";
            btnTipoCliente.UseVisualStyleBackColor = true;
            btnTipoCliente.Click += btnTipoCliente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTipoCliente);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTipoCliente;
    }
}