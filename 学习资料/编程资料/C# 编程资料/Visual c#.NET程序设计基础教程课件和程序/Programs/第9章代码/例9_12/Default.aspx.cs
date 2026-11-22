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
using System.Web.Configuration;
using System.Data.OleDb;

namespace 例9_12
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection myConn = new System.Data.OleDb.OleDbConnection();
            myConn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + Request.PhysicalApplicationPath + "\\app_data\\nwind.mdb\"";
            OleDbCommand myComm = new OleDbCommand("select ProductID, ProductName from Products where CategoryID=?");
            myComm.Connection = myConn;
            myComm.Parameters.AddWithValue("CategoryID", DropDownList1.SelectedValue);

            myConn.Open();

            OleDbDataReader myReader = myComm.ExecuteReader();
            GridView1.DataSourceID = "";
            GridView1.DataSource = myReader;
            GridView1.DataBind();

            myReader.Close();
            myConn.Close();
        }
    }
}
