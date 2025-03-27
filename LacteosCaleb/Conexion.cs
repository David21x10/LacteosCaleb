using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LacteosCaleb
{
    internal class Conexion
    {
       // string servidor = "DESKTOP-09GMK57\\SQLEXPRESS";
        string servidor = "localhost,1433";//variable que guarda el nombre del servidor localhost  
        public void buscar(string Comando, DataGridView grid, string columna)
        {
            DataSet Dsa = new DataSet();// dataset para almacenar los datos
            BindingSource bs = new BindingSource();// bindingsource para vincular los datos al datagridview
            DataTable dt = new DataTable();// datatable para almacenar los datos temporalmente
            string strConn = "Data Source=" + servidor + "; Initial Catalog=BD_LACTEOSCALEB; Integrated Security=true";// cadena de conexión a la base de datos
            SqlConnection conn = new SqlConnection(strConn);// conexión a la base de datos
            SqlDataAdapter da = new SqlDataAdapter(Comando, conn);// adaptador para ejecutar el comando y llenar el datatable

            da.Fill(dt);// llena el datatable con los datos obtenidos
            bs.DataSource = dt.DefaultView;// asigna los datos al bindingsource

            grid.DataSource = bs;// asigna el bindingsource al datagridview
            DataSet ds = new DataSet();// crea un nuevo dataset para almacenar una copia de los datos
            ds.Tables.Add(dt.Copy());// añade una copia de la tabla de datos al dataset

            DataView dv = new DataView(ds.Tables[0]);// crea una vista de datos a partir de la primera tabla del dataset
            dv.RowFilter = columna;// aplica el filtro a la vista de datos

            if (dv.Count != 0)// si hay datos después de aplicar el filtro, asigna la vista al datagridview
                grid.DataSource = dv;
            else
                grid.DataSource = null;// si no hay datos, asigna null al datagridview
        }
        public void Grids(string Comando, DataGridView dgv)
        {
            DataSet dsa = new DataSet();// dataset para almacenar los datos
            SqlConnection sqlCon = new SqlConnection("Data Source=" + servidor + "; Initial Catalog=BD_LACTEOSCALEB; Integrated Security=true");// conexión a la base de datos
            SqlDataAdapter sqlDA = new SqlDataAdapter(Comando, sqlCon);// adaptador para ejecutar el comando y llenar el dataset
            sqlDA.Fill(dsa, "Tabla");// llena el dataset con los datos obtenidos

            dgv.DataSource = dsa.Tables[0];// asigna la primera tabla del dataset al datagridview

            dsa.Dispose();// libera los recursos del dataset
            sqlCon.Dispose();// libera los recursos de la conexión
            sqlDA.Dispose();// libera los recursos del adaptador

        }

        public bool Modificaciones(String Comando)
        {

            SqlConnection sqlCon = new SqlConnection("Data Source=" + servidor + "; Initial Catalog=BD_LACTEOSCALEB; Integrated Security=true");// conexión a la base de datos
            SqlCommand sqlCmd = new SqlCommand(Comando, sqlCon);// comando para ejecutar la consulta

            sqlCon.Open();// abre la conexión
            sqlCmd.ExecuteNonQuery();// ejecuta la consulta
            sqlCon.Close();// cierra la conexión

            sqlCmd.Dispose();// libera los recursos del comando
            sqlCon.Dispose();// libera los recursos de la conexión


            return true;// devuelve true si la operación fue exitosa
        }

        public SqlDataReader Reader(string cons)
        {
            SqlDataReader dr = null;// lector de datos inicializado en null
            try
            {
                SqlConnection sqlCon = new SqlConnection("Data Source=" + servidor + "; Initial Catalog=BD_LACTEOSCALEB; Integrated Security=true");// conexión a la base de datos

                SqlCommand cmdInstruction = new SqlCommand(cons, sqlCon);// comando para ejecutar la consulta
                dr = cmdInstruction.ExecuteReader();// ejecuta la consulta y obtiene el lector de datos
            }
            catch (Exception ex)
            {
                dr = null;// si hay una excepción, el lector de datos es null
                Console.WriteLine(ex.Message);// imprime el mensaje de la excepción
            }
            finally
            {
                
            }
            return dr;// devuelve el lector de datos
        }

        public static class DatosUsuario
        {
            public static string Usuario { get; set; }// propiedad estática para almacenar el nombre de usuario
        }

        
    }
}