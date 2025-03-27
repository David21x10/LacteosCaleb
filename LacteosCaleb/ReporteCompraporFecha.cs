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
    public partial class ReporteCompraporFecha : Form
    {
        private DateTime fec;// declara un campo privado de tipo DateTime llamado fec
        public ReporteCompraporFecha(DateTime fec)// constructor de la clase ReporteCompraporFecha que recibe un parámetro fec
        {
            InitializeComponent();
            this.fec = fec;// asigna el valor del parámetro fec al campo fec de la clase
        }

        private void ReporteCompraporFecha_Load(object sender, EventArgs e)
        {
            // llena el dataset de reporteCompraporFecha con los datos de la tabla ReporteCompraporFecha filtrando por el valor de fec
            this.reporteCompraporFechaTableAdapter.Fill(this.bD_LACTEOSCALEBDataSetReporteCompra.ReporteCompraporFecha, fec);
            this.reportViewer1.RefreshReport();//refresca la herramienta de reportviewer y actualiza
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParse(dateTimePicker1.Text, out DateTime nuevaFecha))// intenta convertir el texto del dateTimePicker1 a DateTime
            {
                AsignarNuevaFecha(nuevaFecha);// si la conversión es exitosa, llama al método AsignarNuevaFecha con la nueva fecha
            }
        }
        public void AsignarNuevaFecha(DateTime nuevaFecha)// método público que asigna una nueva fecha al campo fec
        {
            this.fec = nuevaFecha;// asigna la nueva fecha al campo fec
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // llena el dataset de reporteCompraporFecha con los datos de la tabla ReporteCompraporFecha filtrando por el valor de fec
            this.reporteCompraporFechaTableAdapter.Fill(this.bD_LACTEOSCALEBDataSetReporteCompra.ReporteCompraporFecha, fec);
            this.reportViewer1.RefreshReport();//refresca la herramienta de reportviewer y actualiza
        }
    }
    
}

