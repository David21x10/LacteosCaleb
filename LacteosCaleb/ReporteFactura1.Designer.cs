namespace LacteosCaleb
{
    partial class ReporteFactura1
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
            this.reporteFacturaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bDLACTEOSCALEBDataSetReporteFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_LACTEOSCALEBDataSetReporteFactura = new LacteosCaleb.BD_LACTEOSCALEBDataSetReporteFactura();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteFacturaTableAdapter = new LacteosCaleb.BD_LACTEOSCALEBDataSetReporteFacturaTableAdapters.ReporteFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteFacturaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLACTEOSCALEBDataSetReporteFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LACTEOSCALEBDataSetReporteFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteFacturaBindingSource1
            // 
            this.reporteFacturaBindingSource1.DataMember = "ReporteFactura";
            this.reporteFacturaBindingSource1.DataSource = this.bDLACTEOSCALEBDataSetReporteFacturaBindingSource;
            // 
            // bDLACTEOSCALEBDataSetReporteFacturaBindingSource
            // 
            this.bDLACTEOSCALEBDataSetReporteFacturaBindingSource.DataSource = this.bD_LACTEOSCALEBDataSetReporteFactura;
            this.bDLACTEOSCALEBDataSetReporteFacturaBindingSource.Position = 0;
            // 
            // bD_LACTEOSCALEBDataSetReporteFactura
            // 
            this.bD_LACTEOSCALEBDataSetReporteFactura.DataSetName = "BD_LACTEOSCALEBDataSetReporteFactura";
            this.bD_LACTEOSCALEBDataSetReporteFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetReporteFactura";
            reportDataSource1.Value = this.reporteFacturaBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LacteosCaleb.ReporteFactura1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteFacturaBindingSource
            // 
            this.ReporteFacturaBindingSource.DataMember = "ReporteFactura";
            this.ReporteFacturaBindingSource.DataSource = this.bD_LACTEOSCALEBDataSetReporteFactura;
            // 
            // reporteFacturaTableAdapter
            // 
            this.reporteFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteFactura1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteFactura1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACTURA";
            this.Load += new System.EventHandler(this.ReporteFactura1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteFacturaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLACTEOSCALEBDataSetReporteFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LACTEOSCALEBDataSetReporteFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BD_LACTEOSCALEBDataSetReporteFactura bD_LACTEOSCALEBDataSetReporteFactura;
        private System.Windows.Forms.BindingSource reporteFacturaBindingSource1;
        private System.Windows.Forms.BindingSource bDLACTEOSCALEBDataSetReporteFacturaBindingSource;
        private System.Windows.Forms.BindingSource ReporteFacturaBindingSource;
        private BD_LACTEOSCALEBDataSetReporteFacturaTableAdapters.ReporteFacturaTableAdapter reporteFacturaTableAdapter;
    }
}