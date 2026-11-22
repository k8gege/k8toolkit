using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;


public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void UpdateEmployeeName(SqlString EmployeeID, SqlString LastName, SqlString FirstName)
    {
        SqlConnection con = new SqlConnection("context connection=true");
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "update Employees set LastName=@p1,FirstName=@p2 where EmployeeID=@p3";
        SqlParameter p1 = new SqlParameter("@p1", LastName);
        SqlParameter p2 = new SqlParameter("@p2", FirstName);
        SqlParameter p3 = new SqlParameter("@p3", EmployeeID);
        cmd.Parameters.Add(p1);
        cmd.Parameters.Add(p2);
        cmd.Parameters.Add(p3);
        int i=cmd.ExecuteNonQuery();
        con.Close();
        SqlContext.Pipe.Send(i.ToString());
    }
};
