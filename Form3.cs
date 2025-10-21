using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace Proyecto_Tacos_Gomez
{
    public partial class Empleados : Form
    {
        NpgsqlConnection conexion = new NpgsqlConnection("Host=localhost;Port=5432;Database=Taqueria;Username=postgres;Password=Ramamos06;");
        NpgsqlCommand comando = new NpgsqlCommand();
        NpgsqlDataReader lector;

        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                comando.Connection = conexion;
                CargarEmpleados();
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void EstadoInicial()
        {
            txtId.Enabled = false;
            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            maskedTextBox1.Enabled = false;
            txtRol.Enabled = false;

            btnNuevo.Enabled = true;
            btnGrabar.Enabled = false;
            btnModificar.Enabled = false;
            btnBusca.Enabled = true;
            btnCancelar.Enabled = true;

            LimpiarCampos();
        }

        private void ModoEdicion(bool nuevo = false)
        {
            txtNombre.Enabled = true;
            txtDireccion.Enabled = true;
            maskedTextBox1.Enabled = true;
            txtRol.Enabled = true;

            btnNuevo.Enabled = false;
            btnBusca.Enabled = false;
            btnModificar.Enabled = !nuevo;
            btnGrabar.Enabled = nuevo;
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            maskedTextBox1.Text = "";
            txtRol.Text = "";
        }

        private void CargarEmpleados()
        {
            dgvClientes.Rows.Clear();
            comando.CommandText = "SELECT idempleado, nombre, direccion, telefono, rol FROM empleados ORDER BY idempleado";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvClientes.Rows.Add(
                    lector["idempleado"],
                    lector["nombre"],
                    lector["direccion"],
                    lector["telefono"],
                    lector["rol"]
                );
            }
            lector.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                ModoEdicion(true);
                comando.CommandText = "SELECT COALESCE(MAX(idempleado), 0) + 1 FROM empleados";
                txtId.Text = comando.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear nuevo empleado: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBox1.Text) || string.IsNullOrWhiteSpace(txtRol.Text))
            {
                MessageBox.Show("Debe llenar todos los campos antes de guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                comando.CommandText = "INSERT INTO empleados (nombre, direccion, telefono, rol) VALUES (@nombre, @direccion, @telefono, @rol)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                comando.Parameters.AddWithValue("@telefono", maskedTextBox1.Text);
                comando.Parameters.AddWithValue("@rol", txtRol.Text);
                comando.ExecuteNonQuery();

                MessageBox.Show("Empleado guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEmpleados();
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar el empleado: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar un empleado antes de modificar.");
                return;
            }

            try
            {
                comando.CommandText = "UPDATE empleados SET nombre=@nombre, direccion=@direccion, telefono=@telefono, rol=@rol WHERE idempleado=@id";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                comando.Parameters.AddWithValue("@telefono", maskedTextBox1.Text);
                comando.Parameters.AddWithValue("@rol", txtRol.Text);
                comando.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                comando.ExecuteNonQuery();

                MessageBox.Show("Empleado modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEmpleados();
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el empleado: " + ex.Message);
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Introducir el Id del empleado:", "Buscar empleado");

                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Debe ingresar un Id válido.");
                    return;
                }

                if (!int.TryParse(input, out int idEmpleado))
                {
                    MessageBox.Show("El Id introducido no tiene un formato correcto.");
                    return;
                }

                comando.CommandText = "SELECT * FROM empleados WHERE idempleado=@id";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", idEmpleado);
                lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    txtId.Text = lector["idempleado"].ToString();
                    txtNombre.Text = lector["nombre"].ToString();
                    txtDireccion.Text = lector["direccion"].ToString();
                    maskedTextBox1.Text = lector["telefono"].ToString();
                    txtRol.Text = lector["rol"].ToString();

                    lector.Close();
                    ModoEdicion(false);
                }
                else
                {
                    lector.Close();
                    MessageBox.Show("El Id ingresado no existe.");
                }
            }
            catch (Exception ex)
            {
                lector?.Close();
                MessageBox.Show("Error al buscar el empleado: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnSalir_Click(object sender, EventArgs e)
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
    }
}
