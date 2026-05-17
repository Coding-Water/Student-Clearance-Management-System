
using Microsoft.Data.SqlClient;

namespace Student_Clearance_Management_System.Database
{
    public class DBConnection
    {
        private string connectionString =
            @"Server=DESKTOP-INU2S9E\MSSQLSERVER01;Database=StudentClearanceDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
