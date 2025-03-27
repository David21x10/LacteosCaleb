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

namespace LacteosCaleb
{
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
        }

        public void MostrarUsuario(string usuario)
        {
            TxtUsuarioLabel.Text = usuario;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu nuevoFormulario = new FrmMenu();// llamado a formulario menú mediante un botón
            nuevoFormulario.Show();//llama al formularip
            this.Hide();

        }
        Conexion conex = new Conexion();//variable que guarda el llamado a la conexion
        private void FrmInventario_Load(object sender, EventArgs e)
        {
            //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion grids y esta muestre los datos de la informacion de la tabla en la base de datos mediante una consulta en sql
            conex.Grids("SELECT IdPro as IDENTIFICADOR, NomPro as PRODUCTO, DesPro as DESCRIPCION, PrePro as PRECIO, IdCat as CATEGORIA, ExisPro as EXISTENCIA FROM PRODUCTOS WHERE EstPro = 1 ", dtginvent);
        }

        private void AÑADIR_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox6.Text == "") //condicion que dice que si los textboxs estan vacios muestre un mensaje
            {
                MessageBox.Show("DEBE AGREGAR LOS CAMPOS RESTANTES"); // mensaje que muestra que el id y nombre estan vacios y debe agregar
            }
            else if (!Regex.IsMatch(textBox1.Text, @"^\d+$")) //condicion que hace que si el textbox de id tiene letras muestre un mensaje
            {
                MessageBox.Show("El identificador de PRODUCTO solo puede contener números.");// el id solo puede tener numeros
            }
            else if (!Regex.IsMatch(textBox2.Text, @"^[a-zA-Z]+$")) // condicion que hace que si el nombre de categoria tiene numeros muestre un mensaje
            {
                MessageBox.Show("El nombre solo puede contener letras.");// el nombre solo debe de tener letras
            }
            else if (!Regex.IsMatch(textBox4.Text, @"^\d+$")) //condicion que hace que si el textbox de id tiene letras muestre un mensaje
            {
                
                MessageBox.Show("El precio solo puede contener números.");//solo debe de tener numeros
            }
            else if (!Regex.IsMatch(textBox6.Text, @"^\d+$")) 
            {
                MessageBox.Show("El identificador de CATEGORIA solo puede contener números.");// solo debe de tener numeros
            }
            else
            {
                int id = int.Parse(textBox1.Text);//variable que guarda la informacion del textbox del id de producto
                string nom = textBox2.Text;//variable que guarda la informacion del textbox de nombre de producto
                string infor = textBox3.Text;//variable que guarda la informacion del textbox de nombre de descripcion de producto
                int preci = int.Parse(textBox4.Text);//variable que guarda la informacion del textbox del precio del producto
                bool est = checkBox1.Checked = true;
                int category = int.Parse(textBox6.Text);//variable que guarda la informacion del textbox del id de categoria
                //5

                //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
                conex.Modificaciones("exec Productoagregado '" + id + "', '" + nom + "', '" + infor + "', '" + preci + "', '" + est + "','" + category + "' ");
                MessageBox.Show("Producto Registrado");//accion que confirma la accion

                //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion grids y esta muestre los datos de la informacion de la tabla en la base de datos mediante una consulta en sql
                conex.Grids("SELECT IdPro as IDENTIFICADOR, NomPro as PRODUCTO, DesPro as DESCRIPCION, PrePro as PRECIO, IdCat as CATEGORIA, ExisPro as EXISTENCIA FROM PRODUCTOS WHERE EstPro = 1 ", dtginvent);
               
                //borra la informacion de los textbox
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox6.Clear();

            }

            DateTime fec;//variable tipo datetime
            fec = dateTimePicker1.Value;//variable que guarda la informacion del datetimepicker
            string acti = "Añadio en CATEGORIA";// variable que guarda la accion para bitacora
            string usariolabel = TxtUsuarioLabel.Text;//variable que guarda el nombre del usuario

            //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
            conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion buscar y esta muestre los datos de la informacion de la tabla en la base de datos cuando en la clausula like mediante la condicion PRODUCTO busque la informacion que coincida
            conex.buscar("SELECT IdPro as IDENTIFICADOR, NomPro as PRODUCTO, DesPro as DESCRIPCION, PrePro as PRECIO, IdCat as CATEGORIA, ExisPro as EXISTENCIA FROM PRODUCTOS WHERE EstPro = 1", dtginvent, "PRODUCTO LIKE '%" + txtbuscarproducto.Text + "%*' ");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar esta parte del inventario?", "ELIMINACIÓN COMPLETADA CON EXITO", MessageBoxButtons.YesNo) == DialogResult.Yes) //condicion que hace que si quiero elliminar pues que me de la opcion que si quiero o no y que si lo quiero hacer haga lo demas
            {
                string idinv = textBox1.Text;// variable que guarda la informacion del textbox del id de producto

                //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
                conex.Modificaciones("exec eliminarinvent '" + idinv + "'");
                MessageBox.Show("SE ELIMINÓ CON EXITO");//confirma la accion mediante este mensaje

                //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion grids y esta muestre los datos de la informacion de la tabla en la base de datos mediante una consulta en sql
                conex.Grids("SELECT IdPro as IDENTIFICADOR, NomPro as PRODUCTO, DesPro as DESCRIPCION, PrePro as PRECIO, IdCat as CATEGORIA, ExisPro as EXISTENCIA FROM PRODUCTOS WHERE EstPro = 1", dtginvent);
               //limpia los textbox
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox6.Clear();

                DateTime fec;//variable tipo datetime
                fec = dateTimePicker1.Value;//variable que guarda la informacion del datetimepicker
                string acti = "Eliminó en INVENTARIO";// variable que guarda la accion para bitacora
                string usariolabel = TxtUsuarioLabel.Text;//variable que guarda el nombre del usuario

                //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
                conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox6.Text == "") //condicion que dice que si los textboxs estan vacios muestre un mensaje
            {
                MessageBox.Show("TIENE DATOS INCOMPLETOS");//mensaje que muestra datos incompeltos
            }
            else if (!Regex.IsMatch(textBox1.Text, @"^\d+$"))//condicion que hace que si el textbox de id tiene letras muestre un mensaje
            {
                MessageBox.Show("El identificador de PRODUCTO solo puede contener números.");//solo acepta numeros
            }
            else if (!Regex.IsMatch(textBox2.Text, @"^[a-zA-Z]+$"))// condicion que hace que si el nombre de categoria tiene numeros muestre un mensaje
            {
                MessageBox.Show("El nombre solo puede contener letras.");//el nombre solo acepta letras
            }
            else if (!Regex.IsMatch(textBox4.Text, @"^\d+$"))//condicion que hace que si el textbox de precio tiene letras muestre un mensaje
            {
                MessageBox.Show("El precio solo puede contener números.");//el precio solo acepta numeros
            }
            else if (!Regex.IsMatch(textBox6.Text, @"^\d+$")) //condicion que hace que si el textbox de id de categoria tiene letras muestre un mensaje
            {
                MessageBox.Show("El identificador de CATEGORIA solo puede contener números.");// solo acepta numers
            }
            else
            {
                int id = int.Parse(textBox1.Text);//variable que guarda la informacion del textbox del id de producto
                string nom = textBox2.Text;//variable que guarda la informacion del textbox de nombre de producto
                string infor = textBox3.Text;//variable que guarda la informacion del textbox de nombre de descripcion de producto
                int preci = int.Parse(textBox4.Text);//variable que guarda la informacion del textbox del precio del producto
                bool est = checkBox1.Checked = true;
                int category = int.Parse(textBox6.Text);//variable que guarda la informacion del textbox del id de categoria
                //5

                //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
                conex.Modificaciones("exec editarproducto '" + id + "', '" + nom + "', '" + infor + "', '" + preci + "', '" + est + "','" + category + "' ");
                MessageBox.Show("Producto Editado");//mensaje que confirma la acción

                //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion grids y esta muestre los datos de la informacion de la tabla en la base de datos mediante una consulta en sql
                conex.Grids("SELECT IdPro as IDENTIFICADOR, NomPro as PRODUCTO, DesPro as DESCRIPCION, PrePro as PRECIO, IdCat as CATEGORIA, ExisPro as EXISTENCIA FROM PRODUCTOS WHERE EstPro = 1 ", dtginvent);
                
                //borra la informacion de los textboxs
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox6.Clear();
            }

            DateTime fec;//variable tipo datetime
            fec = dateTimePicker1.Value;//variable que guarda la informacion del datetimepicker
            string acti = "Editó en INVENTARIO";// variable que guarda la accion para bitacora
            string usariolabel = TxtUsuarioLabel.Text;//variable que guarda el nombre del usuario

            //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
            conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion grids y esta muestre los datos de la informacion de la tabla en la base de datos mediante una consulta en sql
            conex.Grids("select IdCat as Codigo, NomCat as Categoria from CATEGORIAS", dataGridView3);
            dataGridView3.Columns[0].Width = 60;
            dataGridView3.Columns[1].Width = 70;
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
            textBox6.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();//al dar click a una posicion de la columna se guarde en el textbox
            dataGridView3.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
          ProductosReportecs reporte = new ProductosReportecs();
            reporte.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtginvent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dtginvent.CurrentRow.Cells[0].Value.ToString(); //linea de codigo que hace que cuando de doble click a una posicion de la columna se guarde en el textbox
            textBox2.Text = dtginvent.CurrentRow.Cells[1].Value.ToString();//linea de codigo que hace que cuando de doble click a una posicion de la columna se guarde en el textbox
            textBox3.Text = dtginvent.CurrentRow.Cells[2].Value.ToString();//linea de codigo que hace que cuando de doble click a una posicion de la columna se guarde en el textbox
            textBox4.Text = dtginvent.CurrentRow.Cells[3].Value.ToString();//linea de codigo que hace que cuando de doble click a una posicion de la columna se guarde en el textbox
            //checkBox1.Text = dtginvent.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dtginvent.CurrentRow.Cells[4].Value.ToString();//linea de codigo que hace que cuando de doble click a una posicion de la columna se guarde en el textbox


        }
    }
}