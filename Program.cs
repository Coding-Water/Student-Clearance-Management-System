using Student_Clearance_Management_System.Forms;
using Student_Clearance_Management_System.Database;

namespace Student_Clearance_Management_System
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            
            try
            {
                new DBConnection().EnsureDatabaseSchema();
            }
            catch {}

            Application.Run(new StudentLoginForm());
        }
    }
}
