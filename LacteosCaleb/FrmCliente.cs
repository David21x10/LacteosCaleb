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
            conex.buscar("Select * from CLIENTE", dtgcliente, "NomCli LIKE '%" + txtbuscarcliente.Text + "%*' ");
        }

        private void txtbuscarcliente_TextChanged(object sender, EventArgs e)
        {
            conex.buscar("Select * from CLIENTE", dtgcliente, "NomCli LIKE '%" + txtbuscarcliente.Text + "%*' ");
        }

        private void AÑADIR_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string nom = textBox2.Text;
            string correo = textBox3.Text;
            int telefono = int.Parse(textBox4.Text);

            conex.Modificaciones("exec AgreeCLI '" + id + "', '" + nom + "', '" + correo + "', '" + telefono + "' ");
            MessageBox.Show("Cliente Registrado");
            conex.Grids("SELECT * FROM Cliente", dtgcliente);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu nuevoFormulario = new FrmMenu();
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
                    conex.Grids("SELECT * FROM Cliente", dtgcliente);
                }
            }

            private void label3_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("¿QUIERES ELIMINAR EL CLIENTE?", "ELIMINAR CLIENTE", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string ideli = textBox1.Text;
                    conex.Modificaciones("exec deletecliente '" + ideli + "'");
                    MessageBox.Show("CLIENTE ELIMINADO CORRECTAMENTE");
                    conex.Grids("SELECT * FROM CLIENTE", dtgcliente);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();

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

