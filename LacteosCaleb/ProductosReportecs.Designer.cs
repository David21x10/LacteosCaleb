namespace LacteosCaleb
{
    partial class ProductosReportecs
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.productosmasvendidoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bDLACTEOSCALEBDataSetProductosmasvendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_LACTEOSCALEBDataSetProductosmasvendidos = new LacteosCaleb.BD_LACTEOSCALEBDataSetProductosmasvendidos();
            this.productosmenosvendidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDLACTEOSCALEBDataSetProductosmasvendidosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.productosmasvendidoTableAdapter = new LacteosCaleb.BD_LACTEOSCALEBDataSetProductosmasvendidosTableAdapters.ProductosmasvendidoTableAdapter();
            this.productosmenosvendidoTableAdapter = new LacteosCaleb.BD_LACTEOSCALEBDataSetProductosmasvendidosTableAdapters.ProductosmenosvendidoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productosmasvendidoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLACTEOSCALEBDataSetProductosmasvendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LACTEOSCALEBDataSetProductosmasvendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosmenosvendidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLACTEOSCALEBDataSetProductosmasvendidosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // productosmasvendidoBindingSource1
            // 
            this.productosmasvendidoBindingSource1.DataMember = "Productosmasvendido";
            this.productosmasvendidoBindingSource1.DataSource = this.bDLACTEOSCALEBDataSetProductosmasvendidosBindingSource;
            // 
            // bDLACTEOSCALEBDataSetProductosmasvendidosBindingSource
            // 
            this.bDLACTEOSCALEBDataSetProductosmasvendidosBindingSource.DataSource = this.bD_LACTEOSCALEBDataSetProductosmasvendidos;
            this.bDLACTEOSCALEBDataSetProductosmasvendidosBindingSource.Position = 0;
            // 
            // bD_LACTEOSCALEBDataSetProductosmasvendidos
            // 
            this.bD_LACTEOSCALEBDataSetProductosmasvendidos.DataSetName = "BD_LACTEOSCALEBDataSetProductosmasvendidos";
            this.bD_LACTEOSCALEBDataSetProductosmasvendidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosmenosvendidoBindingSource
            // 
            this.productosmenosvendidoBindingSource.DataMember = "Productosmenosvendido";
            this.productosmenosvendidoBindingSource.DataSource = this.bDLACTEOSCALEBDataSetProductosmasvendidosBindingSource1;
            // 
            // bDLACTEOSCALEBDataSetProductosmasvendidosBindingSource1
            // 
            this.bDLACTEOSCALEBDataSetProductosmasvendidosBindingSource1.DataSource = this.bD_LACTEOSCALEBDataSetProductosmasvendidos;
            this.bDLACTEOSCALEBDataSetProductosmasvendidosBindingSource1.Position = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetProduuctos";
            reportDataSource1.Value = this.productosmasvendidoBindingSource1;
            reportDataSource2.Name = "DataSetProductomenosVendido";
            reportDataSource2.Value = this.productosmenosvendidoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LacteosCaleb.ReporteProducto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // productosmasvendidoTableAdapter
            // 
            this.productosmasvendidoTableAdapter.ClearBeforeFill = true;
            // 
            // productosmenosvendidoTableAdapter
            // 
            this.productosmenosvendidoTableAdapter.ClearBeforeFill = true;
            // 
            // ProductosReportecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ProductosReportecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.ProductosReportecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosmasvendidoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLACTEOSCALEBDataSetProductosmasvendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LACTEOSCALEBDataSetProductosmasvendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosmenosvendidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDLACTEOSCALEBDataSetProductosmasvendidosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BD_LACTEOSCALEBDataSetProductosmasvendidos bD_LACTEOSCALEBDataSetProductosmasvendidos;
        private System.Windows.Forms.BindingSource productosmasvendidoBindingSource1;
        private BD_LACTEOSCALEBDataSetProductosmasvendidosTableAdapters.ProductosmasvendidoTableAdapter productosmasvendidoTableAdapter;
        private System.Windows.Forms.BindingSource bDLACTEOSCALEBDataSetProductosmasvendidosBindingSource;
        private System.Windows.Forms.BindingSource bDLACTEOSCALEBDataSetProductosmasvendidosBindingSource1;
        private System.Windows.Forms.BindingSource productosmenosvendidoBindingSource;
        private BD_LACTEOSCALEBDataSetProductosmasvendidosTableAdapters.ProductosmenosvendidoTableAdapter productosmenosvendidoTableAdapter;
    }
}