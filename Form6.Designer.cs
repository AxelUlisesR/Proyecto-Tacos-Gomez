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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.Id_Menú = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefonoEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccionEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.cmdPagar = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdSurtir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(67, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 36);
            this.label16.TabIndex = 121;
            this.label16.Text = "Venta:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.dgvMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Menú,
            this.Concepto,
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.Importe,
            this.Plato});
            this.dgvMenu.Enabled = false;
            this.dgvMenu.EnableHeadersVisualStyles = false;
            this.dgvMenu.Location = new System.Drawing.Point(782, 28);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(1052, 680);
            this.dgvMenu.TabIndex = 124;
            // 
            // Id_Menú
            // 
            this.Id_Menú.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Id_Menú.DefaultCellStyle = dataGridViewCellStyle3;
            this.Id_Menú.HeaderText = "ID Menú";
            this.Id_Menú.MinimumWidth = 6;
            this.Id_Menú.Name = "Id_Menú";
            this.Id_Menú.ReadOnly = true;
            this.Id_Menú.Width = 133;
            // 
            // Concepto
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Concepto.DefaultCellStyle = dataGridViewCellStyle4;
            this.Concepto.HeaderText = "Producto";
            this.Concepto.MinimumWidth = 6;
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            this.Concepto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle5;
            this.Descripcion.HeaderText = "Categoria";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Precio.DefaultCellStyle = dataGridViewCellStyle6;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle7;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Importe
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Importe.DefaultCellStyle = dataGridViewCellStyle8;
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 6;
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // Plato
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Plato.DefaultCellStyle = dataGridViewCellStyle9;
            this.Plato.HeaderText = "Plato";
            this.Plato.MinimumWidth = 9;
            this.Plato.Name = "Plato";
            this.Plato.ReadOnly = true;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(180)))));
            this.txtNombreEmpleado.Enabled = false;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Segoe UI", 14.14286F);
            this.txtNombreEmpleado.Location = new System.Drawing.Point(146, 36);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(520, 39);
            this.txtNombreEmpleado.TabIndex = 81;
            // 
            // txtRol
            // 
            this.txtRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(180)))));
            this.txtRol.Enabled = false;
            this.txtRol.Font = new System.Drawing.Font("Segoe UI", 14.14286F);
            this.txtRol.Location = new System.Drawing.Point(146, 225);
            this.txtRol.Margin = new System.Windows.Forms.Padding(2);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(244, 39);
            this.txtRol.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(11, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 35);
            this.label4.TabIndex = 78;
            this.label4.Text = "Rol:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(180)))));
            this.txtTelefonoEmpleado.Enabled = false;
            this.txtTelefonoEmpleado.Font = new System.Drawing.Font("Segoe UI", 14.14286F);
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(146, 160);
            this.txtTelefonoEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefonoEmpleado.Mask = "(999)000-0000";
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(244, 39);
            this.txtTelefonoEmpleado.TabIndex = 77;
            // 
            // txtDireccionEmpleado
            // 
            this.txtDireccionEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(180)))));
            this.txtDireccionEmpleado.Enabled = false;
            this.txtDireccionEmpleado.Font = new System.Drawing.Font("Segoe UI", 14.14286F);
            this.txtDireccionEmpleado.Location = new System.Drawing.Point(146, 97);
            this.txtDireccionEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            this.txtDireccionEmpleado.Size = new System.Drawing.Size(522, 39);
            this.txtDireccionEmpleado.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(10, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 35);
            this.label5.TabIndex = 73;
            this.label5.Text = "Nombre:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(11, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 35);
            this.label6.TabIndex = 74;
            this.label6.Text = "Telefono:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(0, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 35);
            this.label7.TabIndex = 72;
            this.label7.Text = "Dirección: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(95)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtIVA);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtEstado);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cmdSalir);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txtFecha);
            this.panel1.Controls.Add(this.cmdPagar);
            this.panel1.Controls.Add(this.txtSubtotal);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.cmdConsultar);
            this.panel1.Controls.Add(this.cmdSurtir);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvMenu);
            this.panel1.Controls.Add(this.cmdCancelar);
            this.panel1.Location = new System.Drawing.Point(28, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1869, 925);
            this.panel1.TabIndex = 120;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(180)))));
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F);
            this.txtTotal.Location = new System.Drawing.Point(1449, 868);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(158, 34);
            this.txtTotal.TabIndex = 123;
            // 
            // txtIVA
            // 
            this.txtIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(180)))));
            this.txtIVA.Enabled = false;
            this.txtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F);
            this.txtIVA.Location = new System.Drawing.Point(1449, 818);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(158, 34);
            this.txtIVA.TabIndex = 121;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label19.Location = new System.Drawing.Point(1352, 869);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 33);
            this.label19.TabIndex = 122;
            this.label19.Text = "Total:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(405, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 33);
            this.label11.TabIndex = 128;
            this.label11.Text = "Estado:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label18.Location = new System.Drawing.Point(1357, 819);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 35);
            this.label18.TabIndex = 120;
            this.label18.Text = "IVA:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(180)))));
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI", 14.14286F);
            this.txtEstado.Location = new System.Drawing.Point(514, 308);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(155, 39);
            this.txtEstado.TabIndex = 129;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 35);
            this.label9.TabIndex = 99;
            this.label9.Text = "Fecha:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label13.Location = new System.Drawing.Point(1309, 768);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 35);
            this.label13.TabIndex = 96;
            this.label13.Text = "Subtotal:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.cmdSalir.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdSalir.Location = new System.Drawing.Point(1690, 807);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(144, 70);
            this.cmdSalir.TabIndex = 137;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label20.Location = new System.Drawing.Point(178, 55);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(375, 106);
            this.label20.TabIndex = 125;
            this.label20.Text = "Consulta";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(180)))));
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 14.14286F);
            this.txtFecha.Location = new System.Drawing.Point(165, 310);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(201, 39);
            this.txtFecha.TabIndex = 115;
            // 
            // cmdPagar
            // 
            this.cmdPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(85)))));
            this.cmdPagar.Enabled = false;
            this.cmdPagar.Font = new System.Drawing.Font("Segoe UI", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdPagar.Location = new System.Drawing.Point(955, 772);
            this.cmdPagar.Name = "cmdPagar";
            this.cmdPagar.Size = new System.Drawing.Size(145, 80);
            this.cmdPagar.TabIndex = 141;
            this.cmdPagar.Text = "Pagar Pedido";
            this.cmdPagar.UseVisualStyleBackColor = false;
            this.cmdPagar.Click += new System.EventHandler(this.cmdPagar_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(180)))));
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F);
            this.txtSubtotal.Location = new System.Drawing.Point(1449, 767);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(158, 34);
            this.txtSubtotal.TabIndex = 119;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(180)))));
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 14.14286F);
            this.txtId.Location = new System.Drawing.Point(165, 226);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(155, 39);
            this.txtId.TabIndex = 125;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Tacos_Gomez.Properties.Resources.Captura_de_pantalla_2025_10_26_222442;
            this.pictureBox1.Location = new System.Drawing.Point(29, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 124;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNombreEmpleado);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDireccionEmpleado);
            this.groupBox2.Controls.Add(this.txtRol);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTelefonoEmpleado);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox2.Location = new System.Drawing.Point(41, 612);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 290);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empleado";
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(145)))), ((int)(((byte)(50)))));
            this.cmdConsultar.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Location = new System.Drawing.Point(404, 217);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(149, 56);
            this.cmdConsultar.TabIndex = 138;
            this.cmdConsultar.Text = "Consultar ";
            this.cmdConsultar.UseVisualStyleBackColor = false;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdSurtir
            // 
            this.cmdSurtir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(170)))));
            this.cmdSurtir.Enabled = false;
            this.cmdSurtir.Font = new System.Drawing.Font("Segoe UI", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdSurtir.Location = new System.Drawing.Point(782, 772);
            this.cmdSurtir.Name = "cmdSurtir";
            this.cmdSurtir.Size = new System.Drawing.Size(145, 80);
            this.cmdSurtir.TabIndex = 140;
            this.cmdSurtir.Text = "Surtir Pedido";
            this.cmdSurtir.UseVisualStyleBackColor = false;
            this.cmdSurtir.Click += new System.EventHandler(this.cmdSurtir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Telefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(41, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 225);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(180)))));
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(144, 42);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(520, 38);
            this.txtNombreCliente.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(0, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 35);
            this.label1.TabIndex = 72;
            this.label1.Text = "Dirección: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Telefono
            // 
            this.Telefono.BackColor = System.Drawing.Color.Transparent;
            this.Telefono.Font = new System.Drawing.Font("Segoe UI", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Telefono.Location = new System.Drawing.Point(5, 162);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(130, 35);
            this.Telefono.TabIndex = 74;
            this.Telefono.Text = "Telefono:";
            this.Telefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 35);
            this.label2.TabIndex = 73;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(180)))));
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 14.14286F);
            this.txtCliente.Location = new System.Drawing.Point(141, 160);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Mask = "(999)000-0000";
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(244, 39);
            this.txtCliente.TabIndex = 77;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(215)))), ((int)(((byte)(180)))));
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 14.14286F);
            this.txtDireccion.Location = new System.Drawing.Point(141, 101);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(522, 39);
            this.txtDireccion.TabIndex = 76;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(175)))), ((int)(((byte)(160)))));
            this.cmdCancelar.Enabled = false;
            this.cmdCancelar.Font = new System.Drawing.Font("Segoe UI", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdCancelar.Location = new System.Drawing.Point(1129, 772);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(145, 80);
            this.cmdCancelar.TabIndex = 139;
            this.cmdCancelar.Text = "Cancelar Pedido";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1924, 980);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConsulta";
            this.Text = "Consulta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTelefonoEmpleado;
        private System.Windows.Forms.TextBox txtDireccionEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Menú;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plato;
    }
}