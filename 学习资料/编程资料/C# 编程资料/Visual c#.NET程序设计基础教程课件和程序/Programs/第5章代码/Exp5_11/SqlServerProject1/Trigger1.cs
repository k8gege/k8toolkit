using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;


public partial class Triggers
{
    // 为目标输入现有表或视图并取消对属性行的注释
    [Microsoft.SqlServer.Server.SqlTrigger(Name = "Trigger1", Target = "Employees", Event = "FOR UPDATE")]
    public static void Trigger1()
    {
        SqlContext.Pipe.Send("Employees表被更新");
    }
}
