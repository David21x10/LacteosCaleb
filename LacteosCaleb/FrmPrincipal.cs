using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//INTEGRANTES
//David Fernando Vallecillo
//Kristhy Lizeth Maldonado Ponce
// Maria José Cerrato Palada
//Arony Daniel Castillo Banegas
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
            FrmUsuario FormularioNuevo = new FrmUsuario();//muestra el formulario FrmUsuario
            FormularioNuevo.Show();//Muestra en pantalla
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmUsuario FormularioNuevo = new FrmUsuario();//Muestra el formulario FrmUsuario
            FormularioNuevo.Show();//Muestra en pantalla
            this.Hide();//Oculta el formulario anterior

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
