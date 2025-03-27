using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static LacteosCaleb.Conexion;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LacteosCaleb
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        Conexion conex=new Conexion(); //variable que guarda el llamado a la conexion
        private void AÑADIR_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")// condicion que muestra que si tiene espacios en blanco en los textbox marcara un mensaje
            {
                MessageBox.Show("TIENE DATOS INCOMPLETOS");//mensaje que dice que hay campos incompletos
            }
            else
            {
                string usuario = textBox1.Text;//variable que guarda la informacion del textbox del usuario
                string contrasena = textBox2.Text;//variable que guarda la informacion del textbox de la contraseña
                string rol = textBox3.Text;//variable que guarda la informacion del textbox del rol
                bool est = true; 

                
                if (rol.ToLower() == "administrador") //verifica si el rol en minúsculas es igual a "administrador"
                {
                    //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
                    conex.Modificaciones("exec anadirusuario '" + usuario + "', '" + contrasena + "', '" + rol + "',  '" + est + "'");
                    MessageBox.Show("SE AÑADIÓ CORRECTAMENTE");//mensaje que confirma que se realizó la acción


                    //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion grids y esta muestre los datos de la informacion de la tabla en la base de datos mediante una consulta en sql
                    conex.Grids("SELECT NomUsu as USUARIO, RolUsu as ROL From USUARIOS WHERE EstUsu = 1 ", dtgusuario);
                    
                    //limpia los textbox
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else
                {
                    
                    MessageBox.Show("El rol solo acepta 'administrador'");//mensaje que hace que si la condicion no se cumple muestre que administrador solo acepte mayusculas
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "") // condicion que muestra que si tiene espacios en blanco en los textbox marcara un mensaje
            {
                MessageBox.Show("TIENE DATOS INCOMPLETOS");//mensaje que dice que hay campos incompletos
            }
            else
            {
                string usuario = textBox1.Text; //variable que guarda la informacion del textbox del usuario
                string contrasena = textBox2.Text; //variable que guarda la informacion del textbox de la contraseña
                string rol = textBox3.Text; //variable que guarda la informacion del textbox del rol
                bool est = true;


                if (rol.ToLower() == "administrador") //verifica si el rol en minúsculas es igual a "administrador"
                {
                    //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
                    conex.Modificaciones("exec editarusuario '" + usuario + "', '" + contrasena + "', '" + rol + "',  '" + est + "'");
                    MessageBox.Show("SE EDITÓ CORRECTAMENTE");//mensaje que confirma la accion

                    //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion grids y esta muestre los datos de la informacion de la tabla en la base de datos mediante una consulta en sql
                    conex.Grids("SELECT NomUsu as USUARIO, RolUsu as ROL From USUARIOS WHERE EstUsu = 1 ", dtgusuario);
                    
                    //limpia los textboxs
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else
                {

                    MessageBox.Show("El rol solo acepta 'administrador'"); //mensaje que hace que si la condicion no se cumple muestre que administrador solo acepte mayusculas
                }
            }

            


        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""  || textBox3.Text == "") // condicion que muestra que si tiene espacios en blanco en los textbox marcara un mensaje
            {
                MessageBox.Show("TIENE DATOS INCOMPLETOS"); //mensaje que dice que hay campos incompletos
            }
            else
            {
                if (MessageBox.Show("¿Deseas eliminar este usuario?", "ELIMINACIÓN COMPLETADA CON EXITO", MessageBoxButtons.YesNo) == DialogResult.Yes)// mensaje que muestra que si acepto eliminar se ejecute el proc almacenado y demas
                {
                    string usuario = textBox1.Text;//variable que guarda la informacion del textbox de usuario

                    //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
                    conex.Modificaciones("exec eliminarusuario '" + usuario + "'");
                    MessageBox.Show("SE ELIMINÓ CON EXITO");//mensaje que confirma la acciom

                }
                //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion grids y esta muestre los datos de la informacion de la tabla en la base de datos mediante una consulta en sql
                conex.Grids("SELECT NomUsu as USUARIO,  RolUsu as ROL From USUARIOS WHERE EstUsu = 1 ", dtgusuario);
               
                //limpia los textbox
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu nuevoFormulario = new FrmMenu();// llamado a formulario menú mediante un botón
            nuevoFormulario.MostrarUsuario(DatosUsuario.Usuario);//// variable que hace el llamado del nombre del usuario en el formulario de usuario que sea llamado en el form de Bitacora
            nuevoFormulario.Show();//muestra el formulario
            this.Hide();
        }

        private void UsuariosVer_Load(object sender, EventArgs e)
        {
            //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion grids y esta muestre los datos de la informacion de la tabla en la base de datos mediante una consulta en sql
            conex.Grids("SELECT NomUsu as USUARIO, RolUsu as ROL From USUARIOS WHERE EstUsu = 1 ", dtgusuario);
        }

        private void txtbuscarusuario_TextChanged(object sender, EventArgs e)
        {
            //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion buscar y esta muestre los datos de la informacion de la tabla en la base de datos cuando en la clausula like mediante la condicion USUARIO busque la informacion que coincida
            conex.buscar("SELECT NomUsu as USUARIO,  RolUsu as ROL From USUARIOS WHERE EstUsu = 1 ", dtgusuario, "USUARIO LIKE '%" + txtbuscarusuario.Text + "%*' ");
        }

        private void dtgusuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dtgusuario.CurrentRow.Cells[0].Value.ToString();//linea de codigo que hace que cuando de doble click a una posicion de la columna se guarde en el textbox
           // textBox2.Text = dtgusuario.CurrentRow.Cells[0].Value.ToString();//linea de codigo que hace que cuando de doble click a una posicion de la columna se guarde en el textbox
            textBox3.Text = dtgusuario.CurrentRow.Cells[1].Value.ToString();//linea de codigo que hace que cuando de doble click a una posicion de la columna se guarde en el textbox
        }
    }
}
