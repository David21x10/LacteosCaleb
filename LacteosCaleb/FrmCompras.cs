using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LacteosCaleb
{
    public partial class FrmCompras : Form
    {
        public FrmCompras()
        {
            InitializeComponent();
        }
        Conexion Conex = new Conexion();
        private void FrmCompras_Load(object sender, EventArgs e)
        {
            //Conex.Grids("select * from FACTURAENCABEZADO", dataGridView1);
            Conex.Grids("select * from COMPRADETALLE", dtgCompra);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu nuevoFormulario = new FrmMenu();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtgCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCantidad.Text = dtgCompra.CurrentRow.Cells[0].Value.ToString();
                txtPrecio.Text = dtgCompra.CurrentRow.Cells[1].Value.ToString();
                checkest.Text = dtgCompra.CurrentRow.Cells[2].Value.ToString();
                txtProducto.Text = dtgCompra.CurrentRow.Cells[3].Value.ToString();
                textBoxcompra2.Text = dtgCompra.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void AÑADIR_Click(object sender, EventArgs e)
        {
            DateTime fec;
            //Compra encabezado
            int idComp = int.Parse(txtCompra.Text);
            fec = dateTimePicker1.Value;
            string prov = txtProveedor.Text;



            Conex.Modificaciones("exec comdetal '" + idComp + "', '" + fec + "', '" + prov + "' ");

            //Compradetalle
            int cant = int.Parse(txtCantidad.Text);
            int preci = int.Parse(txtPrecio.Text);
            bool est = checkest.Checked;
            int product = int.Parse(txtProducto.Text);
            int idcom2 = int.Parse(textBoxcompra2.Text);


            Conex.Modificaciones("exec CompraDet '" + cant + "', '" + preci + "', '" + est + "', '" + product + "','" + idcom2 + "' ");
            MessageBox.Show("Compra registrada con exito");
            Conex.Grids("SELECT * FROM COMPRADETALLE", dtgCompra);
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmMenu FormularioNuevo = new FrmMenu();
            FormularioNuevo.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar el dato de la compra?", "DATO ELIMINADO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id1 = int.Parse(txtCompra.Text);


                Conex.Modificaciones("exec BorrarCompra '" + id1 + "' ");
                MessageBox.Show("SE ELIMINÓ EL DATO CON EXITO");
                Conex.Grids("SELECT * FROM COMPRADETALLE", dtgCompra);
                
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            txtCompra.Clear();
            txtProveedor.Clear();

            textBoxcompra2.Clear();
            txtProducto.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
        }
    }
}
