using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlDouble Function1(SqlDouble Length, SqlDouble Width, SqlDouble Height)
    {
        // 在此处放置代码
        return (Length * Width * Height);
    }
};

