using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Npgsql;

namespace Proyecto_Tacos_Gomez
{
    public partial class Productos : Form
    {
        NpgsqlConnection conexion = new NpgsqlConnection("Host=localhost;Port=5432;Database=Taqueria;Username=usuario;Password=1234;"); NpgsqlCommand comando = new NpgsqlCommand();
        NpgsqlDataReader lector;

        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            try
            {
                txtNombre.MaxLength = 40;
                cbCategoria.MaxLength = 40;
                cbCategoria.Items.Add("Taco");
                cbCategoria.Items.Add("Quesadilla");
                cbCategoria.Items.Add("Torta");
                cbCategoria.Items.Add("Bebida");
                conexion.Open();
                comando.Connection = conexion;
                CargarProductos();
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void EstadoInicial()
        {
            LimpiarCampos();
            txtId.Enabled = false;
            txtNombre.Enabled = false;
            mtbPrecio.Enabled = false;
            cbCategoria.Enabled = false;

            btnNuevo.Enabled = true;
            btnGrabar.Enabled = false;
            btnModificar.Enabled = false;
            btnBusca.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void ModoEdicion(bool nuevo = false)
        {
            txtNombre.Enabled = true;
            mtbPrecio.Enabled = true;
            cbCategoria.Enabled = true;

            btnNuevo.Enabled = false;
            btnBusca.Enabled = false;
            btnModificar.Enabled = !nuevo;
            btnGrabar.Enabled = nuevo;
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            mtbPrecio.Text = "";
            cbCategoria.Text = "";
        }

        private void CargarProductos()
        {
            dgvClientes.Rows.Clear();
            comando.CommandText = "SELECT idProducto, nombre, precio, categoria FROM Productos ORDER BY idProducto";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvClientes.Rows.Add(
                    lector["idProducto"],
                    lector["nombre"],
                    lector["precio"],
                    lector["categoria"]
                );
            }
            lector.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                ModoEdicion(true);
                comando.CommandText = "SELECT COALESCE(MAX(idProducto),0)+1 FROM Productos";
                txtId.Text = comando.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear nuevo producto: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                return;
                txtNombre.KeyPress += txtNombre_KeyPress;
                cbCategoria.KeyPress += txtCategoria_KeyPress;
            }
            try
            {
                comando.CommandText = "INSERT INTO Productos (nombre, precio, categoria) VALUES (@nombre, @precio, @categoria)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@precio", Convert.ToDouble(mtbPrecio.Text));
                comando.Parameters.AddWithValue("@categoria", cbCategoria.Text);
                comando.ExecuteNonQuery();

                MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
                EstadoInicial();
                cbCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar el producto: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar un producto antes de modificar.");
                return;
            }
            if (!ValidarFormulario())
            {
                return;
            }
            try
            {
                comando.CommandText = "UPDATE Productos SET nombre=@nombre, precio=@precio, categoria=@categoria WHERE idProducto=@id";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@precio", Convert.ToDouble(mtbPrecio.Text));
                comando.Parameters.AddWithValue("@categoria", cbCategoria.Text);
                comando.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                comando.ExecuteNonQuery();

                MessageBox.Show("Producto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto: " + ex.Message);
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Introducir el Id del producto:", "Buscar producto");

                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Debe ingresar un Id válido.");
                    return;
                }

                if (!int.TryParse(input, out int idProducto))
                {
                    MessageBox.Show("El Id introducido no tiene un formato correcto.");
                    return;
                }

                comando.CommandText = "SELECT * FROM Productos WHERE idProducto=@id";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", idProducto);
                lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    txtId.Text = lector["idProducto"].ToString();
                    txtNombre.Text = lector["nombre"].ToString();
                    mtbPrecio.Text = lector["precio"].ToString();
                    cbCategoria.Text = lector["categoria"].ToString();

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
                MessageBox.Show("Error al buscar el producto: " + ex.Message);
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
            if (string.IsNullOrWhiteSpace(mtbPrecio.Text))
            {
                errorProvider1.SetError(mtbPrecio, "El precio es obligatorio.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(cbCategoria.Text))
            {
                errorProvider1.SetError(cbCategoria, "La categoria es obligatorio.");
                esValido = false;
            }

            // 2. Solo letras en nombre
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !Regex.IsMatch(txtNombre.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                errorProvider1.SetError(txtNombre, "El nombre solo debe contener letras.");
                esValido = false;
            }

            // 3. Longitud máxima para nombre y categoria
            if (txtNombre.Text.Length > 40)
            {
                errorProvider1.SetError(txtNombre, "El nombre no puede tener más de 40 caracteres.");
                esValido = false;
            }
            if (cbCategoria.Text.Length > 40)
            {
                errorProvider1.SetError(cbCategoria, "La categoria no puede tener más de 40 caracteres.");
                esValido = false;
            }
            //4. solo letras en categoria
            if (!string.IsNullOrWhiteSpace(cbCategoria.Text) &&
                !Regex.IsMatch(cbCategoria.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                errorProvider1.SetError(txtNombre, "La categoria solo debe contener letras.");
                esValido = false;
            }
            if (!string.IsNullOrWhiteSpace(mtbPrecio.Text) &&
                !Regex.IsMatch(mtbPrecio.Text, @"^\d+$"))
            {
                errorProvider1.SetError(mtbPrecio, "El precio solo debe contener números.");
                esValido = false;
            }


            return esValido;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mtbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}