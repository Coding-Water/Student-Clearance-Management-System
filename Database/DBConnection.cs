
using Microsoft.Data.SqlClient;

namespace Student_Clearance_Management_System.Database
{
    public class DBConnection
    {
        private string connectionString =
            @"Server=DESKTOP-INU2S9E\MSSQLSERVER01;Database=StudentClearanceDB;Trusted_Connection=True;TrustServerCertificate=True;";
        //DESKTOP-INU2S9E\MSSQLSERVER01
        //.\SQLEXPRESS

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public void EnsureDatabaseSchema()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = @"
                        IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateLogs]') AND type in (N'U'))
                        BEGIN
                            CREATE TABLE [dbo].[UpdateLogs](
                                [LogID] [int] IDENTITY(1,1) NOT NULL,
                                [RecordType] [varchar](50) NOT NULL,
                                [RecordID] [varchar](50) NOT NULL,
                                [UpdateDetails] [nvarchar](max) NOT NULL,
                                [PerformedBy] [varchar](50) NOT NULL,
                                [UserRole] [varchar](20) NOT NULL,
                                [ActionDate] [datetime] NOT NULL DEFAULT (getdate()),
                                PRIMARY KEY CLUSTERED ([LogID] ASC)
                            )
                        END";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                // Suppress database schema failures during environment boot
            }
        }
    }
}
