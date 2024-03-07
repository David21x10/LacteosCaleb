using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dtginvent.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dtginvent.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dtginvent.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dtginvent.CurrentRow.Cells[3].Value.ToString();
                checkBox1.Text = dtginvent.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dtginvent.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu nuevoFormulario = new FrmMenu();
            nuevoFormulario.Show();
            this.Hide();

        }
        Conexion conex = new Conexion();
        private void FrmInventario_Load(object sender, EventArgs e)
        {
            conex.buscar("Select * from PRODUCTOS", dtginvent, "NomPro LIKE '%" + txtbuscarproducto.Text + "%*' ");
        }

        private void AÑADIR_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string nom = textBox2.Text;
            string infor = textBox3.Text;
            int preci = int.Parse(textBox4.Text);
            string est = txtbuscarproducto.Text;
            int category = int.Parse(textBox6.Text);
            //5
            conex.Modificaciones("exec Productoagregado '" + id + "', '" + nom + "', '" + infor + "', '" + preci + "', '" + est + "','" + category + "' ");
            MessageBox.Show("Producto Registrado");
            conex.Grids("SELECT * FROM PRODUCTOS ", dtginvent);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            conex.buscar("Select * from PRODUCTOS", dtginvent, "NomPro LIKE '%" + txtbuscarproducto.Text + "%*' ");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar esta parte del inventario?", "ELIMINACIÓN COMPLETADA CON EXITO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string idinv = textBox1.Text;
                conex.Modificaciones("exec eliminarinvent '" + idinv + "'");
                MessageBox.Show("SE ELIMINÓ CON EXITO");
                conex.Grids("SELECT * FROM PRODUCTOS ", dtginvent);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string nom = textBox2.Text;
            string infor = textBox3.Text;
            int preci = int.Parse(textBox4.Text);
            string est = txtbuscarproducto.Text;
            int category = int.Parse(textBox6.Text);
            //5
            conex.Modificaciones("exec editarproducto '" + id + "', '" + nom + "', '" + infor + "', '" + preci + "', '" + est + "','" + category + "' ");
            MessageBox.Show("Producto Registrado");
            conex.Grids("SELECT * FROM PRODUCTOS ", dtginvent);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}