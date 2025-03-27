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
    public partial class ReporteCompraporCompraDiaria : Form
    {
        public ReporteCompraporCompraDiaria()
        {
            InitializeComponent();
        }

        private void ReporteCompraporCompraDiaria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_LACTEOSCALEBDataSetReporteCompra.ReporteCompraporCompraDiaria' Puede moverla o quitarla según sea necesario.
            this.reporteCompraporCompraDiariaTableAdapter.Fill(this.bD_LACTEOSCALEBDataSetReporteCompra.ReporteCompraporCompraDiaria);

            this.reportViewer1.RefreshReport();//refresca la herramienta de reportviewer
        }
    }
}
