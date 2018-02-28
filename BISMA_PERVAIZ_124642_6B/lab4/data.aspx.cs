using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab4
{
    public partial class data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                //string sFilePath = Server.MapPath("lab4.mdb");
                DataTable dt;
                OleDbConnection Conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Bisma/Documents/lab4.mdb;Persist Security Info=False;");

                using (Conn)
                {
                    Conn.Open();
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM register", Conn);
                    OleDbDataAdapter oDA = new OleDbDataAdapter(cmd);
                    dt = new DataTable();
                    oDA.Fill(dt);

                }

                DataList1.DataSource = dt;
                DataList1.DataBind();

            }
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}