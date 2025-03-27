using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LacteosCaleb.Conexion;

namespace LacteosCaleb
{
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }
        Conexion Conex = new Conexion();//variable que guarda el llamado a la conexion
        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion grids y esta muestre los datos de la informacion de la tabla en la base de datos mediante una consulta en sql
            Conex.Grids("SELECT IdPrv as DNI, NomPrv as NOMBRE, CorPrv as CORREO, TelfPrv as TELEFONO FROM PROVEEDORES WHERE EstPrv = 1", dtgproovedores); 
            
        }

        public void MostrarUsuario(string usuario)
        {
            TxtUsuarioLabel.Text = usuario;//variable que grada el valor del label que tiene el nombre del usuario
        }

        private void txtbuscarproveedores_TextChanged(object sender, EventArgs e)
        {
            //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion buscar y esta muestre los datos de la informacion de la tabla en la base de datos cuando en la clausula like mediante la condicion PRODUCTO busque la informacion que coincida
            Conex.buscar("SELECT IdPrv as DNI, NomPrv as NOMBRE, CorPrv as CORREO, TelfPrv as TELEFONO FROM PROVEEDORES WHERE EstPrv = 1", dtgproovedores, "NOMBRE LIKE '%" + txtbuscarproveedores.Text + "%*' ");  
        }

        private void AÑADIR_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") //condicion que dice que si los textboxs estan vacios muestre un mensaje
            {
                MessageBox.Show("DEBE AGREGAR EL DNI o NOMBRE");//mensaje que dice que debe agregarse el nombre
            }
            else if (!Regex.IsMatch(textBox1.Text, @"^\d+$"))//condicion que hace que si el textbox de id tiene letras muestre un mensaje
            {
                MessageBox.Show("El DNI solo puede contener números.");//mensaje que muestra que el dni solo debe de tener numeros
            }
            else if (!Regex.IsMatch(textBox2.Text, @"^[a-zA-Z]+$"))// condicion que hace que si el nombre d tiene numeros muestre un mensaje
            {
                MessageBox.Show("El nombre solo puede contener letras.");//mensaje que muestra que el nombre solo debe de tener letras
            }
            else if (!Regex.IsMatch(textBox4.Text, @"^\d+$"))//condicion que dice que si el textbox de telefono tiene letras muestre un mensaje 
            {
                MessageBox.Show("El teléfono solo puede contener números.");//mensaje que muestra que el telefono solo aceppta numeros 
            }
            else
            {
            string id = textBox1.Text;//variable que guarda la informacion del textbox del id
                string nom = textBox2.Text;//variable que guarda la informacion del textbox de nombre de producto
                bool est = checkBox1.Checked = true;
            string correo = textBox3.Text;//variable que guarda la informacion del textbox de correo
                string telefono = textBox4.Text;//variable que guarda la informacion del textbox de telefono
                                                //5

                //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
                Conex.Modificaciones("exec Provagr '" + id + "', '" + nom + "', '" + est + "', '" + correo + "','" + telefono + "' ");
                   MessageBox.Show("Proveedor Registrado");//mensaje que confirma la accion

                //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion grids y esta muestre los datos de la informacion de la tabla en la base de datos mediante una consulta en sql
             Conex.Grids("SELECT IdPrv as DNI, NomPrv as NOMBRE, CorPrv as CORREO, TelfPrv as TELEFONO FROM PROVEEDORES WHERE EstPrv = 1", dtgproovedores);
            
                //limpia los textbox
                textBox1.Clear();
             textBox2.Clear();
             textBox3.Clear();
             textBox4.Clear();
            }

            

            DateTime fec;//variable tipo datetime
            fec = dateTimePicker1.Value;//variable que guarda la informacion del datetimepicker
            string acti = "Añadio en PROVEEDORES";// variable que guarda la accion para bitacora
            string usariolabel = TxtUsuarioLabel.Text;//variable que guarda el nombre del usuario

            //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
            Conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu FormularioNuevo = new FrmMenu();//accion que llama al formulario FrmMenu
            FormularioNuevo.MostrarUsuario(DatosUsuario.Usuario);// llama al método MostrarUsuario en la instancia FormularioNuevo, pasando como argumento el usuario almacenado en DatosUsuario.Usuario
            FormularioNuevo.Show();//muestra el formulario
            this.Hide();//oculta el formulario anterior 
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar el proveedor?", "PROVEEDOR ELIMINADO", MessageBoxButtons.YesNo) == DialogResult.Yes)//condicion que hace que si quiero elliminar pues que me de la opcion que si quiero o no y que si lo quiero hacer haga lo demas
            {
                string idprv = textBox1.Text;// variable que guarda la informacion del textbox del id de producto

                //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
                Conex.Modificaciones("exec eliminarproveedor '" + idprv + "'");
                MessageBox.Show("SE ELIMINÓ EL PROVEEDOR CON EXITO");//mensaje que confirma la accion

                //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion grids y esta muestre los datos de la informacion de la tabla en la base de datos mediante una consulta en sql
                Conex.Grids("SELECT IdPrv as DNI, NomPrv as NOMBRE, CorPrv as CORREO, TelfPrv as TELEFONO FROM PROVEEDORES WHERE EstPrv = 1", dtgproovedores);
               
                //Limpia los textbox
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                DateTime fec;//variable tipo datetime
                fec = dateTimePicker1.Value;// variable que guarda la informacion del datetimepicker
                string acti = "Eliminó en PROVEEDORES";// variable que guarda la accion para bitacora
                string usariolabel = TxtUsuarioLabel.Text;//variable que guarda el nombre del usuario

                //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
                Conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");




            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")//condicion que dice que si los textboxs estan vacios muestre un mensaje
            {
                MessageBox.Show("COMPLETE LOS DATOS EN BLANCO"); //mensaje que dice que debe agregarse el nombre
            }
            else if (!Regex.IsMatch(textBox1.Text, @"^\d+$"))//condicion que hace que si el textbox de id tiene letras muestre un mensaje
            {
                MessageBox.Show("El DNI solo puede contener números.");//mensaje que muestra que el dni solo debe de tener numeros
            }
            else if (!Regex.IsMatch(textBox2.Text, @"^[a-zA-Z]+$"))// condicion que hace que si el nombre d tiene numeros muestre un mensaje
            {
                MessageBox.Show("El nombre solo puede contener letras.");//mensaje que muestra que el nombre solo debe de tener letras
            }
            else if (!Regex.IsMatch(textBox4.Text, @"^\d+$"))//condicion que dice que si el textbox de telefono tiene letras muestre un mensaje 
            {
                MessageBox.Show("El teléfono solo puede contener números.");//mensaje que muestra que el telefono solo aceppta numeros
            }
            else
            {
                string id = textBox1.Text;//variable que guarda la informacion del textbox del id
                string nom = textBox2.Text;//variable que guarda la informacion del textbox del nombre
                bool est = checkBox1.Checked = true;
                string correo = textBox3.Text;//variable que guarda la informacion del textbox del correo
                string telefono = textBox4.Text;//variable que guarda la informacion del textbox del telefono
                                                //5

                //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
                Conex.Modificaciones("exec editarProveedor '" + id + "', '" + nom + "', '" + est + "', '" + correo + "','" + telefono + "' ");
                MessageBox.Show("Proveedor Editado");//mensaje que confirma la accion

                //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion grids y esta muestre los datos de la informacion de la tabla en la base de datos mediante una consulta en sql
                Conex.Grids("SELECT IdPrv as DNI, NomPrv as NOMBRE, CorPrv as CORREO, TelfPrv as TELEFONO FROM PROVEEDORES WHERE EstPrv = 1", dtgproovedores);
                
                //limpia los textboxs
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                DateTime fec;//variable tipo datetime
                fec = dateTimePicker1.Value;//variable que guarda la informacion del datetimepicker
                string acti = "Editó en PROVEEDORES";// variable que guarda la accion para bitacora
                string usariolabel = TxtUsuarioLabel.Text;//variable que guarda el nombre del usuario

                //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
                Conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");
            }
        }

        private void dtgproovedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtgproovedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dtgproovedores.CurrentRow.Cells[0].Value.ToString();//linea de codigo que hace que cuando de doble click a una posicion de la columna se guarde en el textbox
            textBox2.Text = dtgproovedores.CurrentRow.Cells[1].Value.ToString();//linea de codigo que hace que cuando de doble click a una posicion de la columna se guarde en el textbox
            textBox3.Text = dtgproovedores.CurrentRow.Cells[2].Value.ToString();//linea de codigo que hace que cuando de doble click a una posicion de la columna se guarde en el textbox
            textBox4.Text = dtgproovedores.CurrentRow.Cells[3].Value.ToString();//linea de codigo que hace que cuando de doble click a una posicion de la columna se guarde en el textbox

        }
    }
}
