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
    public partial class ReporteClienteMasCompra : Form
    {
        public ReporteClienteMasCompra()
        {
            InitializeComponent();
        }

        private void ReporteClienteMasCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_LACTEOSCALEBDataSetReporteFactura.ReporteClienteMasCompra' Puede moverla o quitarla según sea necesario.
            this.reporteClienteMasCompraTableAdapter.Fill(this.bD_LACTEOSCALEBDataSetReporteFactura.ReporteClienteMasCompra);

            this.reportViewer1.RefreshReport();//reinicia la herramienta reportviewer, la refresca
        }
    }
}
