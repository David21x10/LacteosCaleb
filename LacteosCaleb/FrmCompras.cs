using LacteosCaleb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static LacteosCaleb.Conexion;
using SQLitePCL;
namespace LacteosCaleb
{
    public partial class FrmCompras : Form
    {
        private int ide; //variable que sirve como parametro para el valor de la ultima factura y que sea llamada en el reporte
        public FrmCompras()
        {
            InitializeComponent();

        }


        Conexion Conex = new Conexion(); //llamado para las funciones de la clase Conexion
        private void FrmCompras_Load(object sender, EventArgs e)
        {
            autonum(); // funcion del autonum que suma en uno al pagar la compra

            //aca agreuge esto para añadir las opciones al combobox
            cmbreporteFopciones.Items.Add("Reporte Diario");
            cmbreporteFopciones.Items.Add("Resumen del dia");
            cmbreporteFopciones.Items.Add("Buscar Codigo de Compra");
            cmbreporteFopciones.Items.Add("Buscar por mes");
            cmbreporteFopciones.Items.Add("Buscar Compra de una fecha");
        }
        public void MostrarUsuario(string usuario)
        {
            TxtUsuarioLabel.Text = usuario;//la variable que guarda lo que esta en el textbox que contiene el nombre del usuario en este formulario
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu nuevoFormulario = new FrmMenu();// llamado a formulario menú mediante un botón
            nuevoFormulario.Show();//llama al formulario
            this.Hide();//oculta el formulario actual
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtgCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AÑADIR_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmMenu FormularioNuevo = new FrmMenu();// llamado a formulario menú mediante un botón
            FormularioNuevo.MostrarUsuario(DatosUsuario.Usuario);//variable que guarda la variable que contiene el textbox del usuario
            FormularioNuevo.Show();//llama al formulario
            this.Hide();//oculta el formulario actual
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conex.Grids("select IdPro as Codigo, NomPro as Producto,PrePro as Precio from PRODUCTOS", dataGridView2);//linea que muestra las columnas de la tabla PRODUCTOS
            dataGridView2.Columns[0].Width = 60;// establece el ancho de la primera columna de dataGridView2 a 60
            dataGridView2.Columns[2].Width = 70;// establece el ancho de la tercera columna de dataGridView2 a 70
            if (dataGridView2.Visible)// verifica si dataGridView2 está visible
            {

                dataGridView2.Hide();// si dataGridView2 está visible, la oculta
            }
            else
            {

                dataGridView2.Show();// si dataGridView2 no está visible, la muestra
                dataGridView3.Visible = false;// establece la propiedad Visible de dataGridView3 a false, ocultándola
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void autonum()// define un método privado llamado autonum
        {
           // string servidor = "DESKTOP-09GMK57\\SQLEXPRESS";// define una cadena con el nombre del servidor de SQL Server
            string servidor = "localhost,1433";//variable que guarda el nombre del servidor localhost  
            // construye la cadena de conexión utilizando el nombre del servidor y especificando la base de datos y la seguridad integrada
            string strConn = "Data Source=" + servidor + "; Initial Catalog=BD_LACTEOSCALEB; Integrated Security=true";
            SqlConnection conn = new SqlConnection(strConn);// crea una nueva instancia de SqlConnection usando la cadena de conexión
            string query = "SELECT MAX(IdComp) FROM COMPRAENCABEZADO";// define una consulta SQL para obtener el valor máximo de IdComp de la tabla COMPRAENCABEZADO
            SqlCommand cmd = new SqlCommand(query, conn);// crea una nueva instancia de SqlCommand utilizando la consulta y la conexión

            conn.Open();// abre la conexión a la base de datos
            object result = cmd.ExecuteScalar();// ejecuta la consulta y obtiene el primer valor de la primera fila del resultado
            conn.Close();//cierra la conexion
            int maxId;//variable que guardara el valor maximo del id de compra
           
            // Verifica si el resultado no es nulo antes de asignarlo al TextBox
            if (result != DBNull.Value)// si el resultado no es nulo
            {
                maxId = (Convert.ToInt32(result) + 1);// convierte el resultado a entero y le suma 1, luego lo asigna a maxId
                txtCompra.Text = maxId.ToString();// convierte maxId a cadena y lo asigna al TextBox txtCompra
            }
            else
            {
                // Maneja el caso en que no hay registros en la tabla
                maxId = 0;// asigna 0 a maxId si no hay registros
                txtCompra.Text = maxId.ToString();// convierte maxId a cadena y lo asigna al TextBox txtCompra
            }
        }

        private void AÑADIR_Click_1(object sender, EventArgs e)
        {
            if (producttxt.Text == "" || preciotextbox.Text == "" || cantidadtxt.Text == "")//linea que dice que si dicho campo este en blanco haga las condiciones
            {
                MessageBox.Show("PARA AÑADIR DEBE TENER LOS CAMPOS DE PRODUCTO COMPLETOS");//permite que muestre este messagebox
            }
            else
            {
                bool productoExiste = false;

                // Recorre las filas del DataGridView para verificar si el producto ya está en la primera columna
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == IdProdTxt.Text)
                    {
                        productoExiste = true;
                        break;
                    }
                }

                if (productoExiste)
                {
                    MessageBox.Show("NO SE PUEDE AGREGAR EL MISMO PRODUCTO VARIAS VECES EN LA TABLA");
                    cantidadtxt.Clear();
                    producttxt.Clear();
                    preciotextbox.Clear();
                }
                else
                {


                    double linea = int.Parse(preciotextbox.Text) * int.Parse(cantidadtxt.Text);// esta variable loque hace es que multiplica el valor de la cantidad y el precio
                    dataGridView1.Rows.Add(IdProdTxt.Text, producttxt.Text, cantidadtxt.Text, preciotextbox.Text, linea);// aca se agrega en las filas lo que vayamos agregando en los textbox en el datagrid

                    
                
                        //limpian los textbox estas lineas te codigo
                    IdProdTxt.Clear();
                    IdProdTxt.Focus();
                    producttxt.Clear();
                    cantidadtxt.Clear();
                    preciotextbox.Clear();

                    calcular();// llamado que hace que la funcion que hace que automaticamente se calcule el subtotal, impuesto y total
                }
                DateTime fec;//variable tipo datetime
                fec = dateTimePicker1.Value;//variable que guarda la informacion del datetimepicker
                string acti = "Añadio en FACTURA";// variable que guarda la accion para bitacora
                string usariolabel = TxtUsuarioLabel.Text;//variable que guarda el nombre del usuario

                //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
                Conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");
            }


        }
       

        private void label7_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);//elimina la fila seleccionada en el datagrid 
            calcular();// funcion que hace que automaticamente se calcule el subtotal, impuesto y total

            DateTime fec;//variable tipo datetime
            fec = dateTimePicker1.Value;//variable que guarda la informacion del datetimepicker
            string acti = "Borró en FACTURA";// variable que guarda la accion para bitacora
            string usariolabel = TxtUsuarioLabel.Text;//variable que guarda el nombre del usuario

            //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
            Conex.Modificaciones("exec IngresarBitacora '" + fec + "', '" + usariolabel + "', '" + acti + "'");
        }
        private void calcular()// funcion que hace que automaticamente se calcule el subtotal, impuesto y total
        {
            double total = 0;// declara una variable double llamada total y la inicializa a 0
            foreach (DataGridViewRow row in dataGridView1.Rows)// se mueve a través de cada fila en dataGridView1
            {
                if (row.Cells[4].Value != null)// verifica si el valor de la celda en la columna 4 de la fila no es nulo
                {
                    total += Convert.ToInt32(row.Cells[4].Value);// convierte el valor de la celda a entero y lo suma a total
                }
            }
            //valores del datagrid a los textbox de calculo
           
           
            RPAGAR.Text = (total.ToString());// convierte el valor total a cadena y lo asigna al TextBox RPAGAR
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtprovedorr.Text))//si el valor es nulo mostrar un mensaje
            {
                MessageBox.Show("Debe agregar el proveedor");//mensaje de que debe agregar proveedor 
            }
            else
            {
                DateTime fec;//variable tipo datetime
                //comp encabezado
                int ide = int.Parse(txtCompra.Text);//variable que guarda la informacion equivalente al idfactura compra en el textbox
                fec = dateTimePicker1.Value;//variable que guarda la informacion equivalente a la fecha en el textbox
                string prov = txtprovedorr.Text;//variable que guarda la informacion equivalente al proveedor en el textbox


                //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
                Conex.Modificaciones("exec comdetal '" + ide + "', '" + fec + "', '" + prov + "' ");
               
                DateTime feca;//variable tipo datetime
                int row = 0;//variable row iniciada en 0
                feca = dateTimePicker1.Value;//variable que guarda la informacion del datetimepicker
                string acti = "REALIZO COMPRA";// variable que guarda la accion para bitacora
                string usariolabel = TxtUsuarioLabel.Text;//variable que guarda el nombre del usuario

                //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
                Conex.Modificaciones("exec IngresarBitacora '" + feca + "', '" + usariolabel + "', '" + acti + "'");

                //fact det


                for (row = 0; row < dataGridView1.Rows.Count; row++)//ciclo for que hace que si el datagrid tiene mucho mas filas las vaya guardando una por una
                {


                    int idd = Convert.ToInt32(dataGridView1.Rows[row].Cells[0].Value);// variable que guarda la primer posicion del datagrid que pertenece al id del producto
                    int cant = Convert.ToInt32(dataGridView1.Rows[row].Cells[2].Value);//variable que guarda la tercer posicion del datagrid que tiene la cantidad
                    int preci = Convert.ToInt32(dataGridView1.Rows[row].Cells[4].Value);//variable que guarda la quinta posicion en el datagrid que tiene el precio

                    //Linea de codigo mediante la funcion modificaciones que guarda los parametros de las variables hechas en la base de datos en SQL SERVER 2019 mediante un procedimiento almacenado
                    Conex.Modificaciones("exec InsertCompraDetalle '" + ide + "', '" + idd + "', '" + cant + "', '" + preci + "' ");



                }

                autonum();//funcion que incrementa en uno el valor de idfacturacompra
                dataGridView1.Rows.Clear();//borra las filas del datagrid

                MessageBox.Show("Compra registrada con exito");//mensaje de confirmacion de compra exitosa
                txtprovedorr.Clear();//limpia el textbox de proveedor

                
                RPAGAR.Text = "";//limpia el total

                ReporteCompra repor = new ReporteCompra(ide);//llama al formulario de reportecompra con el parametro ide
                repor.ShowDialog();//lo muestra
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 2 || e.ColumnIndex == 3)// verifica si el índice de la columna es 2 o 3
            {
                int fila = e.RowIndex;// obtiene el índice de la fila afectada por el evento
                decimal valor1 = Convert.ToDecimal(dataGridView1.Rows[fila].Cells[2].Value);// convierte el valor de la celda en la columna 2 de la fila afectada a decimal y lo asigna a valor1
                decimal valor2 = Convert.ToDecimal(dataGridView1.Rows[fila].Cells[3].Value);// convierte el valor de la celda en la columna 3 de la fila afectada a decimal y lo asigna a valor2
                decimal resultado = valor1 * valor2;// calcula el resultado multiplicando valor1 por valor2
                dataGridView1.Rows[fila].Cells[4].Value = resultado;// asigna el resultado a la celda en la columna 4 de la fila afectada


                decimal sumaParcial = 0;// declara una variable decimal para almacenar el subtotal
                foreach (DataGridViewRow row in dataGridView1.Rows)// se mueve a través de cada fila en dataGridView1
                {
                    if (row.Cells[4].Value != null)// verifica si el valor de la celda en la columna 4 de la fila no es nulo
                    {
                        sumaParcial += Convert.ToDecimal(row.Cells[4].Value);// convierte el valor de la celda a decimal y lo suma a sumaParcial
                    }
                }
                //RPARCIAL.Text = sumaParcial.ToString();




            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdProdTxt.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();//linea de codigo que hace que cuando de doble click a una posicion de la columna se guarde en el textbox
            producttxt.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();//linea de codigo que hace que cuando de doble click a una posicion de la columna se guarde en el textbox
            preciotextbox.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();//linea de codigo que hace que cuando de doble click a una posicion de la columna se guarde en el textbox
            dataGridView2.Visible = false;//el datagrid no se verá
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //linea de codigo que mediante la variable que llama las funciones de la conexion se enlaze con la funcion grids y esta muestre los datos de la informacion de la tabla en la base de datos mediante una consulta en sql
            Conex.Grids("select IdPrv  as DNI, NomPrv as Nombre , TelfPrv as Telefono from PROVEEDORES", dataGridView3);
           
            dataGridView3.Columns[0].Width = 60;// Establece el ancho de la primera columna de dataGridView3 en 60
            dataGridView3.Columns[2].Width = 70;// Establece el ancho de la tercera columna de dataGridView3 en 70

            if (dataGridView3.Visible)// Verifica si dataGridView3 está visible
            {
               
                dataGridView3.Hide();// Si dataGridView3 está visible, lo oculta
            }
            else
            {
                
                dataGridView3.Show();// Si dataGridView3 no está visible, lo muestra
                dataGridView2.Visible = false;// Establece la propiedad Visible de dataGridView2 en false para ocultarlo
            }



        }

        private void dataGridView3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtprovedorr.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();//linea de codigo que hace que cuando de doble click a una posicion de la columna se guarde en el textbox
            dataGridView3.Visible = false;// Establece la propiedad Visible de dataGridView2 en false para ocultarlo
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
        private void CalcularDevolucion()// Define un método privado llamado CalcularDevolucion
        {
            // Intenta convertir los textos de txtefectivo y RPAGAR a valores decimales y si ambos textos se pueden convertir correctamente, el bloque de código dentro de este if se ejecutará.
            if (decimal.TryParse(txtefectivo.Text, out decimal efectivo) && decimal.TryParse(RPAGAR.Text, out decimal parcial))
            {
                decimal devolucion = efectivo - parcial;// Calcula la devolución restando parcial de efectivo
                txtdevolucion.Text = devolucion.ToString();// Convierte la devolución a string y la asigna al Text de txtdevolucion
            }
            else
            {
                
                txtdevolucion.Text = "";// Si no se pueden realizar las conversiones, se establece el Text de txtdevolucion como una cadena vacía
            }
        }

        private void txtefectivo_TextChanged(object sender, EventArgs e)
        {
            CalcularDevolucion();//metodo que calcula el subtotal, impuesto y total
        }

        private void txtdevolucion_Click(object sender, EventArgs e)
        {
            CalcularDevolucion();//metodo que calcula el subtotal, impuesto y total
        }
        int mes = 1;//variable que guarda el parametro de un mes
        DateTime fec = new DateTime(2024, 1, 1);//variable que guarda una fecha
        private void cmbreporteFopciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbreporteFopciones.Text)//switch perteneciente a un combobox que guarda opciones de los reportes
            {
                case "Reporte Diario"://reporte diario
                    ReporteCompraporCompraDiaria compradiaria= new ReporteCompraporCompraDiaria();//llama al formulario del reporte diario
                    compradiaria.ShowDialog();//lo muestra
                    break;//cierra

                case "Resumen del dia":
                    ReporteCompraResumenDeldia resumencompradiario= new ReporteCompraResumenDeldia();//llama al formulario que muestra el resumen de ventas
                    resumencompradiario.ShowDialog();//lo muestra
                    
                    break;//cierra

                case
                   "Buscar Codigo de Compra":

                    ReportePorCodigoCompras reporcod = new ReportePorCodigoCompras(ide=1);//llama al formulario con una variable que tiene guardado el id de factura
                    reporcod.ShowDialog();//lo muestra
                    break;//cierra

                case
                    "Buscar por mes":
                    ReporteComprapormes comprapormes= new ReporteComprapormes(mes=1);//llama al formulario con una variable que guarda el numero de mes como parametro
                    comprapormes.ShowDialog();//lo muestra
                    
                    break;//cierra
                case
                   "Buscar Compra de una fecha":
                    ReporteCompraporFecha compraporfecha = new ReporteCompraporFecha(fec);//llama al formulario con una variable que guarda la fecha mes como parametro
                    compraporfecha.ShowDialog();//lo muestra
                   
                    break;//cierra
                default:

                    break;//cierra el switch
            }
        }

        private void RPAGAR_Click(object sender, EventArgs e)
        {

        }
    }
}
