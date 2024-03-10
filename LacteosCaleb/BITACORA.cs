using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LacteosCaleb.Conexion;

namespace LacteosCaleb
{
    public partial class BITACORA : Form
    {
        public BITACORA()
        {
            InitializeComponent();
        }
        Conexion conex = new Conexion();
        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu nuevoFormulario = new FrmMenu();
            nuevoFormulario.MostrarUsuario(DatosUsuario.Usuario);
            nuevoFormulario.Show();
            this.Hide();
        }

        private void BITACORA_Load(object sender, EventArgs e)
        {
            conex.Grids("select  FecBit as Fecha ,NomUsr as Usuario, IdActi as Actividad from TB_BITACORA", dtgbitacora);
        }
    }
}
