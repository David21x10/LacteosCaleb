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
            FormularioNuevo.Show();
            this.Hide();

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            ;
            FrmPrincipal nuevoFormulario = new FrmPrincipal();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
           

            Conex.Grids("select * from FACTURAENCABEZADO", dataGridView2);
            Conex.Grids("select * from FACTURADETALLE",dataGridView1);
            
        }

        private void AÑADIR_Click(object sender, EventArgs e)
        {
            DateTime fec;

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
           
           
        }

        

        

        private void label7_Click(object sender, EventArgs e)
        {
            // if (MessageBox.Show("¿Deseas eliminar el dato de la factura?", "DATO ELIMINADO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            // {
            //int idc = int.Parse(txtfact.Text);


            //Conex.Modificaciones("exec BorrarFactura '" + idc + "' ");
            //MessageBox.Show("SE ELIMINÓ EL DATO CON EXITO");
            //Conex.Grids("SELECT * FROM FACTURADETALLE", dataGridView1);
     
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
               
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtfact.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                dateTimePicker1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txtUsuario.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txtDNI.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                checkBoxEstado.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {

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

            //fact det
            int idd = int.Parse(FactDet.Text);
            int prod = int.Parse(producttxt.Text);
            int cant = int.Parse(cantidadtxt.Text);
            int preci = int.Parse(preciotextbox.Text);
            


            Conex.Modificaciones("exec FacturaDet '" + idd + "', '" + prod + "', '" + cant + "', '" + preci + "' ");
            MessageBox.Show("Compra registrada con exito");
            Conex.Grids("SELECT * FROM FACTURADETALLE", dataGridView1);

        }
    }
    }
