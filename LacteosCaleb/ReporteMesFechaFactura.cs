using Microsoft.Reporting.WinForms;
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

    public partial class ReporteMesFechaFactura : Form
    {
        

        private int mes;// campo privado para almacenar el mes seleccionado


        public ReporteMesFechaFactura(int mes)
        {
            
            InitializeComponent();// inicializa los componentes del formulario
            this.mes = mes;// asigna el valor del mes pasado al campo 'mes'
        }  

       
        private void ReporteMesFechaFactura_Load(object sender, EventArgs e)
        {
            // añade los nombres de los meses al combo box 'cmbreporteFopciones'
            cmbreporteFopciones.Items.Add("Enero");
            cmbreporteFopciones.Items.Add("Febrero");
            cmbreporteFopciones.Items.Add("Marzo");
            cmbreporteFopciones.Items.Add("Abril");
            cmbreporteFopciones.Items.Add("Mayo");
            cmbreporteFopciones.Items.Add("Junio");
            cmbreporteFopciones.Items.Add("Julio");
            cmbreporteFopciones.Items.Add("Agosto");
            cmbreporteFopciones.Items.Add("Septiembre");
            cmbreporteFopciones.Items.Add("Octubre");
            cmbreporteFopciones.Items.Add("Noviembre");
            cmbreporteFopciones.Items.Add("Diciembre");

            // llena el adaptador de tabla con los datos del reporte basado en el mes
            this.fechaReporteFacturaTableAdapter.Fill(this.bD_LACTEOSCALEBDataSetReporteFactura.FechaReporteFactura, mes);
            this.reportViewer1.RefreshReport();// refresca el informe para mostrar los datos actualizados
        }

        private void cmbreporteFopciones_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            string mesSeleccionado = cmbreporteFopciones.SelectedItem.ToString();// obtiene el mes seleccionado en el combo box

            switch (mesSeleccionado)
            {
                case "Enero":
                    mes = 1;// asigna el valor 1 a 'mes' si el mes seleccionado es Enero

                    break;
                case "Febrero":
                    mes = 2;// asigna el valor 2 a 'mes' si el mes seleccionado es Febrero

                    break;
                case "Marzo":
                    mes = 3;// asigna el valor 3 a 'mes' si el mes seleccionado es Marzo

                    break;
                case "Abril":
                    mes = 4;// asigna el valor 4 a 'mes' si el mes seleccionado es Abril

                    break;
                case "Mayo":
                    mes = 5;// asigna el valor 5 a 'mes' si el mes seleccionado es Mayo
                    break;

                case "Junio":
                    mes = 6;// asigna el valor 6 a 'mes' si el mes seleccionado es Junio

                    break;

                case "Julio":
                    mes = 7;// asigna el valor 7 a 'mes' si el mes seleccionado es Julio

                    break;

                case "Agosto":
                    mes = 8;// asigna el valor 8 a 'mes' si el mes seleccionado es Agosto

                    break;

                case "Septiembre":
                    mes = 9;// asigna el valor 9 a 'mes' si el mes seleccionado es Septiembre

                    break;

                case "Octubre":
                    mes = 10;// asigna el valor 10 a 'mes' si el mes seleccionado es Octubre

                    break;

                case "Noviembre":
                    mes = 11;// asigna el valor 11 a 'mes' si el mes seleccionado es Noviembre

                    break;

                case "Diciembre":
                    mes = 12;// asigna el valor 12 a 'mes' si el mes seleccionado es Diciembre

                    break;

                default:

                    MessageBox.Show("Mes seleccionado no válido");// muestra un mensaje si el mes seleccionado no es válido
                    return;
            }

            AsignarNuevomes(mes);// asigna el nuevo mes seleccionado

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // llena el adaptador de tabla con los datos del reporte basado en el mes
            this.fechaReporteFacturaTableAdapter.Fill(this.bD_LACTEOSCALEBDataSetReporteFactura.FechaReporteFactura, mes);
            this.reportViewer1.RefreshReport();//refresca el reporte

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void AsignarNuevomes(int Mesnuevo)
        {
            this.mes = Mesnuevo;// asigna un nuevo valor al campo 'mes'

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }





    
}


