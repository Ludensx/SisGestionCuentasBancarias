namespace Vista
{
    partial class FrmPaginaPcpal
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
            menu = new MenuStrip();
            tipoClienteToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            actualizarToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            tipoCuentaToolStripMenuItem1 = new ToolStripMenuItem();
            agregarTipoCuentaToolStripMenuItem2 = new ToolStripMenuItem();
            eliminarTipoCuentaToolStripMenuItem2 = new ToolStripMenuItem();
            actualizarTipoCuentaToolStripMenuItem2 = new ToolStripMenuItem();
            consultarTipoCuentaToolStripMenuItem2 = new ToolStripMenuItem();
            cuentaToolStripMenuItem = new ToolStripMenuItem();
            consultarCuentaToolStripMenuItem2 = new ToolStripMenuItem();
            tipoCuentaToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem1 = new ToolStripMenuItem();
            eliminarToolStripMenuItem1 = new ToolStripMenuItem();
            actualizarToolStripMenuItem1 = new ToolStripMenuItem();
            consultarToolStripMenuItem1 = new ToolStripMenuItem();
            agregarCuentaToolStripMenuItem2 = new ToolStripMenuItem();
            cuentaToolStripMenuItem1 = new ToolStripMenuItem();
            agregarCuentaToolStripMenuItem3 = new ToolStripMenuItem();
            eliminarCuentaToolStripMenuItem3 = new ToolStripMenuItem();
            actualizarCuentaToolStripMenuItem3 = new ToolStripMenuItem();
            consultarCuentaToolStripMenuItem3 = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { tipoClienteToolStripMenuItem, tipoCuentaToolStripMenuItem1, cuentaToolStripMenuItem, cuentaToolStripMenuItem1 });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(5, 2, 0, 2);
            menu.Size = new Size(700, 24);
            menu.TabIndex = 1;
            menu.Text = "menuStrip1";
            // 
            // tipoClienteToolStripMenuItem
            // 
            tipoClienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, eliminarToolStripMenuItem, actualizarToolStripMenuItem, consultarToolStripMenuItem });
            tipoClienteToolStripMenuItem.Name = "tipoClienteToolStripMenuItem";
            tipoClienteToolStripMenuItem.Size = new Size(82, 20);
            tipoClienteToolStripMenuItem.Text = "Tipo Cliente";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(126, 22);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(126, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // actualizarToolStripMenuItem
            // 
            actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            actualizarToolStripMenuItem.Size = new Size(126, 22);
            actualizarToolStripMenuItem.Text = "Actualizar";
            actualizarToolStripMenuItem.Click += actualizarToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(126, 22);
            consultarToolStripMenuItem.Text = "Consultar";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // tipoCuentaToolStripMenuItem1
            // 
            tipoCuentaToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { agregarTipoCuentaToolStripMenuItem2, eliminarTipoCuentaToolStripMenuItem2, actualizarTipoCuentaToolStripMenuItem2, consultarTipoCuentaToolStripMenuItem2 });
            tipoCuentaToolStripMenuItem1.Name = "tipoCuentaToolStripMenuItem1";
            tipoCuentaToolStripMenuItem1.Size = new Size(83, 20);
            tipoCuentaToolStripMenuItem1.Text = "Tipo Cuenta";
            // 
            // agregarTipoCuentaToolStripMenuItem2
            // 
            agregarTipoCuentaToolStripMenuItem2.Name = "agregarTipoCuentaToolStripMenuItem2";
            agregarTipoCuentaToolStripMenuItem2.Size = new Size(180, 22);
            agregarTipoCuentaToolStripMenuItem2.Text = "Agregar";
            agregarTipoCuentaToolStripMenuItem2.Click += agregarTipoCuentaToolStripMenuItem2_Click;
            // 
            // eliminarTipoCuentaToolStripMenuItem2
            // 
            eliminarTipoCuentaToolStripMenuItem2.Name = "eliminarTipoCuentaToolStripMenuItem2";
            eliminarTipoCuentaToolStripMenuItem2.Size = new Size(180, 22);
            eliminarTipoCuentaToolStripMenuItem2.Text = "Eliminar";
            eliminarTipoCuentaToolStripMenuItem2.Click += eliminarTipoCuentaToolStripMenuItem2_Click;
            // 
            // actualizarTipoCuentaToolStripMenuItem2
            // 
            actualizarTipoCuentaToolStripMenuItem2.Name = "actualizarTipoCuentaToolStripMenuItem2";
            actualizarTipoCuentaToolStripMenuItem2.Size = new Size(180, 22);
            actualizarTipoCuentaToolStripMenuItem2.Text = "Actualizar ";
            actualizarTipoCuentaToolStripMenuItem2.Click += actualizarTipoCuentaToolStripMenuItem2_Click;
            // 
            // consultarTipoCuentaToolStripMenuItem2
            // 
            consultarTipoCuentaToolStripMenuItem2.Name = "consultarTipoCuentaToolStripMenuItem2";
            consultarTipoCuentaToolStripMenuItem2.Size = new Size(180, 22);
            consultarTipoCuentaToolStripMenuItem2.Text = "Consultar";
            consultarTipoCuentaToolStripMenuItem2.Click += consultarTipoCuentaToolStripMenuItem2_Click;
            // 
            // cuentaToolStripMenuItem
            // 
            cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            cuentaToolStripMenuItem.Size = new Size(12, 20);
            // 
            // consultarCuentaToolStripMenuItem2
            // 
            consultarCuentaToolStripMenuItem2.Name = "consultarCuentaToolStripMenuItem2";
            consultarCuentaToolStripMenuItem2.Size = new Size(180, 22);
            consultarCuentaToolStripMenuItem2.Text = "Consultar";
            // 
            // tipoCuentaToolStripMenuItem
            // 
            tipoCuentaToolStripMenuItem.Name = "tipoCuentaToolStripMenuItem";
            tipoCuentaToolStripMenuItem.Size = new Size(32, 19);
            // 
            // agregarToolStripMenuItem1
            // 
            agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            agregarToolStripMenuItem1.Size = new Size(180, 22);
            agregarToolStripMenuItem1.Text = "Agregar";
            agregarToolStripMenuItem1.Click += agregarToolStripMenuItem1_Click;
            // 
            // eliminarToolStripMenuItem1
            // 
            eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            eliminarToolStripMenuItem1.Size = new Size(180, 22);
            eliminarToolStripMenuItem1.Text = "Eliminar";
            eliminarToolStripMenuItem1.Click += eliminarToolStripMenuItem1_Click;
            // 
            // actualizarToolStripMenuItem1
            // 
            actualizarToolStripMenuItem1.Name = "actualizarToolStripMenuItem1";
            actualizarToolStripMenuItem1.Size = new Size(180, 22);
            actualizarToolStripMenuItem1.Text = "Actualizar";
            actualizarToolStripMenuItem1.Click += actualizarToolStripMenuItem1_Click;
            // 
            // consultarToolStripMenuItem1
            // 
            consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            consultarToolStripMenuItem1.Size = new Size(180, 22);
            consultarToolStripMenuItem1.Text = "Consultar";
            consultarToolStripMenuItem1.Click += consultarToolStripMenuItem1_Click;
            // 
            // agregarCuentaToolStripMenuItem2
            // 
            agregarCuentaToolStripMenuItem2.Name = "agregarCuentaToolStripMenuItem2";
            agregarCuentaToolStripMenuItem2.Size = new Size(180, 22);
            agregarCuentaToolStripMenuItem2.Text = "Agregar";
            // 
            // cuentaToolStripMenuItem1
            // 
            cuentaToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { agregarCuentaToolStripMenuItem3, eliminarCuentaToolStripMenuItem3, actualizarCuentaToolStripMenuItem3, consultarCuentaToolStripMenuItem3 });
            cuentaToolStripMenuItem1.Name = "cuentaToolStripMenuItem1";
            cuentaToolStripMenuItem1.Size = new Size(57, 20);
            cuentaToolStripMenuItem1.Text = "Cuenta";
            // 
            // agregarCuentaToolStripMenuItem3
            // 
            agregarCuentaToolStripMenuItem3.Name = "agregarCuentaToolStripMenuItem3";
            agregarCuentaToolStripMenuItem3.Size = new Size(180, 22);
            agregarCuentaToolStripMenuItem3.Text = "Agregar";
            agregarCuentaToolStripMenuItem3.Click += agregarCuentaToolStripMenuItem3_Click;
            // 
            // eliminarCuentaToolStripMenuItem3
            // 
            eliminarCuentaToolStripMenuItem3.Name = "eliminarCuentaToolStripMenuItem3";
            eliminarCuentaToolStripMenuItem3.Size = new Size(180, 22);
            eliminarCuentaToolStripMenuItem3.Text = "Eliminar";
            eliminarCuentaToolStripMenuItem3.Click += eliminarCuentaToolStripMenuItem3_Click;
            // 
            // actualizarCuentaToolStripMenuItem3
            // 
            actualizarCuentaToolStripMenuItem3.Name = "actualizarCuentaToolStripMenuItem3";
            actualizarCuentaToolStripMenuItem3.Size = new Size(180, 22);
            actualizarCuentaToolStripMenuItem3.Text = "Actualizar";
            actualizarCuentaToolStripMenuItem3.Click += actualizarCuentaToolStripMenuItem3_Click;
            // 
            // consultarCuentaToolStripMenuItem3
            // 
            consultarCuentaToolStripMenuItem3.Name = "consultarCuentaToolStripMenuItem3";
            consultarCuentaToolStripMenuItem3.Size = new Size(180, 22);
            consultarCuentaToolStripMenuItem3.Text = "Consultar";
            consultarCuentaToolStripMenuItem3.Click += consultarCuentaToolStripMenuItem3_Click;
            // 
            // FrmPaginaPcpal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(menu);
            IsMdiContainer = true;
            MainMenuStrip = menu;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmPaginaPcpal";
            Text = "Pagina Principal";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menu;
        private ToolStripMenuItem tipoClienteToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem actualizarToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem tipoCuentaToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem1;
        private ToolStripMenuItem eliminarToolStripMenuItem1;
        private ToolStripMenuItem actualizarToolStripMenuItem1;
        private ToolStripMenuItem consultarToolStripMenuItem1;
        private ToolStripMenuItem tipoCuentaToolStripMenuItem1;
        private ToolStripMenuItem agregarTipoCuentaToolStripMenuItem2;
        private ToolStripMenuItem eliminarTipoCuentaToolStripMenuItem2;
        private ToolStripMenuItem actualizarTipoCuentaToolStripMenuItem2;
        private ToolStripMenuItem consultarTipoCuentaToolStripMenuItem2;
        private ToolStripMenuItem cuentaToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem2;
        private ToolStripMenuItem eliminarToolStripMenuItem2;
        private ToolStripMenuItem actualizarToolStripMenuItem2;
        private ToolStripMenuItem consultarCuentaToolStripMenuItem2;
        private ToolStripMenuItem agregarCuentaToolStripMenuItem2;
        private ToolStripMenuItem cuentaToolStripMenuItem1;
        private ToolStripMenuItem agregarCuentaToolStripMenuItem3;
        private ToolStripMenuItem eliminarCuentaToolStripMenuItem3;
        private ToolStripMenuItem actualizarCuentaToolStripMenuItem3;
        private ToolStripMenuItem consultarCuentaToolStripMenuItem3;
    }
}