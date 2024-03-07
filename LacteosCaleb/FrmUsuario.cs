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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LacteosCaleb
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

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
            comando.Parameters.AddWithValue("@vnomusu",txtUsuario.Text);
            comando.Parameters.AddWithValue("@vconusu", txtContrasena.Text);
            
            SqlDataReader lector= comando.ExecuteReader();

            if(lector.Read())
            {
                coneccion.Close();
                FrmMenu pantalla= new FrmMenu();
                pantalla.usrlabel.Text = this.txtUsuario.Text;
                pantalla.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Contraseña o Usuario invalido, intente denuevo.");
                coneccion.Close();

            }

            //

        }
        }
    }
 





       
    



