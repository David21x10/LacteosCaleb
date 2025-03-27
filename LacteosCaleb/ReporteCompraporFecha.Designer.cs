namespace LacteosCaleb
{
    partial class ReporteCompraporFecha
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
            this.reporteCompraporFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_LACTEOSCALEBDataSetReporteCompra = new LacteosCaleb.BD_LACTEOSCALEBDataSetReporteCompra();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteCompraporFechaTableAdapter = new LacteosCaleb.BD_LACTEOSCALEBDataSetReporteCompraTableAdapters.ReporteCompraporFechaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteCompraporFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LACTEOSCALEBDataSetReporteCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteCompraporFechaBindingSource
            // 
            this.reporteCompraporFechaBindingSource.DataMember = "ReporteCompraporFecha";
            this.reporteCompraporFechaBindingSource.DataSource = this.bD_LACTEOSCALEBDataSetReporteCompra;
            // 
            // bD_LACTEOSCALEBDataSetReporteCompra
            // 
            this.bD_LACTEOSCALEBDataSetReporteCompra.DataSetName = "BD_LACTEOSCALEBDataSetReporteCompra";
            this.bD_LACTEOSCALEBDataSetReporteCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetReporteCompraporFecha";
            reportDataSource1.Value = this.reporteCompraporFechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LacteosCaleb.ReporteCompraporfecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 59);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(641, 246);
            this.reportViewer1.TabIndex = 31;
            // 
            // reporteCompraporFechaTableAdapter
            // 
            this.reporteCompraporFechaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCompraporFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(670, 321);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Name = "ReporteCompraporFecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportePorFecha";
            this.Load += new System.EventHandler(this.ReporteCompraporFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteCompraporFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_LACTEOSCALEBDataSetReporteCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteCompraporFechaBindingSource;
        private BD_LACTEOSCALEBDataSetReporteCompra bD_LACTEOSCALEBDataSetReporteCompra;
        private BD_LACTEOSCALEBDataSetReporteCompraTableAdapters.ReporteCompraporFechaTableAdapter reporteCompraporFechaTableAdapter;
    }
}