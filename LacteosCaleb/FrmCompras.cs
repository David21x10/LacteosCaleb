using LacteosCaleb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static LacteosCaleb.Conexion;
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
            autonum();
        }
        public void MostrarUsuario(string usuario)
        {
            TxtUsuarioLabel.Text = usuario;
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

        }

        private void AÑADIR_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmMenu FormularioNuevo = new FrmMenu();
            FormularioNuevo.MostrarUsuario(DatosUsuario.Usuario);
            FormularioNuevo.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conex.Grids("select IdPro as Codigo, NomPro as Producto,PrePro as Precio from PRODUCTOS", dataGridView2);
            dataGridView2.Columns[0].Width = 60;
            dataGridView2.Columns[2].Width = 70;
            dataGridView2.Visible = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void autonum()
        {
            string servidor = "DESKTOP-09GMK57\\SQLEXPRESS";
            //string servidor = "VIERNES\\VIERNES";
            string strConn = "Data Source=" + servidor + "; Initial Catalog=BD_LACTEOSCALEB; Integrated Security=true";
            SqlConnection conn = new SqlConnection(strConn);
            string query = "SELECT MAX(IdComp) FROM COMPRAENCABEZADO";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            object result = cmd.ExecuteScalar();
            conn.Close();
            int maxId;
            // Verifica si el resultado no es nulo antes de asignarlo al TextBox
            if (result != DBNull.Value)
            {
                maxId = (Convert.ToInt32(result) + 1);
                txtCompra.Text = maxId.ToString();
            }
            else
            {
                // Maneja el caso en que no hay registros en la tabla
                maxId = 0;
                txtCompra.Text = maxId.ToString();
            }
        }

        private void AÑADIR_Click_1(object sender, EventArgs e)
        {
            double linea = int.Parse(preciotextbox.Text) * int.Parse(cantidadtxt.Text);
            dataGridView1.Rows.Add(IdProdTxt.Text, producttxt.Text, cantidadtxt.Text, preciotextbox.Text, linea);

            IdProdTxt.Clear();
            IdProdTxt.Focus();
            producttxt.Clear();
            cantidadtxt.Clear();
            preciotextbox.Clear();

            calcular();

            DateTime fec;
            fec = dateTimePicker1.Value;
            string acti = "Añadio en FACTURA";
            string usariolabel = TxtUsuarioLabel.Text;
            Conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            calcular();

            DateTime fec;
            fec = dateTimePicker1.Value;
            string acti = "Borró en FACTURA";
            string usariolabel = TxtUsuarioLabel.Text;
            Conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");
        }
        private void calcular()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    total += Convert.ToInt32(row.Cells[4].Value);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            DateTime fec;
            //comp encabezado
            int ide = int.Parse(txtCompra.Text);
            fec = dateTimePicker1.Value;
            string prov = txtprovedorr.Text;



            Conex.Modificaciones("exec comdetal '" + ide + "', '" + fec + "', '" + prov + "' ");
            DateTime feca;
            feca = dateTimePicker1.Value;
            string acti = "Pagó en FACTURA";
            string usariolabel = TxtUsuarioLabel.Text;
            Conex.Modificaciones("exec IngresarBitacora '" + feca + "', '" + usariolabel + "', '" + acti + "'");

            //fact det


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    int idd = Convert.ToInt32(row.Cells[0].Value);
                    int cant = Convert.ToInt32(row.Cells[3].Value);
                    int preci = Convert.ToInt32(row.Cells[4].Value);
                    Conex.Modificaciones("exec InsertCompraDetalle '" + ide + "', '" + idd + "', '" + cant + "', '" + preci + "' ");
                    dataGridView1.Rows.Clear();

                }
            }
            autonum();
            MessageBox.Show("Compra registrada con exito");
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                int fila = e.RowIndex;
                decimal valor1 = Convert.ToDecimal(dataGridView1.Rows[fila].Cells[2].Value);
                decimal valor2 = Convert.ToDecimal(dataGridView1.Rows[fila].Cells[3].Value);
                decimal resultado = valor1 * valor2;
                dataGridView1.Rows[fila].Cells[4].Value = resultado;


                decimal sumaParcial = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[4].Value != null)
                    {
                        sumaParcial += Convert.ToDecimal(row.Cells[4].Value);
                    }
                }
                //RPARCIAL.Text = sumaParcial.ToString();




            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdProdTxt.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            producttxt.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            preciotextbox.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            dataGridView2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conex.Grids("select IdPrv  as DNI, NomPrv as Nombre , TelfPrv as Telefono from PROVEEDORES", dataGridView3);
            dataGridView3.Columns[0].Width = 60;
            dataGridView3.Columns[2].Width = 70;

            if (dataGridView3.Visible)
            {
               
                dataGridView3.Hide();
            }
            else
            {
                
                dataGridView3.Show();
            }



        }

        private void dataGridView3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtprovedorr.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            dataGridView3.Visible = false;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
