namespace Proyecto_Tacos_Gomez
{
    partial class Ventas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.txtCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefonoEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccionEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSeleccionarPlato = new System.Windows.Forms.Button();
            this.btnNuevoPlato = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPlato = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.Id_Menú = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbCliente);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Telefono);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(162, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 241);
            this.panel1.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 42);
            this.label3.TabIndex = 79;
            this.label3.Text = "Cliente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbCliente
            // 
            this.cbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F);
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(185, 45);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(714, 37);
            this.cbCliente.TabIndex = 78;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F);
            this.txtCliente.Location = new System.Drawing.Point(185, 161);
            this.txtCliente.Mask = "(999)000-0000";
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(334, 34);
            this.txtCliente.TabIndex = 77;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F);
            this.txtDireccion.Location = new System.Drawing.Point(185, 106);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(714, 34);
            this.txtDireccion.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 52);
            this.label2.TabIndex = 73;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Telefono
            // 
            this.Telefono.BackColor = System.Drawing.Color.DarkGray;
            this.Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.Location = new System.Drawing.Point(-5, 152);
            this.Telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(179, 52);
            this.Telefono.TabIndex = 74;
            this.Telefono.Text = "Telefono:";
            this.Telefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 52);
            this.label1.TabIndex = 72;
            this.label1.Text = "Dirección: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.cbEmpleado);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtRol);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtTelefonoEmpleado);
            this.panel2.Controls.Add(this.txtDireccionEmpleado);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(166, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 286);
            this.panel2.TabIndex = 84;
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F);
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(181, 58);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(714, 37);
            this.cbEmpleado.TabIndex = 81;
            this.cbEmpleado.SelectedIndexChanged += new System.EventHandler(this.cbEmpleado_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkGray;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(407, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 42);
            this.label8.TabIndex = 80;
            this.label8.Text = "Empleado";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRol
            // 
            this.txtRol.Enabled = false;
            this.txtRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F);
            this.txtRol.Location = new System.Drawing.Point(181, 231);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(334, 34);
            this.txtRol.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-9, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 52);
            this.label4.TabIndex = 78;
            this.label4.Text = "Rol:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.Enabled = false;
            this.txtTelefonoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F);
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(181, 179);
            this.txtTelefonoEmpleado.Mask = "(999)000-0000";
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(334, 34);
            this.txtTelefonoEmpleado.TabIndex = 77;
            // 
            // txtDireccionEmpleado
            // 
            this.txtDireccionEmpleado.Enabled = false;
            this.txtDireccionEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F);
            this.txtDireccionEmpleado.Location = new System.Drawing.Point(181, 118);
            this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            this.txtDireccionEmpleado.Size = new System.Drawing.Size(714, 34);
            this.txtDireccionEmpleado.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 52);
            this.label5.TabIndex = 73;
            this.label5.Text = "Nombre:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-9, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 52);
            this.label6.TabIndex = 74;
            this.label6.Text = "Telefono:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkGray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-5, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 52);
            this.label7.TabIndex = 72;
            this.label7.Text = "Dirección: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.btnSeleccionarPlato);
            this.panel3.Controls.Add(this.btnNuevoPlato);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.txtPlato);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtIdProducto);
            this.panel3.Controls.Add(this.txtCantidad);
            this.panel3.Controls.Add(this.txtPrecio);
            this.panel3.Controls.Add(this.cmdAceptar);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtCategoria);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.cboProducto);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(166, 677);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1120, 267);
            this.panel3.TabIndex = 105;
            // 
            // btnSeleccionarPlato
            // 
            this.btnSeleccionarPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarPlato.Location = new System.Drawing.Point(389, 203);
            this.btnSeleccionarPlato.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionarPlato.Name = "btnSeleccionarPlato";
            this.btnSeleccionarPlato.Size = new System.Drawing.Size(199, 41);
            this.btnSeleccionarPlato.TabIndex = 99;
            this.btnSeleccionarPlato.Text = "Seleccionar plato";
            this.btnSeleccionarPlato.UseVisualStyleBackColor = true;
            this.btnSeleccionarPlato.Click += new System.EventHandler(this.btnSeleccionarPlato_Click);
            // 
            // btnNuevoPlato
            // 
            this.btnNuevoPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPlato.Location = new System.Drawing.Point(614, 203);
            this.btnNuevoPlato.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoPlato.Name = "btnNuevoPlato";
            this.btnNuevoPlato.Size = new System.Drawing.Size(199, 41);
            this.btnNuevoPlato.TabIndex = 98;
            this.btnNuevoPlato.Text = "Nuevo plato";
            this.btnNuevoPlato.UseVisualStyleBackColor = true;
            this.btnNuevoPlato.Click += new System.EventHandler(this.btnNuevoPlato_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.DarkGray;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(384, 146);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 33);
            this.label17.TabIndex = 97;
            this.label17.Text = "Plato:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPlato
            // 
            this.txtPlato.Location = new System.Drawing.Point(509, 147);
            this.txtPlato.Name = "txtPlato";
            this.txtPlato.Size = new System.Drawing.Size(210, 29);
            this.txtPlato.TabIndex = 96;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.DarkGray;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(727, 42);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 33);
            this.label12.TabIndex = 95;
            this.label12.Text = "ID:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Location = new System.Drawing.Point(852, 44);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(177, 29);
            this.txtIdProducto.TabIndex = 94;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(181, 200);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(177, 29);
            this.txtCantidad.TabIndex = 93;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(181, 147);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(177, 29);
            this.txtPrecio.TabIndex = 92;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAceptar.Location = new System.Drawing.Point(874, 187);
            this.cmdAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(87, 57);
            this.cmdAceptar.TabIndex = 91;
            this.cmdAceptar.Text = "Ok";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.DarkGray;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(395, -3);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 42);
            this.label10.TabIndex = 82;
            this.label10.Text = "Producto";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Location = new System.Drawing.Point(181, 96);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(538, 29);
            this.txtCategoria.TabIndex = 88;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DarkGray;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 95);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 52);
            this.label9.TabIndex = 87;
            this.label9.Text = "Categoria:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(50, 147);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 52);
            this.label11.TabIndex = 86;
            this.label11.Text = "Precio:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.DarkGray;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 43);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 52);
            this.label14.TabIndex = 85;
            this.label14.Text = "Producto:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(181, 43);
            this.cboProducto.Margin = new System.Windows.Forms.Padding(4);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(538, 32);
            this.cboProducto.TabIndex = 79;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.DarkGray;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(-17, 199);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(175, 45);
            this.label15.TabIndex = 83;
            this.label15.Text = "Cantidad:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Menú,
            this.Concepto,
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.Importe,
            this.Plato});
            this.dgvMenu.Location = new System.Drawing.Point(166, 975);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(1295, 265);
            this.dgvMenu.TabIndex = 106;
            // 
            // Id_Menú
            // 
            this.Id_Menú.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id_Menú.HeaderText = "Id_Menú";
            this.Id_Menú.MinimumWidth = 6;
            this.Id_Menú.Name = "Id_Menú";
            this.Id_Menú.ReadOnly = true;
            this.Id_Menú.Width = 130;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Producto";
            this.Concepto.MinimumWidth = 6;
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            this.Concepto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Categoria";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 6;
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // Plato
            // 
            this.Plato.HeaderText = "Plato";
            this.Plato.MinimumWidth = 9;
            this.Plato.Name = "Plato";
            this.Plato.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(804, 1318);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 57);
            this.button3.TabIndex = 111;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(591, 1318);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 57);
            this.button2.TabIndex = 110;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Enabled = false;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(389, 1318);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(154, 57);
            this.btnGrabar.TabIndex = 109;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(184, 1318);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(154, 57);
            this.btnNuevo.TabIndex = 108;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(166, 1304);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(813, 93);
            this.flowLayoutPanel1.TabIndex = 112;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(1167, 1398);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(216, 29);
            this.txtTotal.TabIndex = 117;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.DarkGray;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1040, 1391);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 36);
            this.label19.TabIndex = 116;
            this.label19.Text = "Total:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Location = new System.Drawing.Point(1167, 1336);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(4);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(216, 29);
            this.txtIVA.TabIndex = 115;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.DarkGray;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1035, 1328);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 52);
            this.label18.TabIndex = 114;
            this.label18.Text = "IVA:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(1167, 1272);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(216, 29);
            this.txtSubtotal.TabIndex = 113;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(1018, 1265);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(443, 178);
            this.panel5.TabIndex = 118;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.DarkGray;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 6);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 52);
            this.label13.TabIndex = 96;
            this.label13.Text = "Subtotal:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(1068, 17);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 31);
            this.txtId.TabIndex = 119;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.DarkGray;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(964, 9);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 45);
            this.label16.TabIndex = 80;
            this.label16.Text = "Venta:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1794, 1564);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtCliente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTelefonoEmpleado;
        private System.Windows.Forms.TextBox txtDireccionEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPlato;
        private System.Windows.Forms.Button btnNuevoPlato;
        private System.Windows.Forms.Button btnSeleccionarPlato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Menú;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plato;
    }
}