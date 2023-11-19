namespace Vista
{
    partial class FrmTipoClienteConsultar
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            btnBuscar = new Button();
            txtId = new TextBox();
            btnBuscarTodos = new Button();
            tipoClienteBindingSource = new BindingSource(components);
            dgvConsulta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tipoClienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "Id: ";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(218, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(60, 6);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 2;
            // 
            // btnBuscarTodos
            // 
            btnBuscarTodos.Location = new Point(330, 5);
            btnBuscarTodos.Name = "btnBuscarTodos";
            btnBuscarTodos.Size = new Size(131, 29);
            btnBuscarTodos.TabIndex = 3;
            btnBuscarTodos.Text = "Buscar Todos";
            btnBuscarTodos.UseVisualStyleBackColor = true;
            btnBuscarTodos.Click += btnBuscarTodos_Click;
            // 
            // tipoClienteBindingSource
            // 
            tipoClienteBindingSource.DataSource = typeof(Modelo.TipoCliente);
           // tipoClienteBindingSource.CurrentChanged += tipoClienteBindingSource_CurrentChanged;
            // 
            // dgvConsulta
            // 
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(12, 90);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.RowHeadersWidth = 51;
            dgvConsulta.RowTemplate.Height = 29;
            dgvConsulta.Size = new Size(449, 316);
            dgvConsulta.TabIndex = 4;
            // 
            // FrmTipoClienteConsultar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 418);
            Controls.Add(dgvConsulta);
            Controls.Add(btnBuscarTodos);
            Controls.Add(txtId);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Name = "FrmTipoClienteConsultar";
            Text = "FrmTipoClienteConsultar";
            ((System.ComponentModel.ISupportInitialize)tipoClienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBuscar;
        private TextBox txtId;
        private Button btnBuscarTodos;
        private BindingSource tipoClienteBindingSource;
        private DataGridView dgvConsulta;
    }
}