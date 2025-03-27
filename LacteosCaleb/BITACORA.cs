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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LacteosCaleb
{
    public partial class BITACORA : Form
    {
        public BITACORA()
        {
            InitializeComponent();
        }
        Conexion conex = new Conexion();//variable que guarda el llamado a la conexion
        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu nuevoFormulario = new FrmMenu();// llamado a formulario menú mediante un botón
            nuevoFormulario.MostrarUsuario(DatosUsuario.Usuario);//// variable que hace el llamado del nombre del usuario en el formulario de usuario que sea llamado en el form de Bitacora
            nuevoFormulario.Show();//muestra el formulario
            this.Hide();

        }

        private void BITACORA_Load(object sender, EventArgs e)
        {
            
            //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion grids y esta muestre los datos de la informacion de la tabla en la base de datos.
            conex.Grids("select  FecBit as Fecha , NomUsr as Usuario, IdActi as Actividad from TB_BITACORA", dtgbitacora);
        }
    }
}
