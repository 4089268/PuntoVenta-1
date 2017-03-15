namespace Sistemas_de_Ventas
{
    partial class CAJA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAJA));
            this.btBuscar = new System.Windows.Forms.Button();
            this.btCancelarArt = new System.Windows.Forms.Button();
            this.btCancelarVenta = new System.Windows.Forms.Button();
            this.btCobrar = new System.Windows.Forms.Button();
            this.tbCodigoArt = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.lbProducto = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTicket = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.lbCajero = new System.Windows.Forms.Label();
            this.lbArticulos = new System.Windows.Forms.Label();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.lbIva = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbTurno = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.pnl_caja = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCerrarTurno = new System.Windows.Forms.Button();
            this.btAbrirTurno = new System.Windows.Forms.Button();
            this.tbFondo = new System.Windows.Forms.TextBox();
            this.cbTurnos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_caja.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(21, 31);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(220, 36);
            this.btBuscar.TabIndex = 0;
            this.btBuscar.Text = "BUSCAR ARTICULO   (F1)";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btCancelarArt
            // 
            this.btCancelarArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCancelarArt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarArt.Location = new System.Drawing.Point(247, 31);
            this.btCancelarArt.Name = "btCancelarArt";
            this.btCancelarArt.Size = new System.Drawing.Size(257, 36);
            this.btCancelarArt.TabIndex = 1;
            this.btCancelarArt.Text = "CANCELAR ARTICULO   (F2)";
            this.btCancelarArt.UseVisualStyleBackColor = false;
            this.btCancelarArt.Click += new System.EventHandler(this.btCancelarArt_Click);
            // 
            // btCancelarVenta
            // 
            this.btCancelarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCancelarVenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarVenta.Location = new System.Drawing.Point(510, 31);
            this.btCancelarVenta.Name = "btCancelarVenta";
            this.btCancelarVenta.Size = new System.Drawing.Size(220, 36);
            this.btCancelarVenta.TabIndex = 2;
            this.btCancelarVenta.Text = "CANCELAR VENTA   (F3)";
            this.btCancelarVenta.UseVisualStyleBackColor = false;
            this.btCancelarVenta.Click += new System.EventHandler(this.btCancelarVenta_Click);
            // 
            // btCobrar
            // 
            this.btCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btCobrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCobrar.Location = new System.Drawing.Point(736, 31);
            this.btCobrar.Name = "btCobrar";
            this.btCobrar.Size = new System.Drawing.Size(137, 36);
            this.btCobrar.TabIndex = 3;
            this.btCobrar.Text = "COBRAR   (F4)";
            this.btCobrar.UseVisualStyleBackColor = false;
            this.btCobrar.Click += new System.EventHandler(this.btCobrar_Click);
            // 
            // tbCodigoArt
            // 
            this.tbCodigoArt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCodigoArt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoArt.Location = new System.Drawing.Point(132, 88);
            this.tbCodigoArt.Name = "tbCodigoArt";
            this.tbCodigoArt.Size = new System.Drawing.Size(249, 22);
            this.tbCodigoArt.TabIndex = 4;
            this.tbCodigoArt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCodigoArt_KeyDown);
            this.tbCodigoArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigoArt_KeyPress);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(478, 88);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(85, 22);
            this.tbCantidad.TabIndex = 5;
            this.tbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantidad_KeyPress);
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducto.Location = new System.Drawing.Point(18, 91);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(108, 16);
            this.lbProducto.TabIndex = 6;
            this.lbProducto.Text = "Codigo Producto:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.precio,
            this.cantidad,
            this.total});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(21, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(592, 269);
            this.dataGridView1.TabIndex = 7;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 60;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 200;
            // 
            // precio
            // 
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 80;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 80;
            // 
            // total
            // 
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 80;
            // 
            // lbTicket
            // 
            this.lbTicket.AutoSize = true;
            this.lbTicket.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTicket.Location = new System.Drawing.Point(31, 409);
            this.lbTicket.Name = "lbTicket";
            this.lbTicket.Size = new System.Drawing.Size(67, 16);
            this.lbTicket.TabIndex = 8;
            this.lbTicket.Text = "Ticket No:";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(142, 409);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(48, 16);
            this.lbFecha.TabIndex = 9;
            this.lbFecha.Text = "Fecha:";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(239, 409);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(39, 16);
            this.lbHora.TabIndex = 10;
            this.lbHora.Text = "Hora:";
            // 
            // lbCajero
            // 
            this.lbCajero.AutoSize = true;
            this.lbCajero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCajero.Location = new System.Drawing.Point(326, 409);
            this.lbCajero.Name = "lbCajero";
            this.lbCajero.Size = new System.Drawing.Size(49, 16);
            this.lbCajero.TabIndex = 11;
            this.lbCajero.Text = "Cajero:";
            // 
            // lbArticulos
            // 
            this.lbArticulos.AutoSize = true;
            this.lbArticulos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArticulos.ForeColor = System.Drawing.Color.Red;
            this.lbArticulos.Location = new System.Drawing.Point(643, 128);
            this.lbArticulos.Name = "lbArticulos";
            this.lbArticulos.Size = new System.Drawing.Size(137, 24);
            this.lbArticulos.TabIndex = 12;
            this.lbArticulos.Text = "ARTICULOS:";
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotal.ForeColor = System.Drawing.Color.Red;
            this.lbSubTotal.Location = new System.Drawing.Point(643, 158);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(134, 24);
            this.lbSubTotal.TabIndex = 13;
            this.lbSubTotal.Text = "SUB TOTAL:";
            // 
            // lbIva
            // 
            this.lbIva.AutoSize = true;
            this.lbIva.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIva.ForeColor = System.Drawing.Color.Red;
            this.lbIva.Location = new System.Drawing.Point(643, 185);
            this.lbIva.Name = "lbIva";
            this.lbIva.Size = new System.Drawing.Size(48, 24);
            this.lbIva.TabIndex = 14;
            this.lbIva.Text = "IVA:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Red;
            this.lbTotal.Location = new System.Drawing.Point(643, 215);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(85, 24);
            this.lbTotal.TabIndex = 15;
            this.lbTotal.Text = "TOTAL:";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.Location = new System.Drawing.Point(399, 91);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(63, 16);
            this.lbCantidad.TabIndex = 17;
            this.lbCantidad.Text = "Cantidad:";
            // 
            // lbTurno
            // 
            this.lbTurno.AutoSize = true;
            this.lbTurno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurno.Location = new System.Drawing.Point(412, 409);
            this.lbTurno.Name = "lbTurno";
            this.lbTurno.Size = new System.Drawing.Size(44, 16);
            this.lbTurno.TabIndex = 18;
            this.lbTurno.Text = "Turno:";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cerrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Location = new System.Drawing.Point(758, 389);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(137, 36);
            this.btn_cerrar.TabIndex = 3;
            this.btn_cerrar.Text = "Cerrar Caja";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // pnl_caja
            // 
            this.pnl_caja.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_caja.Controls.Add(this.btCobrar);
            this.pnl_caja.Controls.Add(this.lbTurno);
            this.pnl_caja.Controls.Add(this.lbCajero);
            this.pnl_caja.Controls.Add(this.btBuscar);
            this.pnl_caja.Controls.Add(this.lbHora);
            this.pnl_caja.Controls.Add(this.lbTotal);
            this.pnl_caja.Controls.Add(this.lbFecha);
            this.pnl_caja.Controls.Add(this.lbIva);
            this.pnl_caja.Controls.Add(this.lbTicket);
            this.pnl_caja.Controls.Add(this.lbCantidad);
            this.pnl_caja.Controls.Add(this.lbSubTotal);
            this.pnl_caja.Controls.Add(this.btCancelarArt);
            this.pnl_caja.Controls.Add(this.lbArticulos);
            this.pnl_caja.Controls.Add(this.btCancelarVenta);
            this.pnl_caja.Controls.Add(this.dataGridView1);
            this.pnl_caja.Controls.Add(this.lbProducto);
            this.pnl_caja.Controls.Add(this.tbCodigoArt);
            this.pnl_caja.Controls.Add(this.tbCantidad);
            this.pnl_caja.Controls.Add(this.btn_cerrar);
            this.pnl_caja.Enabled = false;
            this.pnl_caja.Location = new System.Drawing.Point(12, 116);
            this.pnl_caja.Name = "pnl_caja";
            this.pnl_caja.Size = new System.Drawing.Size(1095, 450);
            this.pnl_caja.TabIndex = 19;
            this.pnl_caja.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCerrarTurno);
            this.panel1.Controls.Add(this.btAbrirTurno);
            this.panel1.Controls.Add(this.tbFondo);
            this.panel1.Controls.Add(this.cbTurnos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 98);
            this.panel1.TabIndex = 20;
            // 
            // btCerrarTurno
            // 
            this.btCerrarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCerrarTurno.Enabled = false;
            this.btCerrarTurno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCerrarTurno.Location = new System.Drawing.Point(31, 59);
            this.btCerrarTurno.Name = "btCerrarTurno";
            this.btCerrarTurno.Size = new System.Drawing.Size(134, 30);
            this.btCerrarTurno.TabIndex = 22;
            this.btCerrarTurno.Text = "CERRAR TURNO";
            this.btCerrarTurno.UseVisualStyleBackColor = false;
            this.btCerrarTurno.Click += new System.EventHandler(this.btCerrarTurno_Click);
            // 
            // btAbrirTurno
            // 
            this.btAbrirTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAbrirTurno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrirTurno.Location = new System.Drawing.Point(178, 59);
            this.btAbrirTurno.Name = "btAbrirTurno";
            this.btAbrirTurno.Size = new System.Drawing.Size(134, 30);
            this.btAbrirTurno.TabIndex = 21;
            this.btAbrirTurno.Text = "ABRIR TURNO";
            this.btAbrirTurno.UseVisualStyleBackColor = false;
            this.btAbrirTurno.Click += new System.EventHandler(this.btAbrirTurno_Click);
            // 
            // tbFondo
            // 
            this.tbFondo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFondo.Location = new System.Drawing.Point(82, 31);
            this.tbFondo.Name = "tbFondo";
            this.tbFondo.Size = new System.Drawing.Size(289, 22);
            this.tbFondo.TabIndex = 20;
            this.tbFondo.Text = "0.0";
            // 
            // cbTurnos
            // 
            this.cbTurnos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTurnos.FormattingEnabled = true;
            this.cbTurnos.Items.AddRange(new object[] {
            "PRIMERO",
            "SEGUNDO",
            "TERCERO"});
            this.cbTurnos.Location = new System.Drawing.Point(455, 3);
            this.cbTurnos.Name = "cbTurnos";
            this.cbTurnos.Size = new System.Drawing.Size(289, 24);
            this.cbTurnos.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "FONDO: $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "TURNO:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(82, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 22);
            this.textBox1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "CAJERO:";
            // 
            // CAJA
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1119, 578);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_caja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(20, 20);
            this.MinimizeBox = false;
            this.Name = "CAJA";
            this.Text = "CAJA";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.CAJA_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CAJA_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_caja.ResumeLayout(false);
            this.pnl_caja.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btCancelarArt;
        private System.Windows.Forms.Button btCancelarVenta;
        private System.Windows.Forms.Button btCobrar;
        private System.Windows.Forms.TextBox tbCodigoArt;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label lbTicket;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbCajero;
        private System.Windows.Forms.Label lbArticulos;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.Label lbIva;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbTurno;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Panel pnl_caja;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCerrarTurno;
        private System.Windows.Forms.Button btAbrirTurno;
        private System.Windows.Forms.TextBox tbFondo;
        private System.Windows.Forms.ComboBox cbTurnos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}