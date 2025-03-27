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
    public partial class ReportePorCodigoCompras : Form
    {
        private int ide;// campo privado para almacenar el ID
        public ReportePorCodigoCompras(int ide )
        {
            InitializeComponent();// inicializa los componentes del formulario
            this.ide = ide;// asigna el valor del ID pasado al campo 'ide'
        }
        public void AsignarNuevoValor(int DNInuevo)//funcion publica que contiene el DNI
        {
            this.ide = DNInuevo;// asigna un nuevo valor al campo 'ide'
        }
        private void ReportePorCodigoCompras_Load(object sender, EventArgs e)
        {
            // llena el adaptador de tabla con los datos del reporte basado en el ID
            this.reporteCompraTableAdapter.Fill(this.bD_LACTEOSCALEBDataSetReporteCompra.ReporteCompra, ide);
            this.reportViewer1.RefreshReport();// refresca el informe para mostrar los datos actualizados
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            // intenta convertir el texto ingresado en el campo de texto a un entero
            if (int.TryParse(txtDNI.Text, out int nuevoValor))
            {

                AsignarNuevoValor(nuevoValor);// asigna el nuevo valor convertido al campo 'ide'
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // llena el adaptador de tabla con los datos del reporte basado en el ID
            this.reporteCompraTableAdapter.Fill(this.bD_LACTEOSCALEBDataSetReporteCompra.ReporteCompra, ide);
            this.reportViewer1.RefreshReport();//refresca el reporte
        }
    }
}
