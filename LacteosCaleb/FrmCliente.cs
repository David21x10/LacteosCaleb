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

namespace LacteosCaleb
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }
        Conexion conex = new Conexion();
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            conex.Grids("select DNI as DNI, NomCli as NOMBRE ,CorCli as CORREO, TelCli as TELEFONO from CLIENTE", dtgcliente);
        }
        public void MostrarUsuario(string usuario)
        {
            TxtUsuarioLabel.Text = usuario;
        }
        private void txtbuscarcliente_TextChanged(object sender, EventArgs e)
        {
            conex.buscar("select DNI as DNI, NomCli as NOMBRE ,CorCli as CORREO, TelCli as TELEFONO from CLIENTE", dtgcliente, "NOMBRE LIKE '%" + txtbuscarcliente.Text + "%*' ");
        }

        private void AÑADIR_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string nom = textBox2.Text;
            string correo = textBox3.Text;
            int telefono = int.Parse(textBox4.Text);

            conex.Modificaciones("exec AgreeCLI '" + id + "', '" + nom + "', '" + correo + "', '" + telefono + "' ");
            MessageBox.Show("Cliente Registrado");
            conex.Grids("select DNI as DNI, NomCli as NOMBRE ,CorCli as CORREO, TelCli as Telefono from CLIENTE", dtgcliente);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            DateTime fec;
            fec = dateTimePicker1.Value;
            string acti = "Se añadio en CLIENTES";
            string usariolabel = TxtUsuarioLabel.Text;
            conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel+ "', '" + acti + "'");


        }



        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu nuevoFormulario = new FrmMenu();
            nuevoFormulario.MostrarUsuario(DatosUsuario.Usuario);
            nuevoFormulario.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("TIENE DATOS INCOMPLETOS");
                }
                else
                {
                    string id = textBox1.Text;
                    string nom = textBox2.Text;
                    string correo = textBox3.Text;
                    int telefono = int.Parse(textBox4.Text);

                    conex.Modificaciones("exec EditarCliente  '" + id + "', '" + nom + "', '" + correo + "', '" + telefono + "' ");
                    MessageBox.Show("Cliente Actualizado");

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    conex.Grids("select DNI as DNI, NomCli as NOMBRE ,CorCli as CORREO, TelCli as TELEFONO from CLIENTE", dtgcliente);
                DateTime fec;
                fec = dateTimePicker1.Value;
                string acti = "Se editó en CLIENTES";
                string usariolabel = TxtUsuarioLabel.Text;
                conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");
            }
            }

            private void label3_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("¿QUIERES ELIMINAR EL CLIENTE?", "ELIMINAR CLIENTE", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string ideli = textBox1.Text;
                    conex.Modificaciones("exec deletecliente '" + ideli + "'");
                    MessageBox.Show("CLIENTE ELIMINADO CORRECTAMENTE");
                    conex.Grids("select DNI as DNI, NomCli as NOMBRE ,CorCli as CORREO, TelCli as TELEFONO from CLIENTE", dtgcliente);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();

                DateTime fec;
                fec = dateTimePicker1.Value;
                string acti = "Se eliminó en CLIENTES";
                string usariolabel = TxtUsuarioLabel.Text;
                conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");

            }
            }

        private void dtgcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dtgcliente.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dtgcliente.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dtgcliente.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dtgcliente.CurrentRow.Cells[3].Value.ToString();
            }
            catch { 
            
            }
             
        }
    }
    }

