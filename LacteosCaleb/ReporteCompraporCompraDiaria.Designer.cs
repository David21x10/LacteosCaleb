namespace LacteosCaleb
{
    partial class ReporteCompraporCompraDiaria
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
            this.reporteCompraporCompraDiariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_LACTEOSCALEBDataSetReporteCompra = new LacteosCaleb.BD_LACTEOSCALEBDataSetReporteCompra();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteCompraporCompraDiariaTableAdapter = new LacteosCaleb.BD_LACTEOSCALEBDataSetReporteCompraTableAdapters.ReporteCompraporCompraDiariaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteCompraporCompraDiariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LACTEOSCALEBDataSetReporteCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteCompraporCompraDiariaBindingSource
            // 
            this.reporteCompraporCompraDiariaBindingSource.DataMember = "ReporteCompraporCompraDiaria";
            this.reporteCompraporCompraDiariaBindingSource.DataSource = this.bD_LACTEOSCALEBDataSetReporteCompra;
            // 
            // bD_LACTEOSCALEBDataSetReporteCompra
            // 
            this.bD_LACTEOSCALEBDataSetReporteCompra.DataSetName = "BD_LACTEOSCALEBDataSetReporteCompra";
            this.bD_LACTEOSCALEBDataSetReporteCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetReporteCompraporCompradiaria";
            reportDataSource1.Value = this.reporteCompraporCompraDiariaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LacteosCaleb.ReporteCompraporCompraDiaria.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporteCompraporCompraDiariaTableAdapter
            // 
            this.reporteCompraporCompraDiariaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCompraporCompraDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCompraporCompraDiaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPRADIARIA";
            this.Load += new System.EventHandler(this.ReporteCompraporCompraDiaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteCompraporCompraDiariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LACTEOSCALEBDataSetReporteCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BD_LACTEOSCALEBDataSetReporteCompra bD_LACTEOSCALEBDataSetReporteCompra;
        private System.Windows.Forms.BindingSource reporteCompraporCompraDiariaBindingSource;
        private BD_LACTEOSCALEBDataSetReporteCompraTableAdapters.ReporteCompraporCompraDiariaTableAdapter reporteCompraporCompraDiariaTableAdapter;
    }
}