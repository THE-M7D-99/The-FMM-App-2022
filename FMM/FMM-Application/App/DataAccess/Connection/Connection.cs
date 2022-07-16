using System;
using System.Data.SqlClient;

namespace FMM_Application.App.DataAccess.Connection
{
    public sealed class Connection
    {
        static String serverName = ".\\SQLEXPRESS";
        static String DB = "phfm_db";

        //connect dbs...
        public static SqlConnection connect()
        {
            return new SqlConnection(@"Server= " + serverName + "; Database = " + DB + " ; Integrated Security = true");
        }



    }
}
