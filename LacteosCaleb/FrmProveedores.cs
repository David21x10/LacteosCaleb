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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }
        Conexion Conex = new Conexion();
        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            Conex.buscar("Select * from PROVEEDORES", dtgproovedores, "NomPrv LIKE '%" + txtbuscarproveedores.Text + "%*' ");
        }

        private void txtbuscarproveedores_TextChanged(object sender, EventArgs e)
        {
            Conex.buscar("Select * from PROVEEDORES", dtgproovedores, "NomPrv LIKE '%" + txtbuscarproveedores.Text + "%*' ");
        }

        private void AÑADIR_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string nom = textBox2.Text;
            string est = textBox1.Text;
            string correo = textBox3.Text;
            string telefono = textBox4.Text;
            //5
            Conex.Modificaciones("exec Provagr '" + id + "', '" + nom + "', '" + est + "', '" + correo + "','" + telefono + "' ");
            MessageBox.Show("Proveedor Registrado");
            Conex.Grids("SELECT * FROM PROVEEDORES", dtgproovedores);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu FormularioNuevo = new FrmMenu();
            FormularioNuevo.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar el proveedor?", "PROVEEDOR ELIMINADO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string idprv = textBox1.Text;
                Conex.Modificaciones("exec eliminarproveedor '" + idprv + "'");
                MessageBox.Show("SE ELIMINÓ EL PROVEEDOR CON EXITO");
                Conex.Grids("SELECT * FROM PROVEEDORES", dtgproovedores);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();




            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
                string est = textBox1.Text;
                string correo = textBox3.Text;
                string telefono = textBox4.Text;
                //5
                Conex.Modificaciones("exec editarProveedor '" + id + "', '" + nom + "', '" + est + "', '" + correo + "','" + telefono + "' ");
                MessageBox.Show("Proveedor Editado");
                Conex.Grids("SELECT * FROM PROVEEDORES", dtgproovedores);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
        }

        private void dtgproovedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dtgproovedores.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dtgproovedores.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dtgproovedores.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dtgproovedores.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
