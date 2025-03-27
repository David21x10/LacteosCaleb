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
    public partial class ReporteCompraResumenDeldia : Form
    {
        public ReporteCompraResumenDeldia()
        {
            InitializeComponent();
        }

        private void ReporteCompraResumenDeldia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_LACTEOSCALEBDataSetReporteCompra.ReporteCompraResumenDelDia' Puede moverla o quitarla según sea necesario.
            this.reporteCompraResumenDelDiaTableAdapter.Fill(this.bD_LACTEOSCALEBDataSetReporteCompra.ReporteCompraResumenDelDia);

            this.reportViewer1.RefreshReport();//actualiza los datos del reportviewer para mostrarlos nuevamente
        }
    }
}
