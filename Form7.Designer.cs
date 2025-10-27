namespace Proyecto_Tacos_Gomez
{
    partial class Form7
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGenerarReporte1 = new System.Windows.Forms.Button();
            this.btnGenerarReporteVendido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(124, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1091, 717);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnGenerarReporte1
            // 
            this.btnGenerarReporte1.Location = new System.Drawing.Point(184, 843);
            this.btnGenerarReporte1.Name = "btnGenerarReporte1";
            this.btnGenerarReporte1.Size = new System.Drawing.Size(276, 61);
            this.btnGenerarReporte1.TabIndex = 1;
            this.btnGenerarReporte1.Text = "button1";
            this.btnGenerarReporte1.UseVisualStyleBackColor = true;
            this.btnGenerarReporte1.Click += new System.EventHandler(this.btnGenerarReporte1_Click);
            // 
            // btnGenerarReporteVendido
            // 
            this.btnGenerarReporteVendido.Location = new System.Drawing.Point(534, 843);
            this.btnGenerarReporteVendido.Name = "btnGenerarReporteVendido";
            this.btnGenerarReporteVendido.Size = new System.Drawing.Size(276, 61);
            this.btnGenerarReporteVendido.TabIndex = 2;
            this.btnGenerarReporteVendido.Text = "button1";
            this.btnGenerarReporteVendido.UseVisualStyleBackColor = true;
            this.btnGenerarReporteVendido.Click += new System.EventHandler(this.btnGenerarReporteVendido_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 952);
            this.Controls.Add(this.btnGenerarReporteVendido);
            this.Controls.Add(this.btnGenerarReporte1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnGenerarReporte1;
        private System.Windows.Forms.Button btnGenerarReporteVendido;
    }
}