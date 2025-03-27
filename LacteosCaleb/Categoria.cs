using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LacteosCaleb.Conexion;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LacteosCaleb
{
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }
        Conexion conex = new Conexion();//variable que guarda el llamado a la conexion
        private void Categoria_Load(object sender, EventArgs e)
        {
            //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion grids y esta muestre los datos de la informacion de la tabla en la base de datos
            conex.Grids("SELECT IdCat as CATEGORIA, NomCat as NOMBRE FROM CATEGORIAS", dtgcategoria);
        }
        public void MostrarUsuario(string usuario)//funcion que guarda la informacion mediante unavariable de la informacion del label del usuario
        {
            TxtUsuarioLabel.Text = usuario;//variable que guarda la informacion del textbox
        }

        private void txtbuscarcategoria_TextChanged(object sender, EventArgs e)
        {
            //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion buscar y esta muestre los datos de la informacion de la tabla en la base de datos cuando en la clausula like mediante la condicion NOMBRE busque la informacion que coincida
            conex.buscar("SELECT IdCat as CATEGORIA, NomCat as NOMBRE FROM CATEGORIAS", dtgcategoria, "NOMBRE LIKE '%" + txtbuscarcategoria.Text + "%*' ");
           
        }

        private void AÑADIR_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")// condicion que dice que si estos textbox estan vacios muestre un mensaje
            {
                MessageBox.Show("DEBE AGREGAR EL ID o NOMBRE");// mensaje que muestra que el id y nombre estan vacios y debe agregar
            }
            else if (!Regex.IsMatch(textBox1.Text, @"^\d+$"))//condicion que hace que si el textbox de id tiene letras muestre un mensaje
            {
                MessageBox.Show("El identificador de la CATEGORIA solo puede contener números.");//el id solo puede tener numeros
            }
            else if (!Regex.IsMatch(textBox2.Text, @"^[a-zA-Z]+$"))//condicion que hace que si el nombre de categoria tiene numeros muestre un mensaje
            {
                MessageBox.Show("El nombre de la CATEGORIA solo puede contener letras.");// el nombre solo debe de tener letras 
            }

            else
            {
                int id = int.Parse(textBox1.Text);//variable que guarda la informacion del id de categoria
                string nom = textBox2.Text;//variable que guarda la informacion del nombre de categoria

                //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
                conex.Modificaciones("exec CategoriaAgregada '" + id + "', '" + nom + "' ");
                MessageBox.Show("Categoria Registrada");//muestra que la accion fue realizada correctamente

                //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion grids y esta muestre los datos de la informacion de la tabla en la base de datos

                conex.Grids("SELECT IdCat as CATEGORIA, NomCat as NOMBRE FROM CATEGORIAS", dtgcategoria);
               
                //borra la informacion de los textbos de id y nombre
                textBox1.Clear();
                textBox2.Clear();
            }

            DateTime fec;//variable tipo datetime
            fec = dateTimePicker1.Value;//variable que guarda la informacion del datetimepicker
            string acti = "Añadio en CATEGORIA";//variable que guarda la accion para bitacora
            string usariolabel = TxtUsuarioLabel.Text;//variable que guarda el nombre del usuario

            //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
            conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu nuevoFormulario = new FrmMenu();// llamado a formulario menú mediante un botón
            nuevoFormulario.MostrarUsuario(DatosUsuario.Usuario);// variable que hace el llamado del nombre del usuario en el formulario de usuario que sea llamado en el form de Categoria
            nuevoFormulario.Show();//muestra el formulario
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar la CATEGORIA?", "CATEGORIA ELIMINADA", MessageBoxButtons.YesNo) == DialogResult.Yes)//condicion que hace que si quiero elliminar pues que me de la opcion que si quiero o no y que si lo quiero hacer haga lo demas 
            {
                string idcat = textBox1.Text;//variable que guarda el textbox que contiene el id de categoria

                //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
                conex.Modificaciones("exec eliminarcategoria '" + idcat + "'");
                MessageBox.Show("SE ELIMINÓ LA CATEGORIA CON EXITO"); //mensaje qie confirma la accion

                //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion grids y esta muestre los datos de la informacion de la tabla en la base de datos mediante una consulta en sql
                conex.Grids("SELECT IdCat as CATEGORIA, NomCat as NOMBRE FROM CATEGORIAS", dtgcategoria);
                
                //limpia los textbox
                textBox1.Clear();
                textBox2.Clear();
               
                DateTime fec;//variable tipo datetime
                fec = dateTimePicker1.Value;//variable que guarda la informacion del datetimepicker
                string acti = "Eliminó en CATEGORIA";// variable que guarda la accion para bitacora
                string usariolabel = TxtUsuarioLabel.Text;//variable que guarda el nombre del usuario

                //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
                conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");





            }
        }

        private void dtgcategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dtgcategoria_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgcategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dtgcategoria.CurrentRow.Cells[0].Value.ToString();//linea de codigo que hace que cuando de doble click a una posicion de la columna se guarde en el textbox
            textBox2.Text = dtgcategoria.CurrentRow.Cells[1].Value.ToString();//linea de codigo que hace que cuando de doble click a una posicion de la columna se guarde en el textbox
        }
    }
}
