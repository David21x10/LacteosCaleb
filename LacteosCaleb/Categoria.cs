using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LacteosCaleb
{
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }
        Conexion conex = new Conexion();
        private void Categoria_Load(object sender, EventArgs e)
        {
            conex.buscar("Select * from CATEGORIAS", dtgcategoria, "NomCat LIKE '%" + txtbuscarcategoria.Text + "%*' ");
        }

        private void txtbuscarcategoria_TextChanged(object sender, EventArgs e)
        {
            conex.buscar("Select * from CATEGORIAS", dtgcategoria, "NomCat LIKE '%" + txtbuscarcategoria.Text + "%*' ");
        }

        private void AÑADIR_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string nom = textBox2.Text;

            conex.Modificaciones("exec CategoriaAgregada '" + id + "', '" + nom + "' ");
            MessageBox.Show("Categoria Registrada");
            conex.Grids("SELECT * FROM CATEGORIAS", dtgcategoria);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu nuevoFormulario = new FrmMenu();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar el proveedor?", "PROVEEDOR ELIMINADO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string idcat = textBox1.Text;
                conex.Modificaciones("exec eliminarcategoria '" + idcat + "'");
                MessageBox.Show("SE ELIMINÓ LA CATEGORIA CON EXITO");
                conex.Grids("SELECT * FROM CATEGORIAS", dtgcategoria);
                textBox1.Clear();
                textBox2.Clear();
               




            }
        }

        private void dtgcategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dtgcategoria.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dtgcategoria.CurrentRow.Cells[1].Value.ToString();
                
            }
            catch
            {

            }
        }
    }
}
