using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace 例9_11
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection myConn = new System.Data.OleDb.OleDbConnection();
            string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Nwind.mdb;Persist Security Info=True";
            myConn.ConnectionString = connString;

            System.Data.OleDb.OleDbCommand myCommand = new System.Data.OleDb.OleDbCommand();
            myCommand.Connection = myConn;
            myCommand.CommandText = "select * from employees";

            myConn.Open();
            System.Data.OleDb.OleDbDataReader myReader = myCommand.ExecuteReader();

            while (myReader.Read() == true)
            {
                ListBox1.Items.Add(myReader["FirstName"] + "," + myReader["LastName"]);
            }

            //ListBox1.DataSource = myReader;
            //ListBox1.DataTextField = "FirstName";
            //ListBox1.DataValueField = "EmployeeID";
            //ListBox1.DataBind();        

            myReader.Close();
            myConn.Close();
        }
    }
}
