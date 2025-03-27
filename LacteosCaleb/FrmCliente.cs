using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static LacteosCaleb.Conexion;

namespace LacteosCaleb
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();// inicializa los componentes del formulario
        }
        Conexion conex = new Conexion();// instancia de la clase Conexion
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // carga los datos del cliente en el DataGridView al cargar el formulario
            conex.Grids("select DNI as DNI, NomCli as NOMBRE ,CorCli as CORREO, TelCli as TELEFONO from CLIENTE", dtgcliente);
        }
        public void MostrarUsuario(string usuario)
        {
            // muestra el usuario en una etiqueta
            TxtUsuarioLabel.Text = usuario;
        }
        private void txtbuscarcliente_TextChanged(object sender, EventArgs e)
        {
            // filtra los clientes en el DataGridView basado en el texto ingresado
            conex.buscar("select DNI as DNI, NomCli as NOMBRE ,CorCli as CORREO, TelCli as TELEFONO from CLIENTE", dtgcliente, "NOMBRE LIKE '%" + txtbuscarcliente.Text + "%*' ");
        }

        private void AÑADIR_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")// verifica que los campos requeridos no estén vacíos
            {
                MessageBox.Show("DEBE AGREGAR EL DNI o NOMBRE");
            }
            else if (!Regex.IsMatch(textBox1.Text, @"^\d+$"))// valida que el DNI solo contenga números
            {
                MessageBox.Show("El DNI solo puede contener números.");
            }
            else if (!Regex.IsMatch(textBox2.Text, @"^[a-zA-Z]+$"))// valida que el nombre solo contenga letras
            {
                MessageBox.Show("El nombre solo puede contener letras.");
            }
            else if (!Regex.IsMatch(textBox4.Text, @"^\d+$"))// valida que el teléfono solo contenga números
            {
                MessageBox.Show("El teléfono solo puede contener números.");
            }
            else
            {
                string id = textBox1.Text;//variable que contiene el id
                string nom = textBox2.Text;//variable que contiene el nombre
                string correo = textBox3.Text;//variable que contiene el correo
                int telefono = int.Parse(textBox4.Text);//variable que contiene el telefono

                // ejecuta el procedimiento almacenado para agregar un cliente
                conex.Modificaciones("exec AgreeCLI '" + id + "', '" + nom + "', '" + correo + "', '" + telefono + "' ");
                MessageBox.Show("Cliente Registrado");//mensaje de confirmación de cliente agregado

                // actualiza el DataGridView con los nuevos datos
                conex.Grids("select DNI as DNI, NomCli as NOMBRE ,CorCli as CORREO, TelCli as Telefono from CLIENTE", dtgcliente);
                
                //limpia los textboxs
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }

            DateTime fec;//variable fec
            fec = dateTimePicker1.Value;//variable que guarda el tipo de valor de la fecha
            string acti = "Se añadio en CLIENTES";//variable que guarda la acción
            string usariolabel = TxtUsuarioLabel.Text;//variable que guarda el usuario

            // ejecuta el procedimiento almacenado para agregar la acción en la bitacora
            conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel+ "', '" + acti + "'");


        }



        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu nuevoFormulario = new FrmMenu();//abre el formulario
            nuevoFormulario.MostrarUsuario(DatosUsuario.Usuario);//conexion entre la variable del usuario
            nuevoFormulario.Show();//muestra el formulario
            this.Hide();//oculta el formulario actual
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
                if (textBox1.Text == "" || textBox2.Text == "")// verifica que los campos requeridos no estén vacíos
            {
                    MessageBox.Show("TIENE DATOS INCOMPLETOS");
                }
            else if (!Regex.IsMatch(textBox1.Text, @"^\d+$"))// valida que el DNI solo contenga números
            {
                MessageBox.Show("El DNI solo puede contener números.");
            }
            else if (!Regex.IsMatch(textBox2.Text, @"^[a-zA-Z]+$"))// valida que el nombre solo contenga letras
            {
                MessageBox.Show("El nombre solo puede contener letras.");
            }
            else if (!Regex.IsMatch(textBox4.Text, @"^\d+$"))// valida que el teléfono solo contenga números
            {
                MessageBox.Show("El teléfono solo puede contener números.");
            }
            else
                {
                    string id = textBox1.Text;//variable que guarda el DNI
                    string nom = textBox2.Text;//variable que guarda el nombre
                string correo = textBox3.Text;//variable que guarda el correo
                int telefono = int.Parse(textBox4.Text);//variable que guarda el telefono


                // ejecuta el procedimiento almacenado para editar un cliente
                conex.Modificaciones("exec EditarCliente  '" + id + "', '" + nom + "', '" + correo + "', '" + telefono + "' ");
                    MessageBox.Show("Cliente Actualizado");//mensaje de confirmacion que se editó el cliente

                //limpia los textboxs
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();

                // actualiza el DataGridView con los nuevos datos
                conex.Grids("select DNI as DNI, NomCli as NOMBRE ,CorCli as CORREO, TelCli as TELEFONO from CLIENTE", dtgcliente);
                DateTime fec;//variable tipo datetime
                fec = dateTimePicker1.Value;//variable que guarda el tipo de valor de la fecha
                string acti = "Se editó en CLIENTES";//variable que guarda la accion
                string usariolabel = TxtUsuarioLabel.Text;//variable que guarda el usuario
                // ejecuta el procedimiento almacenado para guardar la acción en bitacora
                conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");
            }
            }

            private void label3_Click(object sender, EventArgs e)
            {
            // pregunta al usuario si desea eliminar el cliente
            if (MessageBox.Show("¿QUIERES ELIMINAR EL CLIENTE?", "ELIMINAR CLIENTE", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string ideli = textBox1.Text;//variable que guarda el DNI
                    // ejecuta el procedimiento almacenado para eliminar un cliente
                    conex.Modificaciones("exec deletecliente '" + ideli + "'");
                    MessageBox.Show("CLIENTE ELIMINADO CORRECTAMENTE");//mensaje de confirmacion de eliminación

                // actualiza el DataGridView con los nuevos datos
                conex.Grids("select DNI as DNI, NomCli as NOMBRE ,CorCli as CORREO, TelCli as TELEFONO from CLIENTE", dtgcliente);
                    
                //limpia los textboxs
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();

                DateTime fec;//variable tipo datetime
                fec = dateTimePicker1.Value;//variable que guarda el tipo de valor de la fecha
                string acti = "Se eliminó en CLIENTES";//variable que guarda la acción 
                string usariolabel = TxtUsuarioLabel.Text;//variable que guarda el usuario
                //// ejecuta el procedimiento almacenado para guardar la acción en la bitacora
                conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");

            }
            }

        private void dtgcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
             
        }

        private void dtgcliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
              
           

            }

        private void label8_Click(object sender, EventArgs e)
        {
            ReporteClienteMasCompra repor= new ReporteClienteMasCompra();//abre el formulario
            repor.ShowDialog();//muestra el formulario
        }

        private void dtgcliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dtgcliente.CurrentRow.Cells[0].Value.ToString(); // llena los campos de texto con los datos de la fila seleccionada en el DataGridView
            textBox2.Text = dtgcliente.CurrentRow.Cells[1].Value.ToString(); // llena los campos de texto con los datos de la fila seleccionada en el DataGridView
            textBox3.Text = dtgcliente.CurrentRow.Cells[2].Value.ToString(); // llena los campos de texto con los datos de la fila seleccionada en el DataGridView
            textBox4.Text = dtgcliente.CurrentRow.Cells[3].Value.ToString(); // llena los campos de texto con los datos de la fila seleccionada en el DataGridView
        }
    }
    }
    

