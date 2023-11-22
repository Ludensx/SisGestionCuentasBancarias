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
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 0;
            label1.Text = "Id: ";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(191, 11);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 22);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(52, 10);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(110, 23);
            txtId.TabIndex = 2;
            //txtId.TextChanged += txtId_TextChanged;
            // 
            // btnBuscarTodos
            // 
            btnBuscarTodos.Location = new Point(284, 12);
            btnBuscarTodos.Margin = new Padding(3, 2, 3, 2);
            btnBuscarTodos.Name = "btnBuscarTodos";
            btnBuscarTodos.Size = new Size(115, 22);
            btnBuscarTodos.TabIndex = 3;
            btnBuscarTodos.Text = "Buscar Todos";
            btnBuscarTodos.UseVisualStyleBackColor = true;
            btnBuscarTodos.Click += btnBuscarTodos_Click;
            // 
            // tipoClienteBindingSource
            // 
            tipoClienteBindingSource.DataSource = typeof(Modelo.TipoCliente);
            // 
            // dgvConsulta
            // 
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(10, 68);
            dgvConsulta.Margin = new Padding(3, 2, 3, 2);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.RowHeadersWidth = 51;
            dgvConsulta.RowTemplate.Height = 29;
            dgvConsulta.Size = new Size(393, 237);
            dgvConsulta.TabIndex = 4;
            //dgvConsulta.CellContentClick += dgvConsulta_CellContentClick;
            // 
            // FrmTipoClienteConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 314);
            Controls.Add(dgvConsulta);
            Controls.Add(btnBuscarTodos);
            Controls.Add(txtId);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmTipoClienteConsultar";
            Text = "FrmTipoClienteConsultar";
            //Load += FrmTipoClienteConsultar_Load;
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