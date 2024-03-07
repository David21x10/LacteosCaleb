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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void factToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFactura FormularioNuevo = new FrmFactura();
            FormularioNuevo.Show();
            this.Hide();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cATEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInventario FormularioNuevo = new FrmInventario();
            FormularioNuevo.Show();
            this.Hide();
        }

        private void cATEGORIAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Categoria FormularioNuevo = new Categoria();
            FormularioNuevo.Show();
            this.Hide();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores FormularioNuevo = new FrmProveedores();
            FormularioNuevo.Show();
            this.Hide();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente nuevoFormulario = new FrmCliente();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void cOMPRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompras nuevoFormulario = new FrmCompras();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro que quieres cerrar sesion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (resultado == DialogResult.Yes)
            {
                FrmUsuario nuevoFormulario = new FrmUsuario();
                nuevoFormulario.Show();
                this.Hide();
            }
            // Si el usuario selecciona "No", cancelamos el evento de cierre del formulario
            else
            {
              
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
