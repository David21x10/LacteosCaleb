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

        public void MostrarUsuario(string usuario)
        {
            TxtUsuarioLabel.Text = usuario;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dtginvent.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dtginvent.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dtginvent.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dtginvent.CurrentRow.Cells[3].Value.ToString();
                //checkBox1.Text = dtginvent.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dtginvent.CurrentRow.Cells[4].Value.ToString();
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
            conex.Grids("SELECT IdPro as IDENTIFICADOR, NomPro as PRODUCTO, DesPro as DESCRIPCION, PrePro as PRECIO, IdCat as CATEGORIA FROM PRODUCTOS WHERE EstPro = 1 ", dtginvent);
        }

        private void AÑADIR_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string nom = textBox2.Text;
            string infor = textBox3.Text;
            int preci = int.Parse(textBox4.Text);
            bool est = checkBox1.Checked = true;
            int category = int.Parse(textBox6.Text);
            //5
            conex.Modificaciones("exec Productoagregado '" + id + "', '" + nom + "', '" + infor + "', '" + preci + "', '" + est + "','" + category + "' ");
            MessageBox.Show("Producto Registrado");
            conex.Grids("SELECT IdPro as IDENTIFICADOR, NomPro as PRODUCTO, DesPro as DESCRIPCION, PrePro as PRECIO, IdCat as CATEGORIA FROM PRODUCTOS WHERE EstPro = 1 ", dtginvent);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();

            DateTime fec;
            fec = dateTimePicker1.Value;
            string acti = "Añadio en CATEGORIA";
            string usariolabel = TxtUsuarioLabel.Text;
            conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            conex.buscar("SELECT IdPro as IDENTIFICADOR, NomPro as PRODUCTO, DesPro as DESCRIPCION, PrePro as PRECIO, IdCat as CATEGORIA FROM PRODUCTOS WHERE EstPro = 1", dtginvent, "NomPro LIKE '%" + txtbuscarproducto.Text + "%*' ");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar esta parte del inventario?", "ELIMINACIÓN COMPLETADA CON EXITO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string idinv = textBox1.Text;
                conex.Modificaciones("exec eliminarinvent '" + idinv + "'");
                MessageBox.Show("SE ELIMINÓ CON EXITO");
                conex.Grids("SELECT IdPro as IDENTIFICADOR, NomPro as PRODUCTO, DesPro as DESCRIPCION, PrePro as PRECIO, IdCat as CATEGORIA FROM PRODUCTOS WHERE EstPro = 1", dtginvent);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox6.Clear();

                DateTime fec;
                fec = dateTimePicker1.Value;
                string acti = "Eliminó en INVENTARIO";
                string usariolabel = TxtUsuarioLabel.Text;
                conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string nom = textBox2.Text;
            string infor = textBox3.Text;
            int preci = int.Parse(textBox4.Text);
            bool est = checkBox1.Checked = true;
            int category = int.Parse(textBox6.Text);
            //5
            conex.Modificaciones("exec editarproducto '" + id + "', '" + nom + "', '" + infor + "', '" + preci + "', '" + est + "','" + category + "' ");
            MessageBox.Show("Producto Registrado");
            conex.Grids("SELECT IdPro as IDENTIFICADOR, NomPro as PRODUCTO, DesPro as DESCRIPCION, PrePro as PRECIO, IdCat as CATEGORIA FROM PRODUCTOS WHERE EstPro = 1 ", dtginvent);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();

            DateTime fec;
            fec = dateTimePicker1.Value;
            string acti = "Editó en INVENTARIO";
            string usariolabel = TxtUsuarioLabel.Text;
            conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");
        }

        private void button4_Click(object sender, EventArgs e)
        {
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
            textBox6.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            dataGridView3.Visible = false;
        }
    }
}