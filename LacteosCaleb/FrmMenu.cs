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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            this.MaximizedBounds=Screen.FromHandle(this.Handle).WorkingArea; // Establece los límites máximos de la ventana para que se ajuste al área de trabajo disponible en la pantalla actual, excluyendo la barra de tareas y otros elementos anclados.
        }
       
        private void factToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmFactura FormularioNuevo = new FrmFactura(); // crea una nueva instancia del formulario FrmFactura y la asigna a la variable FormularioNuevo.
            FormularioNuevo.MostrarUsuario(DatosUsuario.Usuario);// llama al método MostrarUsuario en la instancia FormularioNuevo, pasando como argumento el usuario almacenado en DatosUsuario.Usuario.
            FormularioNuevo.Show();// muestra el formulario FrmFactura en pantalla.
            this.Hide();//oculta el formulario actual
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompras nuevoFormulario = new FrmCompras(); // crea una nueva instancia del formulario FrmCompras y la asigna a la variable nuevoFormulario.
            nuevoFormulario.MostrarUsuario(DatosUsuario.Usuario);// llama al método MostrarUsuario en la instancia FormularioNuevo, pasando como argumento el usuario almacenado en DatosUsuario.Usuario.
            nuevoFormulario.Show();// muestra el formulario FrmFactura en pantalla.
            this.Hide();//oculta el formulario actual
        }

        private void cATEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInventario FormularioNuevo = new FrmInventario();// crea una nueva instancia del formulario FrmInventario y la asigna a la variable FormularioNuevo.
            FormularioNuevo.MostrarUsuario(DatosUsuario.Usuario);// llama al método MostrarUsuario en la instancia FormularioNuevo, pasando como argumento el usuario almacenado en DatosUsuario.Usuario.
            FormularioNuevo.Show();// muestra el formulario FrmInventario en pantalla.
            this.Hide();//oculta el formulario actual
        }

        private void cATEGORIAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Categoria FormularioNuevo = new Categoria();// crea una nueva instancia del formulario Categoria y la asigna a la variable FormularioNuevo.
            FormularioNuevo.MostrarUsuario(DatosUsuario.Usuario);// llama al método MostrarUsuario en la instancia FormularioNuevo, pasando como argumento el usuario almacenado en DatosUsuario.Usuario.
            FormularioNuevo.Show();// muestra el formulario Categoria en pantalla.
            this.Hide();//oculta el formulario actual
        }
        public void MostrarUsuario(string usuario)
        {
            usrlabel.Text = usuario;//variable que guarda la informacion de un textbox el nombre del usuario
        }
        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores FormularioNuevo = new FrmProveedores();// crea una nueva instancia del formulario FrmProveedores y la asigna a la variable FormularioNuevo.
            FormularioNuevo.MostrarUsuario(DatosUsuario.Usuario);// llama al método MostrarUsuario en la instancia FormularioNuevo, pasando como argumento el usuario almacenado en DatosUsuario.Usuario.
            FormularioNuevo.Show();// muestra el formulario FrmProveedores en pantalla.
            this.Hide(); //oculta el formulario actual
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente nuevoFormulario = new FrmCliente();// crea una nueva instancia del formulario FrmCliente y la asigna a la variable FormularioNuevo.
            nuevoFormulario.MostrarUsuario(DatosUsuario.Usuario);// llama al método MostrarUsuario en la instancia FormularioNuevo, pasando como argumento el usuario almacenado en DatosUsuario.Usuario.
            nuevoFormulario.Show();// muestra el formulario FrmCliente en pantalla.
            this.Hide();//oculta el formulario actual
        }

        private void cOMPRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompras nuevoFormulario = new FrmCompras();// crea una nueva instancia del formulario FrmCompras y la asigna a la variable FormularioNuevo.
            nuevoFormulario.MostrarUsuario(DatosUsuario.Usuario);// llama al método MostrarUsuario en la instancia FormularioNuevo, pasando como argumento el usuario almacenado en DatosUsuario.Usuario.
            nuevoFormulario.Show();// muestra el formulario FrmCompras en pantalla.
            this.Hide();//oculta el formulario actual
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro que quieres cerrar sesion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//mensaje que al presionarel boton salir consulte si quiere salir del programa o no

            
            if (resultado == DialogResult.Yes)//si es si
            {
                FrmUsuario nuevoFormulario = new FrmUsuario();//muestra el formulario de FrmUsuario, el login
                nuevoFormulario.Show();//muestra eb pantalla
                this.Hide();//oculta el formulario actual
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

        private void usrlabel_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BITACORA nuevoFormulario = new BITACORA(); // crea una nueva instancia del formulario BITACORA y la asigna a la variable FormularioNuevo.
            nuevoFormulario.Show();// muestra el formulario BITACORA en pantalla.
            this.Hide();//oculta el formulario actual
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInventario FormularioNuevo = new FrmInventario();// crea una nueva instancia del formulario FrmInventario y la asigna a la variable FormularioNuevo.
            FormularioNuevo.MostrarUsuario(DatosUsuario.Usuario);// llama al método MostrarUsuario en la instancia FormularioNuevo, pasando como argumento el usuario almacenado en DatosUsuario.Usuario.
            FormularioNuevo.Show();// muestra el formulario FrmInventario en pantalla.
            this.Hide();//oculta el formulario actual
        }

        private void categoriaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Categoria FormularioNuevo = new Categoria();// crea una nueva instancia del formulario Categoria y la asigna a la variable FormularioNuevo.
            FormularioNuevo.MostrarUsuario(DatosUsuario.Usuario);// llama al método MostrarUsuario en la instancia FormularioNuevo, pasando como argumento el usuario almacenado en DatosUsuario.Usuario.
            FormularioNuevo.Show();// muestra el formulario Categoria en pantalla.
            this.Hide();//oculta el formulario actual
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();// crea una nueva instancia del formulario Usuarios y la asigna a la variable Usuario.
            usuarios.Show();// muestra el formulario Usuarios en pantalla.
            this.Hide();//oculta el formulario actual.
        }
    }
}
