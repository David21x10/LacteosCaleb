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

        string servidor = "localhost";
        // crea una conexión a SQL Server en el servidor DESKTOP-09GMK57\SQLEXPRESS, usando la base de datos BD_LACTEOSCALEB y seguridad integrada de Windows
        SqlConnection coneccion = new SqlConnection("Server=localhost,1433; database=BD_LACTEOSCALEB; INTEGRATED SECURITY= true");
        private void button1_Click(object sender, EventArgs e)
        {
          
     
           


            //login
         coneccion.Open(); // abre la conexión a la base de datos

            // crea un nuevo comando sql para seleccionar el nombre de usuario y la contraseña de la tabla USUARIOS donde coincidan con los parámetros proporcionados
            SqlCommand comando = new SqlCommand("SELECT NomUsu, ConUsu FROM USUARIOS WHERE NomUsu= @vnomusu AND ConUsu= @vconusu", coneccion);
            
            
            comando.Parameters.AddWithValue("@vnomusu",txtUsur.Text); // añade el valor del cuadro de texto txtUsur como parámetro @vnomusu
            comando.Parameters.AddWithValue("@vconusu", txtContrasena.Text);// añade el valor del cuadro de texto txtContrasena como parámetro @vconusu

            SqlDataReader lector= comando.ExecuteReader(); // ejecuta el comando y obtiene un SqlDataReader para leer los resultados

            if (lector.Read()) // si se puede leer un registro del lector (lo que indica que el usuario existe)
            {
                coneccion.Close();// cierra la conexión a la base de datos
                FrmMenu pantalla= new FrmMenu();// crea una nueva instancia de la clase FrmMenu
                FrmFactura verusuario= new FrmFactura();// crea una nueva instancia de la clase FrmFactura
                pantalla.usrlabel.Text = this.txtUsur.Text;// establece el texto del label usrlabel en FrmMenu con el texto del cuadro de texto txtUsur
                verusuario.txtUsuario.Text= this.txtUsur.Text; // establece el texto del cuadro de texto txtUsuario en FrmFactura con el texto del cuadro de texto txtUsur
                DatosUsuario.Usuario = txtUsur.Text; // asigna el valor de txtUsur al atributo Usuario de la clase DatosUsuario
                MessageBox.Show("¡Bienvenido al sistema!", txtUsur.Text);
                pantalla.Show();// muestra la pantalla FrmMenu
                this.Hide();// oculta la ventana actual


            }
            else
            {
                MessageBox.Show("Contraseña o Usuario invalido, intente denuevo."); // muestra un mensaje indicando que la contraseña o el usuario son inválidos
                coneccion.Close();//cierra la conexion con la bd

            }

            //
            DateTime fec;//variable tipo datetime
            fec = dateTimePicker1.Value;//variable que guarda la informacion del datetimepicker
            string acti = "Ingresó al Sistema";// variable que guarda la accion para bitacora
            string usariolabel = txtUsur.Text;//variable que guarda el nombre del usuario

            //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
            conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }
 





       
    



