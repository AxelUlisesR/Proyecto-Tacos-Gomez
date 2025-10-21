using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Proyecto_Tacos_Gomez
{
    public partial class Ventas : Form
    {
        NpgsqlConnection conexion = new NpgsqlConnection("Host=localhost;Port=5432;Database=Taqueria;Username=postgres;Password=Ramamos06;");
        NpgsqlCommand comando;
        NpgsqlDataReader lector;

        double subtotal = 0;
        double iva = 0;
        double total = 0;
        int platoActual = 1;
        int tacosEnPlato = 0;
        const int MAX_TACOS_POR_PLATO = 8;

        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                comando = new NpgsqlCommand();
                comando.Connection = conexion;

                comando.CommandText = "SELECT nombre FROM Clientes ORDER BY nombre";
                lector = comando.ExecuteReader();
                while (lector.Read())
                    cbCliente.Items.Add(lector.GetString(0));
                lector.Close();

                comando.CommandText = "SELECT nombre FROM Empleados ORDER BY nombre";
                lector = comando.ExecuteReader();
                while (lector.Read())
                    cbEmpleado.Items.Add(lector.GetString(0));
                lector.Close();

                comando.CommandText = "SELECT nombre FROM Productos ORDER BY nombre";
                lector = comando.ExecuteReader();
                while (lector.Read())
                    cboProducto.Items.Add(lector.GetString(0));
                lector.Close();
                btnGrabar.Enabled = false;
                btnNuevo.Enabled = true;
                cbCliente.Enabled = false;
                cboProducto.Enabled = false;
                cbEmpleado.Enabled = false;
                txtCantidad.Enabled = false;
                cmdAceptar.Enabled = false;
                btnNuevoPlato.Enabled = false;
                btnSeleccionarPlato.Enabled = false;
                txtPlato.Enabled = false;
                txtPlato.Text = platoActual.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void cbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comando.CommandText = "SELECT direccion, telefono, rol FROM Empleados WHERE nombre = @nombre";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre", cbEmpleado.Text);
                lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    txtDireccionEmpleado.Text = lector["direccion"].ToString();
                    txtTelefonoEmpleado.Text = lector["telefono"].ToString();
                    txtRol.Text = lector["rol"].ToString();
                }
                lector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar empleado: " + ex.Message);
            }
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comando.CommandText = "SELECT direccion, telefono FROM Clientes WHERE nombre = @nombre";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre", cbCliente.Text);
                lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    txtDireccion.Text = lector["direccion"].ToString();
                    txtCliente.Text = lector["telefono"].ToString();
                }
                lector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar cliente: " + ex.Message);
            }
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comando.CommandText = "SELECT idProducto, precio, categoria FROM Productos WHERE nombre = @nombre";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre", cboProducto.Text);
                lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    txtIdProducto.Text = lector["idProducto"].ToString();
                    txtPrecio.Text = lector["precio"].ToString();
                    txtCategoria.Text = lector["categoria"].ToString();
                }
                lector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar producto: " + ex.Message);
            }
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboProducto.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                !int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Asegúrate de seleccionar un producto e indicar una cantidad válida.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                double precio = Convert.ToDouble(txtPrecio.Text);
                int cantidadRestante = cantidad;

                while (cantidadRestante > 0)
                {
                    int espacioDisponible = MAX_TACOS_POR_PLATO - tacosEnPlato;
                    int cantidadEnEstePlato = Math.Min(cantidadRestante, espacioDisponible);

                    if (cantidadEnEstePlato <= 0)
                        break;

                    double importe = precio * cantidadEnEstePlato;

                    dgvMenu.Rows.Add(
                        txtIdProducto.Text,
                        cboProducto.Text,
                        txtCategoria.Text,
                        precio.ToString("0.00"),
                        cantidadEnEstePlato.ToString(),
                        importe.ToString("0.00"),
                        platoActual
                    );

                    tacosEnPlato += cantidadEnEstePlato;
                    subtotal += importe;
                    cantidadRestante -= cantidadEnEstePlato;
                    
                    if ( tacosEnPlato >= MAX_TACOS_POR_PLATO && cantidadRestante > 0)
                    {
                        platoActual++;
                        tacosEnPlato = 0;
                    }
                }

                iva = subtotal * 0.16;
                total = subtotal + iva;

                txtSubtotal.Text = subtotal.ToString("0.00");
                txtIVA.Text = iva.ToString("0.00");
                txtTotal.Text = total.ToString("0.00");

                txtCantidad.Text = "";
                txtPlato.Text = platoActual.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }




        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbCliente.Text == "" || cbEmpleado.Text == "" || dgvMenu.Rows.Count == 0)
            {
                MessageBox.Show("Completa los datos del cliente, empleado y al menos un producto.");
                return;
            }

            try
            {
                int idCliente = GetId("Clientes", "idCliente", cbCliente.Text);
                int idEmpleado = GetId("Empleados", "idEmpleado", cbEmpleado.Text);

                comando.CommandText = "INSERT INTO Ordenes (idCliente, idEmpleado, fecha, total, estado) VALUES (@idCliente, @idEmpleado, @fecha, @total, @estado) RETURNING idOrden";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idCliente", idCliente);
                comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                comando.Parameters.AddWithValue("@fecha", DateTime.Now);
                comando.Parameters.AddWithValue("@total", total);
                comando.Parameters.AddWithValue("@estado", "R");

                int idOrden = Convert.ToInt32(comando.ExecuteScalar());

                foreach (DataGridViewRow fila in dgvMenu.Rows)
                {
                    if (fila.IsNewRow) continue;

                    int idProducto = Convert.ToInt32(fila.Cells[0].Value);
                    int cantidad = Convert.ToInt32(fila.Cells[4].Value);
                    double subtotalDetalle = Convert.ToDouble(fila.Cells[5].Value);
                    int plato = Convert.ToInt32(fila.Cells[6].Value);

                    comando.CommandText = "INSERT INTO DetOrdenes (idOrden, idProducto, cantidad, subtotal, plato) VALUES (@idOrden, @idProducto, @cantidad, @subtotal, @plato)";
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@idOrden", idOrden);
                    comando.Parameters.AddWithValue("@idProducto", idProducto);
                    comando.Parameters.AddWithValue("@cantidad", cantidad);
                    comando.Parameters.AddWithValue("@subtotal", subtotalDetalle);
                    comando.Parameters.AddWithValue("@plato", plato);
                    comando.ExecuteNonQuery();
                }
                btnGrabar.Enabled = false;
                btnNuevo.Enabled = true;
                cbCliente.Enabled = false;
                cboProducto.Enabled = false;
                cbEmpleado.Enabled = false;
                txtCantidad.Enabled = false;
                cmdAceptar.Enabled = false;
                btnNuevoPlato.Enabled = false;
                btnSeleccionarPlato.Enabled = false;
                MessageBox.Show("Venta registrada correctamente.");
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la venta: " + ex.Message);
            }
        }

        private int GetId(string tabla, string campo, string nombre)
        {
            comando.CommandText = $"SELECT {campo} FROM {tabla} WHERE nombre = @nombre";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@nombre", nombre);
            object id = comando.ExecuteScalar();
            return Convert.ToInt32(id);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                cbCliente.Enabled = true;
                cboProducto.Enabled = true;
                cbEmpleado.Enabled = true;
                txtCantidad.Enabled = true;
                cmdAceptar.Enabled = true;
                btnNuevo.Enabled = false;
                btnGrabar.Enabled = true;
                btnNuevoPlato.Enabled = true;
                btnSeleccionarPlato.Enabled = true;

                LimpiarFormulario();

                platoActual = 1;
                tacosEnPlato = 0;
                txtPlato.Text = platoActual.ToString();

                comando.CommandText = "SELECT COUNT(*) FROM Ordenes";
                int n = Convert.ToInt32(comando.ExecuteScalar()) + 1;
                txtId.Text = n.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar nuevo pedido: " + ex.Message);
            }
        }

        private void LimpiarFormulario()
        {
            cbCliente.Text = "";
            cboProducto.Text = "";
            cbEmpleado.Text = "";
            txtDireccion.Text = "";
            txtCliente.Text = "";
            txtDireccionEmpleado.Text = "";
            txtTelefonoEmpleado.Text = "";
            txtRol.Text = "";
            txtIdProducto.Text = "";
            txtPrecio.Text = "";
            txtCategoria.Text = "";
            txtCantidad.Text = "";
            txtSubtotal.Text = "0.00";
            txtIVA.Text = "0.00";
            txtTotal.Text = "0.00";
            subtotal = 0;
            total = 0;
            iva = 0;
            dgvMenu.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Close();
                this.Close();
                Menu frm = new Menu();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la ventana: " + ex.Message);
            }
        }

        private void btnNuevoPlato_Click(object sender, EventArgs e)
        {
            platoActual++;
            tacosEnPlato = 0;
            txtPlato.Text = platoActual.ToString();
            MessageBox.Show($"Nuevo plato iniciado. Ahora estás en el plato {platoActual}.",
                            "Nuevo Plato", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSeleccionarPlato_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingresa el número de plato al que deseas agregar los tacos:",
                    "Seleccionar Plato",
                    platoActual.ToString());

                if (string.IsNullOrWhiteSpace(input))
                    return;

                if (!int.TryParse(input, out int nuevoPlato) || nuevoPlato <= 0)
                {
                    MessageBox.Show("Número de plato no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                platoActual = nuevoPlato;
                tacosEnPlato = 0;
                foreach (DataGridViewRow fila in dgvMenu.Rows)
                {
                    if (fila.IsNewRow) continue;
                    if (Convert.ToInt32(fila.Cells[6].Value) == platoActual)
                    {
                        tacosEnPlato += Convert.ToInt32(fila.Cells[4].Value);
                    }
                }

                txtPlato.Text = platoActual.ToString();

                MessageBox.Show($"Ahora estás agregando al plato {platoActual}. " +
                                $"(Actualmente tiene {tacosEnPlato} tacos)",
                                "Plato seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar plato: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmConsulta consulta = new frmConsulta();
            consulta.Show();
            this.Close();
        }
    }
}
