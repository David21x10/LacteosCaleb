namespace LacteosCaleb
{
    partial class ReporteClienteMasCompra
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
            this.reporteClienteMasCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_LACTEOSCALEBDataSetReporteFactura = new LacteosCaleb.BD_LACTEOSCALEBDataSetReporteFactura();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteClienteMasCompraTableAdapter = new LacteosCaleb.BD_LACTEOSCALEBDataSetReporteFacturaTableAdapters.ReporteClienteMasCompraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteClienteMasCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LACTEOSCALEBDataSetReporteFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteClienteMasCompraBindingSource
            // 
            this.reporteClienteMasCompraBindingSource.DataMember = "ReporteClienteMasCompra";
            this.reporteClienteMasCompraBindingSource.DataSource = this.bD_LACTEOSCALEBDataSetReporteFactura;
            // 
            // bD_LACTEOSCALEBDataSetReporteFactura
            // 
            this.bD_LACTEOSCALEBDataSetReporteFactura.DataSetName = "BD_LACTEOSCALEBDataSetReporteFactura";
            this.bD_LACTEOSCALEBDataSetReporteFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetClienteMasCompra";
            reportDataSource1.Value = this.reporteClienteMasCompraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LacteosCaleb.Clientequemascompra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(640, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporteClienteMasCompraTableAdapter
            // 
            this.reporteClienteMasCompraTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteClienteMasCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteClienteMasCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTE QUE MAS COMPRA";
            this.Load += new System.EventHandler(this.ReporteClienteMasCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteClienteMasCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LACTEOSCALEBDataSetReporteFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BD_LACTEOSCALEBDataSetReporteFactura bD_LACTEOSCALEBDataSetReporteFactura;
        private System.Windows.Forms.BindingSource reporteClienteMasCompraBindingSource;
        private BD_LACTEOSCALEBDataSetReporteFacturaTableAdapters.ReporteClienteMasCompraTableAdapter reporteClienteMasCompraTableAdapter;
    }
}