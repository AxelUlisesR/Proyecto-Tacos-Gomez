using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Npgsql;

namespace Proyecto_Tacos_Gomez
{
    public partial class Form7 : Form
    {
        // Conexión a PostgreSQL
        NpgsqlConnection conexion = new NpgsqlConnection("Host=localhost;Port=5432;Database=Taqueria;Username=postgres;Password=Ramamos06;");

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void btnGenerarReporte1_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = "SELECT * FROM reporte_ordenes_resumido();";
                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(consulta, conexion);
                TaqueriaDataSet ds = new TaqueriaDataSet();
                adaptador.Fill(ds.orden);
                ReportDataSource fuente = new ReportDataSource("DataSet1", ds.Tables["orden"]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(fuente);
                string rutaReporte = Path.Combine(Application.StartupPath, @"..\..\Report1.rdlc");
                reportViewer1.LocalReport.ReportPath = Path.GetFullPath(rutaReporte);


                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message);
            }
        }

        private void btnGenerarReporteVendido_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = "SELECT * FROM reporte_productos_mas_vendidos();";
                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(consulta, conexion);
                TaqueriaDataSet ds = new TaqueriaDataSet();
                adaptador.Fill(ds.producto);
                ReportDataSource fuente = new ReportDataSource("DataSet1", ds.Tables["producto"]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(fuente);
                string rutaReporte = Path.Combine(Application.StartupPath, @"..\..\Report2.rdlc");
                reportViewer1.LocalReport.ReportPath = Path.GetFullPath(rutaReporte);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message);
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
    }
}