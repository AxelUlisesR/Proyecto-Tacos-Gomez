using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Tacos_Gomez
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos frmProductos = new Productos();
            Hide();
            frmProductos.Show();

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        Empleados frmEmpleados = new Empleados();
            Hide();
            frmEmpleados.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientesForm = new Clientes();
            Hide();
            clientesForm.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas ventasForm = new Ventas();
            Hide();
            ventasForm.Show();

        }

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 reportesForm = new Form7();
            Hide();
            reportesForm.Show();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
