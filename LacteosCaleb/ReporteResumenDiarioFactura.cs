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
    public partial class ReporteResumenDiarioFactura : Form
    {
        public ReporteResumenDiarioFactura()
        {
            InitializeComponent();
        }

        private void ReporteResumenDiarioFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_LACTEOSCALEBDataSetReporteFactura.ReporteResumenDiarioFactura' Puede moverla o quitarla según sea necesario.
            this.reporteResumenDiarioFacturaTableAdapter.Fill(this.bD_LACTEOSCALEBDataSetReporteFactura.ReporteResumenDiarioFactura);

            this.reportViewer1.RefreshReport();//actualiza la informacion del report viewer
        }
    }
}
