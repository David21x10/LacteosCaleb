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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmUsuario FormularioNuevo = new FrmUsuario();
            FormularioNuevo.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmUsuario FormularioNuevo = new FrmUsuario();
            FormularioNuevo.Show();
            this.Hide();

        }
    }
}
