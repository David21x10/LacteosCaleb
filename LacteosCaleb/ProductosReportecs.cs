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
    public partial class ProductosReportecs : Form
    {
        public ProductosReportecs()
        {
            InitializeComponent();
        }

        private void ProductosReportecs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_LACTEOSCALEBDataSetProductosmasvendidos.Productosmenosvendido' Puede moverla o quitarla según sea necesario.
            this.productosmenosvendidoTableAdapter.Fill(this.bD_LACTEOSCALEBDataSetProductosmasvendidos.Productosmenosvendido);
            // TODO: esta línea de código carga datos en la tabla 'bD_LACTEOSCALEBDataSetProductosmasvendidos.Productosmasvendido' Puede moverla o quitarla según sea necesario.
            this.productosmasvendidoTableAdapter.Fill(this.bD_LACTEOSCALEBDataSetProductosmasvendidos.Productosmasvendido);


            this.reportViewer1.RefreshReport();//reinicia la herramienta reportviewer, la refresca
        }
    }
}
