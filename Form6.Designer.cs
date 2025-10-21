namespace Proyecto_Tacos_Gomez
{
    partial class frmConsulta
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
            this.label16 = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.Id_Menú = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefonoEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccionEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdPagar = new System.Windows.Forms.Button();
            this.cmdSurtir = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.DarkGray;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(33, 7);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 45);
            this.label16.TabIndex = 121;
            this.label16.Text = "Venta:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.dgvMenu.Location = new System.Drawing.Point(146, 681);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(1295, 265);
            this.dgvMenu.TabIndex = 124;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.txtNombreEmpleado);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtRol);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtTelefonoEmpleado);
            this.panel2.Controls.Add(this.txtDireccionEmpleado);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(146, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 286);
            this.panel2.TabIndex = 122;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.txtNombreCliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Telefono);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(142, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 241);
            this.panel1.TabIndex = 120;
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
            // cmdPagar
            // 
            this.cmdPagar.Enabled = false;
            this.cmdPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPagar.Location = new System.Drawing.Point(528, 1008);
            this.cmdPagar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdPagar.Name = "cmdPagar";
            this.cmdPagar.Size = new System.Drawing.Size(154, 78);
            this.cmdPagar.TabIndex = 141;
            this.cmdPagar.Text = "Pagar Pedido";
            this.cmdPagar.UseVisualStyleBackColor = true;
            this.cmdPagar.Click += new System.EventHandler(this.cmdPagar_Click);
            // 
            // cmdSurtir
            // 
            this.cmdSurtir.Enabled = false;
            this.cmdSurtir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSurtir.Location = new System.Drawing.Point(342, 1008);
            this.cmdSurtir.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSurtir.Name = "cmdSurtir";
            this.cmdSurtir.Size = new System.Drawing.Size(154, 78);
            this.cmdSurtir.TabIndex = 140;
            this.cmdSurtir.Text = "Surtir Pedido";
            this.cmdSurtir.UseVisualStyleBackColor = true;
            this.cmdSurtir.Click += new System.EventHandler(this.cmdSurtir_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Enabled = false;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(158, 1008);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(154, 78);
            this.cmdCancelar.TabIndex = 139;
            this.cmdCancelar.Text = "Cancelar Pedido";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Location = new System.Drawing.Point(708, 1008);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(158, 78);
            this.cmdConsultar.TabIndex = 138;
            this.cmdConsultar.Text = "Consultar ";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.Firebrick;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(910, 1008);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(154, 78);
            this.cmdSalir.TabIndex = 137;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Location = new System.Drawing.Point(142, 992);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(944, 124);
            this.panel5.TabIndex = 142;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(1263, 1086);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(216, 29);
            this.txtTotal.TabIndex = 123;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.DarkGray;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1136, 1079);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 36);
            this.label19.TabIndex = 122;
            this.label19.Text = "Total:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Location = new System.Drawing.Point(1263, 1024);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(4);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(216, 29);
            this.txtIVA.TabIndex = 121;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.DarkGray;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1131, 1016);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 52);
            this.label18.TabIndex = 120;
            this.label18.Text = "IVA:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(1263, 960);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(216, 29);
            this.txtSubtotal.TabIndex = 119;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(1114, 953);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(443, 178);
            this.panel4.TabIndex = 124;
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
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F);
            this.txtNombreCliente.Location = new System.Drawing.Point(185, 45);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(714, 34);
            this.txtNombreCliente.TabIndex = 80;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Enabled = false;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F);
            this.txtNombreEmpleado.Location = new System.Drawing.Point(181, 58);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(714, 34);
            this.txtNombreEmpleado.TabIndex = 81;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.txtEstado);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtFecha);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Location = new System.Drawing.Point(1272, -5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 169);
            this.panel3.TabIndex = 143;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(154, 118);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(309, 29);
            this.txtEstado.TabIndex = 129;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 117);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 52);
            this.label11.TabIndex = 128;
            this.label11.Text = "Estado:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DarkGray;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 52);
            this.label9.TabIndex = 99;
            this.label9.Text = "Fecha:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(154, 65);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(309, 29);
            this.txtFecha.TabIndex = 115;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(154, 15);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(309, 31);
            this.txtId.TabIndex = 125;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1807, 1471);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.cmdPagar);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cmdSurtir);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmConsulta";
            this.Text = "Consulta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Menú;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plato;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTelefonoEmpleado;
        private System.Windows.Forms.TextBox txtDireccionEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCliente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdPagar;
        private System.Windows.Forms.Button cmdSurtir;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtId;
    }
}