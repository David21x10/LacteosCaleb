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
    
    public partial class ReporteComprapormes : Form
    {
        private int mes; //variable para el parametro mes
        public ReporteComprapormes(int mes) // Define el constructor público de la clase ReporteComprapormes que toma un entero llamado mes como parámetro.
        {
            InitializeComponent();
            this.mes = mes; // Asigna el valor del parámetro mes al campo mes de la instancia actual de la clase. 'this.mes' se refiere a la variable de instancia de la clase, mientras que 'mes' es el parámetro pasado al constructor.
        }

        private void ReporteComprapormes_Load(object sender, EventArgs e)
        {
           //lineas de codigo para agregar opciones al comobox
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

            this.reporteCompraporMesTableAdapter.Fill(this.bD_LACTEOSCALEBDataSetReporteCompra.ReporteCompraporMes, mes);// llena la tabla reportecomprapormes con datos filtrados por mes
            this.reportViewer1.RefreshReport();// actualiza el reportviewer para mostrar el nuevo informe
        }

        private void cmbreporteFopciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mesSeleccionado = cmbreporteFopciones.SelectedItem.ToString();//variable que guarda el mes seleccionado

            switch (mesSeleccionado)//switch que tiene las opciones de los meses 
            {
                case "Enero":
                    mes = 1; // asigna 1 a la variable mes si el mes es enero
                    break; // termina el caso

                case "Febrero":
                    mes = 2; // asigna 2 a la variable mes si el mes es febrero
                    break; // termina el caso

                case "Marzo":
                    mes = 3; // asigna 3 a la variable mes si el mes es marzo
                    break; // termina el caso

                case "Abril":
                    mes = 4; // asigna 4 a la variable mes si el mes es abril
                    break; // termina el caso

                case "Mayo":
                    mes = 5; // asigna 5 a la variable mes si el mes es mayo
                    break; // termina el caso

                case "Junio":
                    mes = 6; // asigna 6 a la variable mes si el mes es junio
                    break; // termina el caso

                case "Julio":
                    mes = 7; // asigna 7 a la variable mes si el mes es julio
                    break; // termina el caso

                case "Agosto":
                    mes = 8; // asigna 8 a la variable mes si el mes es agosto
                    break; // termina el caso

                case "Septiembre":
                    mes = 9; // asigna 9 a la variable mes si el mes es septiembre
                    break; // termina el caso

                case "Octubre":
                    mes = 10; // asigna 10 a la variable mes si el mes es octubre
                    break; // termina el caso

                case "Noviembre":
                    mes = 11; // asigna 11 a la variable mes si el mes es noviembre
                    break; // termina el caso

                case "Diciembre":
                    mes = 12; // asigna 12 a la variable mes si el mes es diciembre
                    break; // termina el caso

                default:
                    MessageBox.Show("Mes seleccionado no válido"); // muestra un mensaje si el mes no es válido
                    return; // termina la ejecución del método

            }

            AsignarNuevomes(mes);//funcion que guarda el mes

        }

        public void AsignarNuevomes(int Mesnuevo)//funcion que guarda el mes seleccionado
        {
            this.mes = Mesnuevo;//

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reporteCompraporMesTableAdapter.Fill(this.bD_LACTEOSCALEBDataSetReporteCompra.ReporteCompraporMes, mes);// Llena la tabla reportecomprapormes con datos filtrados por mes
            this.reportViewer1.RefreshReport();// Actualiza el reportviewer para mostrar el nuevo informe
        }
    }
}
