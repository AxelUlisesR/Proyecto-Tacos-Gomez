using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Npgsql;

namespace Proyecto_Tacos_Gomez
{
    public partial class frmConsulta : Form
    {
        NpgsqlConnection conexion = new NpgsqlConnection("Host=localhost;Port=5432;Database=Taqueria;Username=postgres;Password=Ramamos06;");
        NpgsqlCommand comando;
        NpgsqlDataReader lector;

        public frmConsulta()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                comando = new NpgsqlCommand();
                comando.Connection = conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);
            }

            ColoresBoton();
            ColoresTexto();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Ingrese el ID de la venta a consultar");
                    txtId.Focus();
                    LimpiarCampos();
                    return;
                }

                dgvMenu.Rows.Clear();

                comando.CommandText = $@"
                    SELECT o.idorden, o.idcliente, o.idempleado, o.fecha, o.total,
                           c.nombre AS nombre_cliente, c.direccion AS dir_cliente, c.telefono AS tel_cliente,
                           e.nombre AS nombre_empleado, e.direccion AS dir_empleado, e.telefono AS tel_empleado, e.rol, o.estado
                    FROM ordenes o
                    INNER JOIN clientes c ON c.idcliente = o.idcliente
                    INNER JOIN empleados e ON e.idempleado = o.idempleado
                    WHERE o.idorden = {Convert.ToInt32(txtId.Text)}";

                lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    txtId.Text = lector["idorden"].ToString();
                    txtFecha.Text = Convert.ToDateTime(lector["fecha"]).ToShortDateString();
                    txtTotal.Text = lector["total"].ToString();

                    txtNombreCliente.Text = lector["nombre_cliente"].ToString();
                    txtDireccion.Text = lector["dir_cliente"].ToString();
                    txtCliente.Text = lector["tel_cliente"].ToString();

                    txtNombreEmpleado.Text = lector["nombre_empleado"].ToString();
                    txtDireccionEmpleado.Text = lector["dir_empleado"].ToString();
                    txtTelefonoEmpleado.Text = lector["tel_empleado"].ToString();
                    txtRol.Text = lector["rol"].ToString();

                    txtEstado.Text = lector["estado"].ToString();
                    lector.Close();

                    comando.CommandText = $@"
                        SELECT d.idproducto, p.nombre AS producto, p.categoria, p.precio, 
                               d.cantidad, (p.precio * d.cantidad) AS importe,d.plato
                        FROM detordenes d
                        INNER JOIN productos p ON p.idproducto = d.idproducto
                        WHERE d.idorden = {Convert.ToInt32(txtId.Text)}";

                    lector = comando.ExecuteReader();

                    double subTotal = 0;
                    while (lector.Read())
                    {
                        double importe = Convert.ToDouble(lector["importe"]);
                        subTotal += importe;

                        dgvMenu.Rows.Add(
                            lector["idproducto"].ToString(),
                            lector["producto"].ToString(),
                            lector["categoria"].ToString(),
                            lector["precio"].ToString(),
                            lector["cantidad"].ToString(),
                            importe.ToString("0.00"),
                            lector["plato"].ToString()
                        );
                    }
                    lector.Close();

                    txtSubtotal.Text = subTotal.ToString("0.00");
                    txtIVA.Text = (subTotal * 0.16).ToString("0.00");
                    txtTotal.Text = (subTotal * 1.16).ToString("0.00");

                    string estado = txtEstado.Text;
                    cmdCancelar.Enabled = (estado == "R" || estado == "S");
                    cmdSurtir.Enabled = (estado == "R");
                    cmdPagar.Enabled = (estado == "S");
                }
                else
                {
                    MessageBox.Show("No existe la venta con el ID: " + txtId.Text);
                    lector.Close();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la venta: " + ex.Message);
            }

            ColoresBoton();
            ColoresTexto();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                comando.CommandText = $@"
                    UPDATE ordenes
                    SET estado = 'C'
                    WHERE idorden = {Convert.ToInt32(txtId.Text)} 
                    AND (estado = 'R' OR estado = 'S')";
                comando.ExecuteNonQuery();
                cmdConsultar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cancelar la venta: " + ex.Message);
            }
        }

        private void cmdSurtir_Click(object sender, EventArgs e)
        {
            try
            {
                comando.CommandText = $@"
                    UPDATE ordenes
                    SET estado = 'S'
                    WHERE idorden = {Convert.ToInt32(txtId.Text)} AND estado = 'R'";
                comando.ExecuteNonQuery();
                cmdConsultar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al surtir la venta: " + ex.Message);
            }
        }

        private void cmdPagar_Click(object sender, EventArgs e)
        {
            try
            {
                comando.CommandText = $@"
                    UPDATE ordenes
                    SET estado = 'P'
                    WHERE idorden = {Convert.ToInt32(txtId.Text)} AND estado = 'S'";
                comando.ExecuteNonQuery();
                cmdConsultar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al pagar la venta: " + ex.Message);
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Menu frm = new Menu();
                frm.Show();
                conexion.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexión: " + ex.Message);
            }
        }

        // ---- MÉTODOS DE UTILIDAD ----

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtFecha.Text = "";
            txtSubtotal.Text = "";
            txtIVA.Text = "";
            txtTotal.Text = "";
            txtNombreCliente.Text = "";
            txtDireccion.Text = "";
            txtCliente.Text = "";
            txtNombreEmpleado.Text = "";
            txtDireccionEmpleado.Text = "";
            txtTelefonoEmpleado.Text = "";
            txtRol.Text = "";
            txtEstado.Text = "";
        }

        private void ColoresBoton()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button btn)
                {
                    if (btn.Enabled)
                    {
                        btn.BackColor = Color.LightGray;
                        btn.ForeColor = Color.Black;
                    }
                    else
                    {
                        btn.BackColor = Color.Gray;
                        btn.ForeColor = Color.DarkGray;
                    }
                }
            }
            cmdSalir.BackColor = Color.Red;
        }

        private void ColoresTexto()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox txt)
                {
                    if (txt.Enabled)
                    {
                        txt.BackColor = Color.White;
                        txt.ForeColor = Color.Black;
                    }
                    else
                    {
                        txt.BackColor = Color.LightGray;
                        txt.ForeColor = Color.DarkGray;
                    }
                }
                else if (control is MaskedTextBox mtb)
                {
                    if (mtb.Enabled)
                    {
                        mtb.BackColor = Color.White;
                        mtb.ForeColor = Color.Black;
                    }
                    else
                    {
                        mtb.BackColor = Color.LightGray;
                        mtb.ForeColor = Color.DarkGray;
                    }
                }
            }
        }

        
    }
}
