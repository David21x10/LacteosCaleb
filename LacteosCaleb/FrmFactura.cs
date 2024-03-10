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
    public partial class FrmFactura : Form

    {
        private BindingSource bindingSource1 = new BindingSource();
        public FrmFactura()
        {
            InitializeComponent();

        }

        
        SqlConnection haja = new SqlConnection("Data Source=DESKTOP-09GMK57\\SQLEXPRESS;Initial Catalog=BD_LACTEOSCALEB; Integrated Security=true ");
        Conexion Conex = new Conexion();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu FormularioNuevo = new FrmMenu();
            FormularioNuevo.MostrarUsuario(DatosUsuario.Usuario);
            FormularioNuevo.Show();
            this.Hide();

        }

        public void MostrarUsuario(string usuario)
        {
            txtUsuario.Text = usuario; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            autonum();
            


            //   Conex.Grids("select * from FACTURADETALLE",dataGridView1);

        }

        private void AÑADIR_Click(object sender, EventArgs e)
        {

            double linea = int.Parse(preciotextbox.Text) * int.Parse(cantidadtxt.Text);
            dataGridView1.Rows.Add(IdProdTxt.Text, producttxt.Text, cantidadtxt.Text, preciotextbox.Text, linea);
            
            IdProdTxt.Clear();
            IdProdTxt.Focus();
            producttxt.Clear();
            cantidadtxt.Clear();
            preciotextbox.Clear();

            calcular();
            // Obtener el valor de la primera columna del DataGridView (IdFacEn)
            // string idFacEn = dataGridView1.Rows[0].Cells[0].Value.ToString(); // Suponiendo que el IdFacEn está en la primera columna

            // Obtener otros datos de los TextBox
            //fec = dateTimePicker1.Value;
            //string nom = txtUsuario.Text;
            //bool est = checkBoxEstado.Checked;
            //string dni = txtDNI.Text;

            // Guardar los datos en la tabla FACTURAENCABEZADO
            // string cadenaConexion = "Data Source=DESKTOP-09GMK57\\SQLEXPRESS;Initial Catalog=BD_LACTEOSCALEB; Integrated Security=true ";
            //using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            //{
            //conexion.Open();

            //string consulta = "INSERT INTO FACTURAENCABEZADO (IdFactEn, FecFacEn, NomUsu, EstFacEn, DNI) VALUES (@IdFacEnc, @Fec, @Nom, @Est, @Dni)";
            //using (SqlCommand comando = new SqlCommand(consulta, conexion))
            // {
            // comando.Parameters.AddWithValue("@IdFacEnc", idFacEn);
            // comando.Parameters.AddWithValue("@Fec", fec);
            //comando.Parameters.AddWithValue("@Nom", nom);
            // comando.Parameters.AddWithValue("@Est", est);
            //comando.Parameters.AddWithValue("Dni", dni);

            // comando.ExecuteNonQuery();
            // }

            // }


            // MessageBox.Show("Datos guardados correctamente en FACTURAENCABEZADO");

            DateTime fec;
            fec = dateTimePicker1.Value;
            string acti = "Añadio en FACTURA";
            string usariolabel = txtUsuario.Text;
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

            // Ahora puedes mostrar el resultado en un TextBox u otro lugar
            RPARCIAL.Text = total.ToString();
            RIVA.Text = (total * 0.15).ToString();
            RPAGAR.Text = (total + Convert.ToDouble(RIVA.Text)).ToString();
        }
        
     
        

        private void label7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            calcular();

            DateTime fec;
            fec = dateTimePicker1.Value;
            string acti = "Borró en FACTURA";
            string usariolabel = txtUsuario.Text;
            Conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  
        }

        private void autonum()
        {
             string servidor = "DESKTOP-09GMK57\\SQLEXPRESS";
            //string servidor = "VIERNES\\VIERNES";
            string strConn = "Data Source=" + servidor + "; Initial Catalog=BD_LACTEOSCALEB; Integrated Security=true";
            SqlConnection conn = new SqlConnection(strConn);
            string query = "SELECT MAX(IdFactEn) FROM FACTURAENCABEZADO";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            object result = cmd.ExecuteScalar();
            conn.Close();
            int maxId;
            // Verifica si el resultado no es nulo antes de asignarlo al TextBox
            if (result != DBNull.Value)
            {
                maxId = (Convert.ToInt32(result)+ 1);
                txtfact.Text = maxId.ToString();
            }
            else
            {
                // Maneja el caso en que no hay registros en la tabla
               maxId = 0;
                txtfact.Text = maxId.ToString();
            }
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
                RPARCIAL.Text = sumaParcial.ToString(); 
              
                
                
               
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
            DateTime fec;
            //fact encabezado
            int ide = int.Parse(txtfact.Text);
            fec = dateTimePicker1.Value;
            string usua= txtUsuario.Text;
            string Dni = txtDNI.Text;
           bool est= checkBoxEstado.Checked;



            Conex.Modificaciones("exec Facturadist '" + ide + "', '" + fec + "', '" + usua + "','" + Dni+ "', '" + est + "'  ");
            
            string acti = "Pagó en FACTURA";
            string usariolabel = txtUsuario.Text;
            Conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");
            //fact det


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    int idd = Convert.ToInt32(row.Cells[0].Value); 
                    int cant = Convert.ToInt32(row.Cells[3].Value);
                    int preci = Convert.ToInt32(row.Cells[4].Value);
                    Conex.Modificaciones("exec FacturaDet '" + ide + "', '" + idd + "', '" + cant + "', '" + preci + "' ");
                    dataGridView1.Rows.Clear();
                }
            }

            autonum();
            MessageBox.Show("Factura registrada con exito");

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Conex.Grids("select IdPro as Codigo, NomPro as Producto,PrePro as Precio from PRODUCTOS", dataGridView2);
            dataGridView2.Columns[0].Width = 60;
            dataGridView2.Columns[2].Width = 70;
            dataGridView2.Visible = true;
        }
       
        private void DataGridView2_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            IdProdTxt.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            producttxt.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            preciotextbox.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            dataGridView2.Visible = false;
        }

        private void txtfact_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conex.Grids("select DNI  as DNI, NomCli as Nombre , TelCli as Telefono from CLIENTE", dataGridView3);
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
        

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDNI.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            dataGridView3.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
