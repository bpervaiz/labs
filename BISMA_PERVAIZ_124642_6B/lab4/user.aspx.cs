using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab4
{
    public partial class form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            string gender = TextBoxGender.Text;
            string age = TextBoxAge.Text;
            string cnic = TextBoxCNIC.Text;
            string address = TextBoxAddress.Text;

            OleDbConnection dbcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data source=C:/Users/Bisma/Documents/lab4.mdb; Persist Security Info=False;");
            dbcon.Open();

            OleDbCommand cmd3 = new OleDbCommand("INSERT INTO [register] ([names],[gender],[age],[cnic],[address]) VALUES ('" + name + "','" + gender + "','" + age + "','" + cnic + "','" + address + "')", dbcon);
            int result=cmd3.ExecuteNonQuery();

            if (result == 1)
            {
                Response.Write("<script>alert('Data submitted successfully!');</script>");
            }
            if (result !=1)
            {
                Response.Write("<script>alert('Data not submitted. Try again!');</script>");
            }
        }
    }
}