namespace LacteosCaleb
{
    partial class ReporteCompraResumenDeldia
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
            this.reporteCompraResumenDelDiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_LACTEOSCALEBDataSetReporteCompra = new LacteosCaleb.BD_LACTEOSCALEBDataSetReporteCompra();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteCompraResumenDelDiaTableAdapter = new LacteosCaleb.BD_LACTEOSCALEBDataSetReporteCompraTableAdapters.ReporteCompraResumenDelDiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteCompraResumenDelDiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LACTEOSCALEBDataSetReporteCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteCompraResumenDelDiaBindingSource
            // 
            this.reporteCompraResumenDelDiaBindingSource.DataMember = "ReporteCompraResumenDelDia";
            this.reporteCompraResumenDelDiaBindingSource.DataSource = this.bD_LACTEOSCALEBDataSetReporteCompra;
            // 
            // bD_LACTEOSCALEBDataSetReporteCompra
            // 
            this.bD_LACTEOSCALEBDataSetReporteCompra.DataSetName = "BD_LACTEOSCALEBDataSetReporteCompra";
            this.bD_LACTEOSCALEBDataSetReporteCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetReporteCompraResumenDeldia";
            reportDataSource1.Value = this.reporteCompraResumenDelDiaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LacteosCaleb.ReporteCompraResumenDelDia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(637, 392);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporteCompraResumenDelDiaTableAdapter
            // 
            this.reporteCompraResumenDelDiaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCompraResumenDeldia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 392);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCompraResumenDeldia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESUMENDELDIA";
            this.Load += new System.EventHandler(this.ReporteCompraResumenDeldia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteCompraResumenDelDiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LACTEOSCALEBDataSetReporteCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BD_LACTEOSCALEBDataSetReporteCompra bD_LACTEOSCALEBDataSetReporteCompra;
        private System.Windows.Forms.BindingSource reporteCompraResumenDelDiaBindingSource;
        private BD_LACTEOSCALEBDataSetReporteCompraTableAdapters.ReporteCompraResumenDelDiaTableAdapter reporteCompraResumenDelDiaTableAdapter;
    }
}