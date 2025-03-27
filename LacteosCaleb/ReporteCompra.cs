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
    public partial class ReporteCompra : Form
    {
        private int ide;//variable que guarda el idcompra
        public ReporteCompra(int ide)// Constructor de la clase ReporteCompra que recibe un parámetro ide

        {
            this.ide = ide;// Asigna el valor del parámetro ide al campo ide de la clase
            InitializeComponent();
        }

        private void ReporteCompra_Load(object sender, EventArgs e)
        {
            // Llena el dataset de reporteCompra con los datos de la tabla ReporteCompra filtrando por el valor de ide
            this.reporteCompraTableAdapter.Fill(this.bD_LACTEOSCALEBDataSetReporteCompra.ReporteCompra, ide);
            this.reportViewer1.RefreshReport();//refresca la herramienta de reportviewer
           
        }
    }
}
