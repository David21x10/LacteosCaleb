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
    public partial class ReporteconCodigo : Form
    {
        private int ide;//variable que guarda el id factura
        public ReporteconCodigo(int ide)
        {
            InitializeComponent();
            this.ide = ide;// Asigna el valor de ide al campo de la clase
        }

        private void ReporteconCodigo_Load(object sender, EventArgs e)
        {
            this.reporteFacturaTableAdapter.Fill(this.bD_LACTEOSCALEBDataSetReporteFactura.ReporteFactura, ide);// Llena la tabla reportefactura con datos filtrados por ide
            this.reportViewer1.RefreshReport();// Actualiza el reportviewer para mostrar el nuevo informe
        }

        public void AsignarNuevoValor(int DNInuevo)//funcion que guarda  la variable del id factura
        {
            this.ide = DNInuevo;//se guarda
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(txtDNI.Text, out int nuevoValor))// Intenta convertir el texto de txtDNI a un entero y lo guarda en nuevoValor
            {
                
                AsignarNuevoValor(nuevoValor);// Llama a la función AsignarNuevoValor con el nuevoValor como argumento
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.reporteFacturaTableAdapter.Fill(this.bD_LACTEOSCALEBDataSetReporteFactura.ReporteFactura, ide);// Llena la tabla reportefactura con datos filtrados por ide
            this.reportViewer1.RefreshReport();// Actualiza el reportviewer para mostrar el nuevo informe




        }
    }
}
