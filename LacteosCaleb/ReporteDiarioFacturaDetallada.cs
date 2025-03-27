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
    public partial class ReporteDiarioFacturaDetallada : Form
    {
        public ReporteDiarioFacturaDetallada()
        {
            InitializeComponent();
        }

        private void ReporteDiarioFacturaDetallada_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_LACTEOSCALEBDataSetReporteFactura.ReporteFacturaDiaria' Puede moverla o quitarla según sea necesario.
            this.reporteFacturaDiariaTableAdapter.Fill(this.bD_LACTEOSCALEBDataSetReporteFactura.ReporteFacturaDiaria);

            this.reportViewer1.RefreshReport();//actualiza la informacion del reporrtviewer
        }
    }
}
