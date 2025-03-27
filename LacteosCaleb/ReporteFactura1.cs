using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LacteosCaleb
{
    public partial class ReporteFactura1 : Form
    {
        private int ide;//variable que guarda el id de factura
        public ReporteFactura1(int ide)
        {
            InitializeComponent();
            this.ide = ide;// Asigna el valor de ide al campo de la clase this.ide
        }

        private void ReporteFactura1_Load(object sender, EventArgs e)
        {
            this.reporteFacturaTableAdapter.Fill(this.bD_LACTEOSCALEBDataSetReporteFactura.ReporteFactura, ide);// Llena la tabla reporteFactura con datos filtrados por ide
            this.reportViewer1.RefreshReport();// Actualiza el reportviewer para mostrar el nuevo informe

        }

        private void ReporteFacturaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
