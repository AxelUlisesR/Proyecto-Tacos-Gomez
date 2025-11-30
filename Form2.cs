using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Npgsql;

namespace Proyecto_Tacos_Gomez
{
    public partial class Clientes : Form
    {
        NpgsqlConnection conexion = new NpgsqlConnection("Host=localhost;Port=5432;Database=Taqueria;Username=usuario;Password=1234;");
        NpgsqlCommand comando = new NpgsqlCommand();
        NpgsqlDataReader lector;

        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            try
            {
                // Limita la cantidad de caracteres permitidos
                txtNombre.MaxLength = 40;
                txtDireccion.MaxLength = 80;
                // Si usas un TextBox para teléfono, puedes poner 10
                // maskedTextBox1 no tiene MaxLength, pero puedes controlar el formato con el Mask

                conexion.Open();
                comando.Connection = conexion;
                CargarClientes();
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar o cargar datos: " + ex.Message);
            }
        }

        // ========================= MÉTODOS DE CONTROL DE INTERFAZ =========================
        private void EstadoInicial()
        {
            txtId.Enabled = false;
            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            maskedTextBox1.Enabled = false;

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
        }

        private void CargarClientes()
        {
            dgvClientes.Rows.Clear();
            comando.CommandText = "SELECT idcliente, nombre, direccion, telefono FROM clientes ORDER BY idcliente";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvClientes.Rows.Add(
                    lector["idcliente"],
                    lector["nombre"],
                    lector["direccion"],
                    lector["telefono"]
                );
            }
            lector.Close();
        }

        // ========================= BOTONES =========================

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                ModoEdicion(true);
                comando.CommandText = "SELECT COALESCE(MAX(idcliente), 0) + 1 FROM clientes";
                txtId.Text = comando.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear nuevo registro: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                return;
                txtNombre.KeyPress += txtNombre_KeyPress;
            }

            try
            {
                comando.CommandText = "INSERT INTO clientes (nombre, direccion, telefono) VALUES (@nombre, @direccion, @telefono)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                comando.Parameters.AddWithValue("@telefono", maskedTextBox1.Text);
                comando.ExecuteNonQuery();

                MessageBox.Show("Cliente guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes();
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar el cliente: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar o buscar un cliente antes de modificar.");
                return;
            }

            if (!ValidarFormulario())
            {
                return;
            }

            try
            {
                comando.CommandText = "UPDATE clientes SET nombre=@nombre, direccion=@direccion, telefono=@telefono WHERE idcliente=@id";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                comando.Parameters.AddWithValue("@telefono", maskedTextBox1.Text);
                comando.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                comando.ExecuteNonQuery();

                MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes();
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente: " + ex.Message);
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Introducir el Id del cliente:", "Buscar cliente");

                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Debe ingresar un Id válido.");
                    return;
                }

                if (!int.TryParse(input, out int idCliente))
                {
                    MessageBox.Show("El Id introducido no tiene un formato correcto.");
                    return;
                }

                comando.CommandText = "SELECT * FROM clientes WHERE idcliente=@id";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", idCliente);
                lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    txtId.Text = lector["idcliente"].ToString();
                    txtNombre.Text = lector["nombre"].ToString();
                    txtDireccion.Text = lector["direccion"].ToString();
                    maskedTextBox1.Text = lector["telefono"].ToString();

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
                MessageBox.Show("Error al buscar el cliente: " + ex.Message);
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
        private bool ValidarFormulario()
        {
            bool esValido = true;
            errorProvider1.Clear();

            // 1. Campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre es obligatorio.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                errorProvider1.SetError(txtDireccion, "La dirección es obligatoria.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                errorProvider1.SetError(maskedTextBox1, "El teléfono es obligatorio.");
                esValido = false;
            }

            // 2. Solo letras en nombre
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !Regex.IsMatch(txtNombre.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                errorProvider1.SetError(txtNombre, "El nombre solo debe contener letras.");
                esValido = false;
            }

            // 3. Longitud máxima para nombre y dirección
            if (txtNombre.Text.Length > 40)
            {
                errorProvider1.SetError(txtNombre, "El nombre no puede tener más de 40 caracteres.");
                esValido = false;
            }
            if (txtDireccion.Text.Length > 80)
            {
                errorProvider1.SetError(txtDireccion, "La dirección no puede tener más de 80 caracteres.");
                esValido = false;
            }

            // 4. Teléfono: solo números y 10 dígitos
            string telefono = maskedTextBox1.Text.Replace(" ", "").Replace("-", "");
            if (!Regex.IsMatch(telefono, @"^\d{10}$"))
            {
                errorProvider1.SetError(maskedTextBox1, "El teléfono debe tener 10 dígitos numéricos.");
                esValido = false;
            }

            return esValido;
        }   
private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, espacios y teclas de control (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
    }
        

        }
}
