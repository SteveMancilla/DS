namespace Vista
{
    partial class FrmProcesarPago
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Registrar Pedido");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Registrar Pago");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Emitir Comprobante");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Navegación", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProcesarPago));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pago_ID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PreTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NumCuenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MonTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Barra2 = new System.Windows.Forms.ToolStrip();
            this.RegistrarPedido = new System.Windows.Forms.ToolStripButton();
            this.ProcesarPago = new System.Windows.Forms.ToolStripButton();
            this.EmitirComprobante = new System.Windows.Forms.ToolStripButton();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.treeView1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ItemHeight = 30;
            this.treeView1.Location = new System.Drawing.Point(0, 99);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "Nodo2";
            treeNode13.Text = "Registrar Pedido";
            treeNode14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            treeNode14.Name = "Nodo3";
            treeNode14.Text = "Registrar Pago";
            treeNode15.Name = "Nodo5";
            treeNode15.Text = "Emitir Comprobante";
            treeNode16.Name = "Nodo 1";
            treeNode16.Text = "Navegación";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(159, 366);
            this.treeView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.Pago_ID);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.PreTotal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.NumCuenta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.MonTipo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Barra2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(159, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 306);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ASN Restaurant";
            // 
            // Pago_ID
            // 
            this.Pago_ID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pago_ID.Location = new System.Drawing.Point(361, 60);
            this.Pago_ID.Name = "Pago_ID";
            this.Pago_ID.Size = new System.Drawing.Size(121, 23);
            this.Pago_ID.TabIndex = 23;
            this.Pago_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(370, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 50);
            this.button1.TabIndex = 22;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PreTotal
            // 
            this.PreTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreTotal.Location = new System.Drawing.Point(202, 259);
            this.PreTotal.Name = "PreTotal";
            this.PreTotal.Size = new System.Drawing.Size(121, 23);
            this.PreTotal.TabIndex = 21;
            this.PreTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Monto Total:";
            // 
            // NumCuenta
            // 
            this.NumCuenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCuenta.Location = new System.Drawing.Point(202, 206);
            this.NumCuenta.Name = "NumCuenta";
            this.NumCuenta.Size = new System.Drawing.Size(121, 23);
            this.NumCuenta.TabIndex = 19;
            this.NumCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumCuenta.TextChanged += new System.EventHandler(this.NumCuenta_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Número PYAC:";
            // 
            // MonTipo
            // 
            this.MonTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonTipo.FormattingEnabled = true;
            this.MonTipo.Items.AddRange(new object[] {
            "Efectivo",
            "Plin",
            "Yape",
            "Agora",
            "N° de cuenta"});
            this.MonTipo.Location = new System.Drawing.Point(202, 155);
            this.MonTipo.Name = "MonTipo";
            this.MonTipo.Size = new System.Drawing.Size(121, 25);
            this.MonTipo.TabIndex = 17;
            this.MonTipo.SelectedIndexChanged += new System.EventHandler(this.MonTipo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Seleccionar Tipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "PAGO POR TRANSFERENCIA O EFECTIVO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "IZI PAY";
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
            this.Barra2.Size = new System.Drawing.Size(500, 25);
            this.Barra2.TabIndex = 11;
            this.Barra2.Text = "toolStrip1";
            // 
            // RegistrarPedido
            // 
            this.RegistrarPedido.BackColor = System.Drawing.Color.SkyBlue;
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
            this.ProcesarPago.BackColor = System.Drawing.Color.SandyBrown;
            this.ProcesarPago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ProcesarPago.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcesarPago.Image = ((System.Drawing.Image)(resources.GetObject("ProcesarPago.Image")));
            this.ProcesarPago.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProcesarPago.Name = "ProcesarPago";
            this.ProcesarPago.Size = new System.Drawing.Size(97, 22);
            this.ProcesarPago.Text = "Procesar Pago";
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(371, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 32);
            this.button2.TabIndex = 43;
            this.button2.Text = "Retroceder";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(508, 421);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(77, 32);
            this.btnAceptar.TabIndex = 42;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(244, 421);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 32);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.Barra.Size = new System.Drawing.Size(665, 95);
            this.Barra.TabIndex = 44;
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
            // FrmProcesarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(665, 468);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProcesarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesar Pago";
            this.Load += new System.EventHandler(this.FrmProcesarPago_Load);
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
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NumCuenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox MonTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip Barra2;
        private System.Windows.Forms.ToolStripButton RegistrarPedido;
        private System.Windows.Forms.ToolStripButton ProcesarPago;
        private System.Windows.Forms.ToolStripButton EmitirComprobante;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStrip Barra;
        private System.Windows.Forms.ToolStripButton RegistrarVenta;
        private System.Windows.Forms.ToolStripButton AfiliarCliente;
        private System.Windows.Forms.ToolStripButton AdministrarMenus;
        private System.Windows.Forms.ToolStripButton AdministrarPersonal;
        private System.Windows.Forms.ToolStripButton Salir;
        private System.Windows.Forms.TextBox Pago_ID;
        public System.Windows.Forms.TextBox PreTotal;
    }
}