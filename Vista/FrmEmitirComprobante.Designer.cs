namespace Vista
{
    partial class FrmEmitirComprobante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmitirComprobante));
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Registrar Pedido");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Registrar Pago");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Emitir Comprobante");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Navegación", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            this.Barra = new System.Windows.Forms.ToolStrip();
            this.RegistrarVenta = new System.Windows.Forms.ToolStripButton();
            this.AfiliarCliente = new System.Windows.Forms.ToolStripButton();
            this.AdministrarMenus = new System.Windows.Forms.ToolStripButton();
            this.AdministrarPersonal = new System.Windows.Forms.ToolStripButton();
            this.Salir = new System.Windows.Forms.ToolStripButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.com_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.coNumero = new System.Windows.Forms.TextBox();
            this.coUnitario = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.coComprobante = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.coFecha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.coCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.coTipo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.coMonto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.coPago = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.coPlatillo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.coDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.coCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEmitir = new System.Windows.Forms.Button();
            this.coNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Barra2 = new System.Windows.Forms.ToolStrip();
            this.RegistrarPedido = new System.Windows.Forms.ToolStripButton();
            this.ProcesarPago = new System.Windows.Forms.ToolStripButton();
            this.EmitirComprobante = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Barra.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Barra2.SuspendLayout();
            this.SuspendLayout();
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
            this.Barra.Size = new System.Drawing.Size(767, 95);
            this.Barra.TabIndex = 2;
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
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.treeView1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ItemHeight = 30;
            this.treeView1.Location = new System.Drawing.Point(0, 98);
            this.treeView1.Name = "treeView1";
            treeNode5.Name = "Nodo2";
            treeNode5.Text = "Registrar Pedido";
            treeNode6.Name = "Nodo3";
            treeNode6.Text = "Registrar Pago";
            treeNode7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            treeNode7.Name = "Nodo5";
            treeNode7.Text = "Emitir Comprobante";
            treeNode8.Name = "Nodo 1";
            treeNode8.Text = "Navegación";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(159, 464);
            this.treeView1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.com_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.coNumero);
            this.groupBox1.Controls.Add(this.coUnitario);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.coComprobante);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.coFecha);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.coCantidad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.coTipo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.coMonto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.coPago);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.coPlatillo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.coDNI);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.coCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEmitir);
            this.groupBox1.Controls.Add(this.coNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Barra2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(159, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 404);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ASN Restaurant";
            // 
            // com_ID
            // 
            this.com_ID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_ID.Location = new System.Drawing.Point(471, 63);
            this.com_ID.Name = "com_ID";
            this.com_ID.Size = new System.Drawing.Size(115, 23);
            this.com_ID.TabIndex = 50;
            this.com_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 49;
            this.label1.Text = "N° de Comprobante";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 324);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 16);
            this.label12.TabIndex = 48;
            this.label12.Text = "Precio Unitario:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(308, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 16);
            this.label13.TabIndex = 47;
            this.label13.Text = "Número PYAC:";
            // 
            // coNumero
            // 
            this.coNumero.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coNumero.Location = new System.Drawing.Point(455, 188);
            this.coNumero.Name = "coNumero";
            this.coNumero.Size = new System.Drawing.Size(131, 22);
            this.coNumero.TabIndex = 46;
            this.coNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // coUnitario
            // 
            this.coUnitario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coUnitario.Location = new System.Drawing.Point(159, 321);
            this.coUnitario.Name = "coUnitario";
            this.coUnitario.Size = new System.Drawing.Size(121, 22);
            this.coUnitario.TabIndex = 45;
            this.coUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(196, 357);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(73, 32);
            this.btnCargar.TabIndex = 44;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // coComprobante
            // 
            this.coComprobante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coComprobante.FormattingEnabled = true;
            this.coComprobante.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.coComprobante.Location = new System.Drawing.Point(455, 319);
            this.coComprobante.Name = "coComprobante";
            this.coComprobante.Size = new System.Drawing.Size(131, 25);
            this.coComprobante.TabIndex = 43;
            this.coComprobante.SelectedIndexChanged += new System.EventHandler(this.coComprobante_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(308, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "Tipo Comprobante:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // coFecha
            // 
            this.coFecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coFecha.Location = new System.Drawing.Point(455, 275);
            this.coFecha.Name = "coFecha";
            this.coFecha.Size = new System.Drawing.Size(131, 22);
            this.coFecha.TabIndex = 40;
            this.coFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(308, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "Fecha:";
            // 
            // coCantidad
            // 
            this.coCantidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coCantidad.Location = new System.Drawing.Point(159, 275);
            this.coCantidad.Name = "coCantidad";
            this.coCantidad.Size = new System.Drawing.Size(121, 22);
            this.coCantidad.TabIndex = 38;
            this.coCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coCantidad.TextChanged += new System.EventHandler(this.coCantidad_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "N° de Pedido:";
            // 
            // coTipo
            // 
            this.coTipo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coTipo.Location = new System.Drawing.Point(455, 147);
            this.coTipo.Name = "coTipo";
            this.coTipo.Size = new System.Drawing.Size(131, 22);
            this.coTipo.TabIndex = 35;
            this.coTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(308, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "N° de pago:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // coMonto
            // 
            this.coMonto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coMonto.Location = new System.Drawing.Point(455, 232);
            this.coMonto.Name = "coMonto";
            this.coMonto.Size = new System.Drawing.Size(131, 22);
            this.coMonto.TabIndex = 33;
            this.coMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(308, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tipo de Pago:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // coPago
            // 
            this.coPago.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coPago.Location = new System.Drawing.Point(455, 107);
            this.coPago.Name = "coPago";
            this.coPago.Size = new System.Drawing.Size(131, 22);
            this.coPago.TabIndex = 31;
            this.coPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(308, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Monto Total:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // coPlatillo
            // 
            this.coPlatillo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coPlatillo.Location = new System.Drawing.Point(159, 232);
            this.coPlatillo.Name = "coPlatillo";
            this.coPlatillo.Size = new System.Drawing.Size(121, 22);
            this.coPlatillo.TabIndex = 29;
            this.coPlatillo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Cantidad:";
            // 
            // coDNI
            // 
            this.coDNI.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coDNI.Location = new System.Drawing.Point(159, 188);
            this.coDNI.Name = "coDNI";
            this.coDNI.Size = new System.Drawing.Size(121, 22);
            this.coDNI.TabIndex = 27;
            this.coDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Platillo:";
            // 
            // coCliente
            // 
            this.coCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coCliente.Location = new System.Drawing.Point(159, 147);
            this.coCliente.Name = "coCliente";
            this.coCliente.Size = new System.Drawing.Size(121, 22);
            this.coCliente.TabIndex = 25;
            this.coCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "N° de DNI:";
            // 
            // btnEmitir
            // 
            this.btnEmitir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitir.Location = new System.Drawing.Point(331, 357);
            this.btnEmitir.Name = "btnEmitir";
            this.btnEmitir.Size = new System.Drawing.Size(73, 32);
            this.btnEmitir.TabIndex = 22;
            this.btnEmitir.Text = "Emitir";
            this.btnEmitir.UseVisualStyleBackColor = true;
            this.btnEmitir.Click += new System.EventHandler(this.button1_Click);
            // 
            // coNum
            // 
            this.coNum.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coNum.Location = new System.Drawing.Point(159, 107);
            this.coNum.Name = "coNum";
            this.coNum.Size = new System.Drawing.Size(121, 22);
            this.coNum.TabIndex = 6;
            this.coNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coNum.TextChanged += new System.EventHandler(this.coNum_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre del Cliente:";
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
            this.Barra2.Size = new System.Drawing.Size(602, 25);
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
            this.EmitirComprobante.BackColor = System.Drawing.Color.SandyBrown;
            this.EmitirComprobante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EmitirComprobante.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmitirComprobante.Image = ((System.Drawing.Image)(resources.GetObject("EmitirComprobante.Image")));
            this.EmitirComprobante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EmitirComprobante.Name = "EmitirComprobante";
            this.EmitirComprobante.Size = new System.Drawing.Size(126, 22);
            this.EmitirComprobante.Text = "Emitir Comprobante";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(282, 520);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 32);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(547, 520);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(77, 32);
            this.btnAceptar.TabIndex = 39;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(410, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 32);
            this.button2.TabIndex = 40;
            this.button2.Text = "Retroceder";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmEmitirComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(767, 564);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.Barra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEmitirComprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emitir Comprobante";
            this.Load += new System.EventHandler(this.FrmEmitirComprobante_Load);
            this.Barra.ResumeLayout(false);
            this.Barra.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Barra2.ResumeLayout(false);
            this.Barra2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Barra;
        private System.Windows.Forms.ToolStripButton RegistrarVenta;
        private System.Windows.Forms.ToolStripButton AfiliarCliente;
        private System.Windows.Forms.ToolStripButton AdministrarMenus;
        private System.Windows.Forms.ToolStripButton AdministrarPersonal;
        private System.Windows.Forms.ToolStripButton Salir;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEmitir;
        private System.Windows.Forms.TextBox coNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip Barra2;
        private System.Windows.Forms.ToolStripButton RegistrarPedido;
        private System.Windows.Forms.ToolStripButton ProcesarPago;
        private System.Windows.Forms.ToolStripButton EmitirComprobante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox coTipo;
        private System.Windows.Forms.TextBox coMonto;
        private System.Windows.Forms.TextBox coPago;
        private System.Windows.Forms.TextBox coPlatillo;
        private System.Windows.Forms.TextBox coDNI;
        private System.Windows.Forms.TextBox coCliente;
        private System.Windows.Forms.TextBox coCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox coFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox coComprobante;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox coNumero;
        private System.Windows.Forms.TextBox coUnitario;
        private System.Windows.Forms.TextBox com_ID;
        private System.Windows.Forms.Label label1;
    }
}