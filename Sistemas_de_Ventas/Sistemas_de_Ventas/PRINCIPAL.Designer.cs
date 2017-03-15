namespace Sistemas_de_Ventas
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.msOpciones = new System.Windows.Forms.MenuStrip();
            this.Adminstrador = new System.Windows.Forms.ToolStripMenuItem();
            this.admUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.admProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Caja = new System.Windows.Forms.ToolStripMenuItem();
            this.Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Iniciar = new System.Windows.Forms.ToolStripMenuItem();
            this.msOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // msOpciones
            // 
            this.msOpciones.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.msOpciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Adminstrador,
            this.Caja,
            this.Salir,
            this.btn_Iniciar});
            this.msOpciones.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.msOpciones.Location = new System.Drawing.Point(0, 0);
            this.msOpciones.Name = "msOpciones";
            this.msOpciones.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msOpciones.Size = new System.Drawing.Size(1210, 26);
            this.msOpciones.TabIndex = 0;
            this.msOpciones.Text = "menuStrip1";
            // 
            // Adminstrador
            // 
            this.Adminstrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admUsuarios,
            this.admProductos,
            this.reportesToolStripMenuItem});
            this.Adminstrador.Name = "Adminstrador";
            this.Adminstrador.Size = new System.Drawing.Size(150, 22);
            this.Adminstrador.Text = "ADMINISTRADOR";
            // 
            // admUsuarios
            // 
            this.admUsuarios.Name = "admUsuarios";
            this.admUsuarios.Size = new System.Drawing.Size(214, 22);
            this.admUsuarios.Text = "Usuarios";
            this.admUsuarios.Click += new System.EventHandler(this.admUsuarios_Click);
            // 
            // admProductos
            // 
            this.admProductos.Name = "admProductos";
            this.admProductos.Size = new System.Drawing.Size(214, 22);
            this.admProductos.Text = "Productos";
            this.admProductos.Click += new System.EventHandler(this.admProductos_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeVentasToolStripMenuItem,
            this.porTurnoToolStripMenuItem,
            this.porCajeroToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.reportesToolStripMenuItem.Text = "Reportes de Ventas";
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            this.reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            this.reporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reporteDeVentasToolStripMenuItem.Text = "Por Fecha";
            this.reporteDeVentasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasToolStripMenuItem_Click);
            // 
            // porTurnoToolStripMenuItem
            // 
            this.porTurnoToolStripMenuItem.Name = "porTurnoToolStripMenuItem";
            this.porTurnoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.porTurnoToolStripMenuItem.Text = "Por Turno";
            this.porTurnoToolStripMenuItem.Click += new System.EventHandler(this.porTurnoToolStripMenuItem_Click);
            // 
            // porCajeroToolStripMenuItem
            // 
            this.porCajeroToolStripMenuItem.Name = "porCajeroToolStripMenuItem";
            this.porCajeroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.porCajeroToolStripMenuItem.Text = "Por Cajero";
            this.porCajeroToolStripMenuItem.Click += new System.EventHandler(this.porCajeroToolStripMenuItem_Click);
            // 
            // Caja
            // 
            this.Caja.Name = "Caja";
            this.Caja.Size = new System.Drawing.Size(62, 22);
            this.Caja.Text = "CAJA";
            this.Caja.Click += new System.EventHandler(this.Caja_Click);
            // 
            // Salir
            // 
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(65, 22);
            this.Salir.Text = "SALIR";
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Iniciar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Iniciar.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(74, 22);
            this.btn_Iniciar.Text = "INICIAR";
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1210, 733);
            this.Controls.Add(this.msOpciones);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msOpciones;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Principal";
            this.Text = "SISTEMA DE PUNTO DE VENTA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.msOpciones.ResumeLayout(false);
            this.msOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msOpciones;
        private System.Windows.Forms.ToolStripMenuItem Adminstrador;
        private System.Windows.Forms.ToolStripMenuItem admUsuarios;
        private System.Windows.Forms.ToolStripMenuItem admProductos;
        private System.Windows.Forms.ToolStripMenuItem Caja;
        private System.Windows.Forms.ToolStripMenuItem Salir;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCajeroToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem btn_Iniciar;
    }
}