using System.Data.SqlClient;

namespace FMM_Application.App.DataAccess.Connection
{
    public sealed class Connection
    {

        //connect dbs...
        public static SqlConnection connect()
        {
            return new SqlConnection(@"Data Source=ServerName;Initial Catalog=DatabaseName;Integrated Security=True");
        }

    }
}
