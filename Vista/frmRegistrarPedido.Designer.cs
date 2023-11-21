namespace Vista
{
    partial class frmRegistrarPedido
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Registrar Pedido");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Procesar pago");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Emitir comprobante");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Navegación", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarPedido));
            this.Navegación = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pedDNI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pedID = new System.Windows.Forms.TextBox();
            this.pedCantidad = new System.Windows.Forms.TextBox();
            this.Barra2 = new System.Windows.Forms.ToolStrip();
            this.RegistrarPedido = new System.Windows.Forms.ToolStripButton();
            this.ProcesarPago = new System.Windows.Forms.ToolStripButton();
            this.EmitirComprobante = new System.Windows.Forms.ToolStripButton();
            this.btnActualizarPedido = new System.Windows.Forms.Button();
            this.pedMonto = new System.Windows.Forms.TextBox();
            this.pedPlatillo = new System.Windows.Forms.ComboBox();
            this.pedCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.Barra = new System.Windows.Forms.ToolStrip();
            this.RegistrarVenta = new System.Windows.Forms.ToolStripButton();
            this.AfiliarCliente = new System.Windows.Forms.ToolStripButton();
            this.AdministrarMenus = new System.Windows.Forms.ToolStripButton();
            this.AdministrarPersonal = new System.Windows.Forms.ToolStripButton();
            this.Salir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.Barra2.SuspendLayout();
            this.Barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // Navegación
            // 
            this.Navegación.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Navegación.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Navegación.ItemHeight = 30;
            this.Navegación.Location = new System.Drawing.Point(0, 99);
            this.Navegación.Name = "Navegación";
            treeNode9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            treeNode9.Name = "Nodo1";
            treeNode9.Text = "Registrar Pedido";
            treeNode10.Name = "Nodo2";
            treeNode10.Text = "Procesar pago";
            treeNode11.Name = "Nodo3";
            treeNode11.Text = "Emitir comprobante";
            treeNode12.Name = "Nav";
            treeNode12.Text = "Navegación";
            this.Navegación.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.Navegación.Size = new System.Drawing.Size(161, 383);
            this.Navegación.TabIndex = 1;
            this.Navegación.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.pedDNI);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pedID);
            this.groupBox1.Controls.Add(this.pedCantidad);
            this.groupBox1.Controls.Add(this.Barra2);
            this.groupBox1.Controls.Add(this.btnActualizarPedido);
            this.groupBox1.Controls.Add(this.pedMonto);
            this.groupBox1.Controls.Add(this.pedPlatillo);
            this.groupBox1.Controls.Add(this.pedCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(167, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 334);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ASN Restaurant";
            // 
            // pedDNI
            // 
            this.pedDNI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedDNI.Location = new System.Drawing.Point(408, 138);
            this.pedDNI.Name = "pedDNI";
            this.pedDNI.Size = new System.Drawing.Size(149, 23);
            this.pedDNI.TabIndex = 15;
            this.pedDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "N° de DNI:";
            // 
            // pedID
            // 
            this.pedID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedID.Location = new System.Drawing.Point(498, 56);
            this.pedID.Name = "pedID";
            this.pedID.Size = new System.Drawing.Size(115, 23);
            this.pedID.TabIndex = 13;
            this.pedID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pedID.TextChanged += new System.EventHandler(this.pedID_TextChanged);
            // 
            // pedCantidad
            // 
            this.pedCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedCantidad.Location = new System.Drawing.Point(408, 216);
            this.pedCantidad.Name = "pedCantidad";
            this.pedCantidad.Size = new System.Drawing.Size(149, 23);
            this.pedCantidad.TabIndex = 12;
            this.pedCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pedCantidad.TextChanged += new System.EventHandler(this.pedCantidad_TextChanged);
            // 
            // Barra2
            // 
            this.Barra2.BackColor = System.Drawing.Color.Transparent;
            this.Barra2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistrarPedido,
            this.ProcesarPago,
            this.EmitirComprobante});
            this.Barra2.Location = new System.Drawing.Point(3, 19);
            this.Barra2.Name = "Barra2";
            this.Barra2.Size = new System.Drawing.Size(619, 25);
            this.Barra2.TabIndex = 11;
            this.Barra2.Text = "toolStrip1";
            // 
            // RegistrarPedido
            // 
            this.RegistrarPedido.BackColor = System.Drawing.Color.SandyBrown;
            this.RegistrarPedido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RegistrarPedido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarPedido.Image = ((System.Drawing.Image)(resources.GetObject("RegistrarPedido.Image")));
            this.RegistrarPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RegistrarPedido.Name = "RegistrarPedido";
            this.RegistrarPedido.Size = new System.Drawing.Size(106, 22);
            this.RegistrarPedido.Text = "Registrar Pedido";
            this.RegistrarPedido.Click += new System.EventHandler(this.RegistrarPedido_Click);
            // 
            // ProcesarPago
            // 
            this.ProcesarPago.BackColor = System.Drawing.Color.SkyBlue;
            this.ProcesarPago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ProcesarPago.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcesarPago.Image = ((System.Drawing.Image)(resources.GetObject("ProcesarPago.Image")));
            this.ProcesarPago.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProcesarPago.Name = "ProcesarPago";
            this.ProcesarPago.Size = new System.Drawing.Size(97, 22);
            this.ProcesarPago.Text = "Procesar Pago";
            this.ProcesarPago.Click += new System.EventHandler(this.ProcesarPago_Click);
            // 
            // EmitirComprobante
            // 
            this.EmitirComprobante.BackColor = System.Drawing.Color.SkyBlue;
            this.EmitirComprobante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EmitirComprobante.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmitirComprobante.Image = ((System.Drawing.Image)(resources.GetObject("EmitirComprobante.Image")));
            this.EmitirComprobante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EmitirComprobante.Name = "EmitirComprobante";
            this.EmitirComprobante.Size = new System.Drawing.Size(126, 22);
            this.EmitirComprobante.Text = "Emitir Comprobante";
            this.EmitirComprobante.Click += new System.EventHandler(this.EmitirComprobante_Click);
            // 
            // btnActualizarPedido
            // 
            this.btnActualizarPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPedido.Location = new System.Drawing.Point(347, 291);
            this.btnActualizarPedido.Name = "btnActualizarPedido";
            this.btnActualizarPedido.Size = new System.Drawing.Size(149, 28);
            this.btnActualizarPedido.TabIndex = 10;
            this.btnActualizarPedido.Text = "Actualizar Pedido";
            this.btnActualizarPedido.UseVisualStyleBackColor = true;
            this.btnActualizarPedido.Click += new System.EventHandler(this.btnActualizarPedido_Click);
            // 
            // pedMonto
            // 
            this.pedMonto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedMonto.Location = new System.Drawing.Point(408, 251);
            this.pedMonto.Name = "pedMonto";
            this.pedMonto.Size = new System.Drawing.Size(149, 23);
            this.pedMonto.TabIndex = 9;
            this.pedMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pedPlatillo
            // 
            this.pedPlatillo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedPlatillo.FormattingEnabled = true;
            this.pedPlatillo.Items.AddRange(new object[] {
            "Ají de Gallina",
            "Ceviche",
            "Chicharron",
            "Lomo Saltado",
            "Pollo al Horno",
            "Pachamanca",
            "Pollo a la Brasa"});
            this.pedPlatillo.Location = new System.Drawing.Point(408, 176);
            this.pedPlatillo.Name = "pedPlatillo";
            this.pedPlatillo.Size = new System.Drawing.Size(149, 25);
            this.pedPlatillo.TabIndex = 7;
            this.pedPlatillo.SelectedIndexChanged += new System.EventHandler(this.pedPlatillo_SelectedIndexChanged);
            // 
            // pedCliente
            // 
            this.pedCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedCliente.Location = new System.Drawing.Point(408, 100);
            this.pedCliente.Name = "pedCliente";
            this.pedCliente.Size = new System.Drawing.Size(149, 23);
            this.pedCliente.TabIndex = 6;
            this.pedCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Monto Unitario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Platillo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "N° de Pedido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 85);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(324, 439);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 34);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(523, 439);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(77, 34);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Barra
            // 
            this.Barra.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistrarVenta,
            this.AfiliarCliente,
            this.AdministrarMenus,
            this.AdministrarPersonal,
            this.Salir});
            this.Barra.Location = new System.Drawing.Point(0, 0);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(792, 95);
            this.Barra.TabIndex = 5;
            this.Barra.Text = "toolStrip1";
            // 
            // RegistrarVenta
            // 
            this.RegistrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RegistrarVenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarVenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RegistrarVenta.Image = ((System.Drawing.Image)(resources.GetObject("RegistrarVenta.Image")));
            this.RegistrarVenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RegistrarVenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RegistrarVenta.Name = "RegistrarVenta";
            this.RegistrarVenta.Size = new System.Drawing.Size(126, 92);
            this.RegistrarVenta.Text = "REGISTRAR VENTA";
            this.RegistrarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // AfiliarCliente
            // 
            this.AfiliarCliente.BackColor = System.Drawing.Color.Snow;
            this.AfiliarCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfiliarCliente.Image = ((System.Drawing.Image)(resources.GetObject("AfiliarCliente.Image")));
            this.AfiliarCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AfiliarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AfiliarCliente.Name = "AfiliarCliente";
            this.AfiliarCliente.Size = new System.Drawing.Size(113, 92);
            this.AfiliarCliente.Text = "AFILIAR CLIENTE";
            this.AfiliarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AfiliarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // AdministrarMenus
            // 
            this.AdministrarMenus.BackColor = System.Drawing.Color.Snow;
            this.AdministrarMenus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdministrarMenus.Image = ((System.Drawing.Image)(resources.GetObject("AdministrarMenus.Image")));
            this.AdministrarMenus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AdministrarMenus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AdministrarMenus.Name = "AdministrarMenus";
            this.AdministrarMenus.Size = new System.Drawing.Size(134, 92);
            this.AdministrarMenus.Text = "ADMINISTRAR MENÚS";
            this.AdministrarMenus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // AdministrarPersonal
            // 
            this.AdministrarPersonal.BackColor = System.Drawing.Color.Snow;
            this.AdministrarPersonal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdministrarPersonal.Image = ((System.Drawing.Image)(resources.GetObject("AdministrarPersonal.Image")));
            this.AdministrarPersonal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AdministrarPersonal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AdministrarPersonal.Name = "AdministrarPersonal";
            this.AdministrarPersonal.Size = new System.Drawing.Size(153, 92);
            this.AdministrarPersonal.Text = "ADMINISTRAR PERSONAL";
            this.AdministrarPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Snow;
            this.Salir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(76, 92);
            this.Salir.Text = "SALIR";
            this.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Salir.Click += new System.EventHandler(this.Salir_Click_1);
            // 
            // frmRegistrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 482);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Navegación);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Pedido";
            this.Load += new System.EventHandler(this.frmRegistrarPedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Barra2.ResumeLayout(false);
            this.Barra2.PerformLayout();
            this.Barra.ResumeLayout(false);
            this.Barra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView Navegación;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pedPlatillo;
        private System.Windows.Forms.TextBox pedCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnActualizarPedido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ToolStrip Barra2;
        private System.Windows.Forms.ToolStripButton RegistrarPedido;
        private System.Windows.Forms.ToolStripButton ProcesarPago;
        private System.Windows.Forms.ToolStripButton EmitirComprobante;
        private System.Windows.Forms.TextBox pedMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolStrip Barra;
        private System.Windows.Forms.ToolStripButton RegistrarVenta;
        private System.Windows.Forms.ToolStripButton AfiliarCliente;
        private System.Windows.Forms.ToolStripButton AdministrarMenus;
        private System.Windows.Forms.ToolStripButton AdministrarPersonal;
        private System.Windows.Forms.ToolStripButton Salir;
        private System.Windows.Forms.TextBox pedID;
        private System.Windows.Forms.TextBox pedDNI;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox pedCantidad;
    }
}

