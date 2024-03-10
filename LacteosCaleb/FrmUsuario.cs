using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LacteosCaleb.Conexion;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LacteosCaleb
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }
        Conexion conex = new Conexion();

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        SqlConnection coneccion = new SqlConnection("Server=DESKTOP-09GMK57\\SQLEXPRESS; database=BD_LACTEOSCALEB; INTEGRATED SECURITY= true");
        private void button1_Click(object sender, EventArgs e)
        {
          
     
           


            //login
         coneccion.Open();
            SqlCommand comando = new SqlCommand("SELECT NomUsu, ConUsu FROM USUARIOS WHERE NomUsu= @vnomusu AND ConUsu= @vconusu", coneccion);
            comando.Parameters.AddWithValue("@vnomusu",txtUsur.Text);
            comando.Parameters.AddWithValue("@vconusu", txtContrasena.Text);
            
            SqlDataReader lector= comando.ExecuteReader();

            if(lector.Read())
            {
                coneccion.Close();
                FrmMenu pantalla= new FrmMenu();
                FrmFactura verusuario= new FrmFactura();
                pantalla.usrlabel.Text = this.txtUsur.Text;
                verusuario.txtUsuario.Text= this.txtUsur.Text;
                DatosUsuario.Usuario = txtUsur.Text;
                pantalla.Show();
                

                

                this.Hide();


            }
            else
            {
                MessageBox.Show("Contraseña o Usuario invalido, intente denuevo.");
                coneccion.Close();

            }

            //
            DateTime fec;
            fec = dateTimePicker1.Value;
            string acti = "Ingresó al Sistema";
            string usariolabel = txtUsur.Text;
            conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }
 





       
    



