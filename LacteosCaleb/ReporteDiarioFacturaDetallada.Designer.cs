namespace LacteosCaleb
{
    partial class ReporteDiarioFacturaDetallada
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reporteFacturaDiariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_LACTEOSCALEBDataSetReporteFactura = new LacteosCaleb.BD_LACTEOSCALEBDataSetReporteFactura();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteFacturaDiariaTableAdapter = new LacteosCaleb.BD_LACTEOSCALEBDataSetReporteFacturaTableAdapters.ReporteFacturaDiariaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteFacturaDiariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LACTEOSCALEBDataSetReporteFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteFacturaDiariaBindingSource
            // 
            this.reporteFacturaDiariaBindingSource.DataMember = "ReporteFacturaDiaria";
            this.reporteFacturaDiariaBindingSource.DataSource = this.bD_LACTEOSCALEBDataSetReporteFactura;
            // 
            // bD_LACTEOSCALEBDataSetReporteFactura
            // 
            this.bD_LACTEOSCALEBDataSetReporteFactura.DataSetName = "BD_LACTEOSCALEBDataSetReporteFactura";
            this.bD_LACTEOSCALEBDataSetReporteFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetReporteDiarioFact";
            reportDataSource1.Value = this.reporteFacturaDiariaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LacteosCaleb.ReporteDiariodeFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporteFacturaDiariaTableAdapter
            // 
            this.reporteFacturaDiariaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteDiarioFacturaDetallada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteDiarioFacturaDetallada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteDiario";
            this.Load += new System.EventHandler(this.ReporteDiarioFacturaDetallada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteFacturaDiariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LACTEOSCALEBDataSetReporteFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BD_LACTEOSCALEBDataSetReporteFactura bD_LACTEOSCALEBDataSetReporteFactura;
        private System.Windows.Forms.BindingSource reporteFacturaDiariaBindingSource;
        private BD_LACTEOSCALEBDataSetReporteFacturaTableAdapters.ReporteFacturaDiariaTableAdapter reporteFacturaDiariaTableAdapter;
    }
}