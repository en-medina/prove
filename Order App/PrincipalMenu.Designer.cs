namespace Order_App
{
    public partial class PrincipalMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalMenu));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ItemAdded = new System.Windows.Forms.Label();
            this.NombreEmpleado = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.IDEmpleado = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IDCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.button4 = new System.Windows.Forms.Button();
            this.OrderIDCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxArticulo = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.InsertItemQuantity = new System.Windows.Forms.TextBox();
            this.InsertItemPrice = new System.Windows.Forms.TextBox();
            this.InsertItemName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxEmpleado = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.InsertEmpPass2 = new System.Windows.Forms.TextBox();
            this.InsertEmpPass = new System.Windows.Forms.TextBox();
            this.InsertEmpZip = new System.Windows.Forms.TextBox();
            this.InsertEmpLstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InsertEmpName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.InsertCustomerZip = new System.Windows.Forms.TextBox();
            this.InsertCustomerLstName = new System.Windows.Forms.TextBox();
            this.InsertCustomerName = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.listViewData = new System.Windows.Forms.ListView();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxArticulo.SuspendLayout();
            this.groupBoxEmpleado.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 543);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ItemAdded);
            this.tabPage1.Controls.Add(this.NombreEmpleado);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.IDEmpleado);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.IDCustomer);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ItemQuantity);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.IDItem);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Menu de pedido";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // ItemAdded
            // 
            this.ItemAdded.AutoSize = true;
            this.ItemAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemAdded.Location = new System.Drawing.Point(56, 434);
            this.ItemAdded.Name = "ItemAdded";
            this.ItemAdded.Size = new System.Drawing.Size(115, 29);
            this.ItemAdded.TabIndex = 14;
            this.ItemAdded.Text = "Cantidad:";
            this.ItemAdded.Visible = false;
            // 
            // NombreEmpleado
            // 
            this.NombreEmpleado.AutoSize = true;
            this.NombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreEmpleado.Location = new System.Drawing.Point(172, 24);
            this.NombreEmpleado.Name = "NombreEmpleado";
            this.NombreEmpleado.Size = new System.Drawing.Size(157, 29);
            this.NombreEmpleado.TabIndex = 13;
            this.NombreEmpleado.Text = "ID empleado:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(64, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 29);
            this.label19.TabIndex = 12;
            this.label19.Text = "Nombre:";
            // 
            // IDEmpleado
            // 
            this.IDEmpleado.AutoSize = true;
            this.IDEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDEmpleado.Location = new System.Drawing.Point(172, 53);
            this.IDEmpleado.Name = "IDEmpleado";
            this.IDEmpleado.Size = new System.Drawing.Size(157, 29);
            this.IDEmpleado.TabIndex = 11;
            this.IDEmpleado.Text = "ID empleado:";
            this.IDEmpleado.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(124, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 29);
            this.label17.TabIndex = 10;
            this.label17.Text = "ID:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 108);
            this.button2.TabIndex = 9;
            this.button2.Text = "Añadir al carro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(402, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(282, 108);
            this.button3.TabIndex = 8;
            this.button3.Text = "Proceder a chequear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IDCustomer
            // 
            this.IDCustomer.Location = new System.Drawing.Point(177, 237);
            this.IDCustomer.Name = "IDCustomer";
            this.IDCustomer.Size = new System.Drawing.Size(250, 35);
            this.IDCustomer.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente ID:";
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.Location = new System.Drawing.Point(177, 175);
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.Size = new System.Drawing.Size(481, 35);
            this.ItemQuantity.TabIndex = 3;
            this.ItemQuantity.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // IDItem
            // 
            this.IDItem.Location = new System.Drawing.Point(177, 111);
            this.IDItem.Name = "IDItem";
            this.IDItem.Size = new System.Drawing.Size(481, 35);
            this.IDItem.TabIndex = 1;
            this.IDItem.TextChanged += new System.EventHandler(this.IDItem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listViewOrder);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.OrderIDCustomer);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ver Pedido";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewOrder
            // 
            this.listViewOrder.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listViewOrder.AutoArrange = false;
            this.listViewOrder.HoverSelection = true;
            this.listViewOrder.Location = new System.Drawing.Point(39, 91);
            this.listViewOrder.MultiSelect = false;
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(710, 387);
            this.listViewOrder.TabIndex = 3;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            this.listViewOrder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewOrder_MouseDoubleClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(420, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 43);
            this.button4.TabIndex = 2;
            this.button4.Text = "Chequear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // OrderIDCustomer
            // 
            this.OrderIDCustomer.Location = new System.Drawing.Point(164, 42);
            this.OrderIDCustomer.Name = "OrderIDCustomer";
            this.OrderIDCustomer.Size = new System.Drawing.Size(250, 35);
            this.OrderIDCustomer.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cliente ID:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.groupBoxArticulo);
            this.tabPage3.Controls.Add(this.groupBoxEmpleado);
            this.tabPage3.Controls.Add(this.groupBoxCliente);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(770, 501);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Insertar datos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Seleccionar Dato:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cliente",
            "Articulo",
            "Empleado"});
            this.comboBox1.Location = new System.Drawing.Point(315, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(310, 37);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBoxArticulo
            // 
            this.groupBoxArticulo.Controls.Add(this.button6);
            this.groupBoxArticulo.Controls.Add(this.InsertItemQuantity);
            this.groupBoxArticulo.Controls.Add(this.InsertItemPrice);
            this.groupBoxArticulo.Controls.Add(this.InsertItemName);
            this.groupBoxArticulo.Controls.Add(this.label13);
            this.groupBoxArticulo.Controls.Add(this.label12);
            this.groupBoxArticulo.Controls.Add(this.label11);
            this.groupBoxArticulo.Location = new System.Drawing.Point(111, 115);
            this.groupBoxArticulo.Name = "groupBoxArticulo";
            this.groupBoxArticulo.Size = new System.Drawing.Size(514, 378);
            this.groupBoxArticulo.TabIndex = 3;
            this.groupBoxArticulo.TabStop = false;
            this.groupBoxArticulo.Text = "Artículo";
            this.groupBoxArticulo.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(20, 304);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(260, 59);
            this.button6.TabIndex = 6;
            this.button6.Text = "Insertar Dato";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // InsertItemQuantity
            // 
            this.InsertItemQuantity.Location = new System.Drawing.Point(181, 156);
            this.InsertItemQuantity.Name = "InsertItemQuantity";
            this.InsertItemQuantity.Size = new System.Drawing.Size(304, 35);
            this.InsertItemQuantity.TabIndex = 5;
            // 
            // InsertItemPrice
            // 
            this.InsertItemPrice.Location = new System.Drawing.Point(181, 108);
            this.InsertItemPrice.Name = "InsertItemPrice";
            this.InsertItemPrice.Size = new System.Drawing.Size(304, 35);
            this.InsertItemPrice.TabIndex = 4;
            // 
            // InsertItemName
            // 
            this.InsertItemName.Location = new System.Drawing.Point(181, 60);
            this.InsertItemName.Name = "InsertItemName";
            this.InsertItemName.Size = new System.Drawing.Size(304, 35);
            this.InsertItemName.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(60, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 29);
            this.label13.TabIndex = 2;
            this.label13.Text = "Cantidad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(86, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 29);
            this.label12.TabIndex = 1;
            this.label12.Text = "Precio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(68, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nombre:";
            // 
            // groupBoxEmpleado
            // 
            this.groupBoxEmpleado.Controls.Add(this.button5);
            this.groupBoxEmpleado.Controls.Add(this.InsertEmpPass2);
            this.groupBoxEmpleado.Controls.Add(this.InsertEmpPass);
            this.groupBoxEmpleado.Controls.Add(this.InsertEmpZip);
            this.groupBoxEmpleado.Controls.Add(this.InsertEmpLstName);
            this.groupBoxEmpleado.Controls.Add(this.label10);
            this.groupBoxEmpleado.Controls.Add(this.label9);
            this.groupBoxEmpleado.Controls.Add(this.label8);
            this.groupBoxEmpleado.Controls.Add(this.label7);
            this.groupBoxEmpleado.Controls.Add(this.InsertEmpName);
            this.groupBoxEmpleado.Controls.Add(this.label6);
            this.groupBoxEmpleado.Location = new System.Drawing.Point(111, 115);
            this.groupBoxEmpleado.Name = "groupBoxEmpleado";
            this.groupBoxEmpleado.Size = new System.Drawing.Size(514, 378);
            this.groupBoxEmpleado.TabIndex = 2;
            this.groupBoxEmpleado.TabStop = false;
            this.groupBoxEmpleado.Text = "Empleado";
            this.groupBoxEmpleado.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 304);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(260, 59);
            this.button5.TabIndex = 10;
            this.button5.Text = "Insertar Dato";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // InsertEmpPass2
            // 
            this.InsertEmpPass2.Location = new System.Drawing.Point(181, 252);
            this.InsertEmpPass2.Name = "InsertEmpPass2";
            this.InsertEmpPass2.Size = new System.Drawing.Size(304, 35);
            this.InsertEmpPass2.TabIndex = 9;
            this.InsertEmpPass2.UseSystemPasswordChar = true;
            // 
            // InsertEmpPass
            // 
            this.InsertEmpPass.Location = new System.Drawing.Point(181, 204);
            this.InsertEmpPass.Name = "InsertEmpPass";
            this.InsertEmpPass.Size = new System.Drawing.Size(304, 35);
            this.InsertEmpPass.TabIndex = 8;
            this.InsertEmpPass.UseSystemPasswordChar = true;
            // 
            // InsertEmpZip
            // 
            this.InsertEmpZip.Location = new System.Drawing.Point(181, 156);
            this.InsertEmpZip.Name = "InsertEmpZip";
            this.InsertEmpZip.Size = new System.Drawing.Size(304, 35);
            this.InsertEmpZip.TabIndex = 7;
            // 
            // InsertEmpLstName
            // 
            this.InsertEmpLstName.Location = new System.Drawing.Point(181, 108);
            this.InsertEmpLstName.Name = "InsertEmpLstName";
            this.InsertEmpLstName.Size = new System.Drawing.Size(304, 35);
            this.InsertEmpLstName.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 29);
            this.label10.TabIndex = 5;
            this.label10.Text = "Repetir clave:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 29);
            this.label9.TabIndex = 4;
            this.label9.Text = "Clave:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "Código postal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Apellido:";
            // 
            // InsertEmpName
            // 
            this.InsertEmpName.Location = new System.Drawing.Point(181, 60);
            this.InsertEmpName.Name = "InsertEmpName";
            this.InsertEmpName.Size = new System.Drawing.Size(304, 35);
            this.InsertEmpName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre:";
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.InsertCustomerZip);
            this.groupBoxCliente.Controls.Add(this.InsertCustomerLstName);
            this.groupBoxCliente.Controls.Add(this.InsertCustomerName);
            this.groupBoxCliente.Controls.Add(this.button7);
            this.groupBoxCliente.Controls.Add(this.label16);
            this.groupBoxCliente.Controls.Add(this.label15);
            this.groupBoxCliente.Controls.Add(this.label14);
            this.groupBoxCliente.Location = new System.Drawing.Point(111, 115);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(514, 378);
            this.groupBoxCliente.TabIndex = 4;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            this.groupBoxCliente.Visible = false;
            // 
            // InsertCustomerZip
            // 
            this.InsertCustomerZip.Location = new System.Drawing.Point(181, 156);
            this.InsertCustomerZip.Name = "InsertCustomerZip";
            this.InsertCustomerZip.Size = new System.Drawing.Size(304, 35);
            this.InsertCustomerZip.TabIndex = 6;
            // 
            // InsertCustomerLstName
            // 
            this.InsertCustomerLstName.Location = new System.Drawing.Point(181, 108);
            this.InsertCustomerLstName.Name = "InsertCustomerLstName";
            this.InsertCustomerLstName.Size = new System.Drawing.Size(304, 35);
            this.InsertCustomerLstName.TabIndex = 5;
            // 
            // InsertCustomerName
            // 
            this.InsertCustomerName.Location = new System.Drawing.Point(181, 60);
            this.InsertCustomerName.Name = "InsertCustomerName";
            this.InsertCustomerName.Size = new System.Drawing.Size(304, 35);
            this.InsertCustomerName.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(20, 304);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(260, 59);
            this.button7.TabIndex = 3;
            this.button7.Text = "Insertar Dato";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 29);
            this.label16.TabIndex = 2;
            this.label16.Text = "Código postal:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(68, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 29);
            this.label15.TabIndex = 1;
            this.label15.Text = "Apellido:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(68, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 29);
            this.label14.TabIndex = 0;
            this.label14.Text = "Nombre:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBoxSearch);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.listViewData);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.comboBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(770, 501);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ver datos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(271, 99);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(314, 35);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(34, 102);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(231, 29);
            this.label20.TabIndex = 5;
            this.label20.Text = "Buscar Por Nombre:";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // listViewData
            // 
            this.listViewData.HoverSelection = true;
            this.listViewData.Location = new System.Drawing.Point(39, 150);
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(710, 328);
            this.listViewData.TabIndex = 4;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            this.listViewData.View = System.Windows.Forms.View.Details;
            this.listViewData.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(62, 54);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(203, 29);
            this.label18.TabIndex = 3;
            this.label18.Text = "Seleccionar Dato:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Cliente",
            "Articulo",
            "Empleado"});
            this.comboBox2.Location = new System.Drawing.Point(275, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(310, 37);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // PrincipalMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrincipalMenu";
            this.Text = "PrincipalMenu";
            this.Load += new System.EventHandler(this.PrincipalMenu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBoxArticulo.ResumeLayout(false);
            this.groupBoxArticulo.PerformLayout();
            this.groupBoxEmpleado.ResumeLayout(false);
            this.groupBoxEmpleado.PerformLayout();
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox ItemQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IDCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox OrderIDCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.TextBox InsertCustomerZip;
        private System.Windows.Forms.TextBox InsertCustomerLstName;
        private System.Windows.Forms.TextBox InsertCustomerName;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBoxArticulo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox InsertItemQuantity;
        private System.Windows.Forms.TextBox InsertItemPrice;
        private System.Windows.Forms.TextBox InsertItemName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBoxEmpleado;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox InsertEmpPass2;
        private System.Windows.Forms.TextBox InsertEmpPass;
        private System.Windows.Forms.TextBox InsertEmpZip;
        private System.Windows.Forms.TextBox InsertEmpLstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox InsertEmpName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label IDEmpleado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label NombreEmpleado;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label ItemAdded;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView listViewData;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}