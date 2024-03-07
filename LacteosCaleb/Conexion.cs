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
       
        public void buscar(string Comando, DataGridView grid, string columna)
        {
            DataSet Dsa = new DataSet();
            BindingSource bs = new BindingSource();
            DataTable dt = new DataTable();
            string strConn = "Data Source=DESKTOP-09GMK57\\SQLEXPRESS; Initial Catalog=BD_LACTEOSCALEB; Integrated Security=true";
            SqlConnection conn = new SqlConnection(strConn);
            SqlDataAdapter da = new SqlDataAdapter(Comando, conn);

            da.Fill(dt);
            bs.DataSource = dt.DefaultView;

            grid.DataSource = bs;
            DataSet ds = new DataSet();
            ds.Tables.Add(dt.Copy());

            DataView dv = new DataView(ds.Tables[0]);
            dv.RowFilter = columna;

            if (dv.Count != 0)
                grid.DataSource = dv;
            else
                grid.DataSource = null;
        }
        public void Grids(string Comando, DataGridView dgv)
        {
            DataSet dsa = new DataSet();
            SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-09GMK57\\SQLEXPRESS; Initial Catalog=BD_LACTEOSCALEB; Integrated Security=true");
            SqlDataAdapter sqlDA = new SqlDataAdapter(Comando, sqlCon);
            sqlDA.Fill(dsa, "Tabla");

            dgv.DataSource = dsa.Tables[0];

            dsa.Dispose();
            sqlCon.Dispose();
            sqlDA.Dispose();
        }

        public bool Modificaciones(String Comando)
        {

            SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-09GMK57\\SQLEXPRESS; Initial Catalog=BD_LACTEOSCALEB; Integrated Security=true");
            SqlCommand sqlCmd = new SqlCommand(Comando, sqlCon);

            sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();

            sqlCmd.Dispose();
            sqlCon.Dispose();

            return true;
        }


    }
}