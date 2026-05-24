using Student_Clearance_Management_System.Forms;

namespace Student_Clearance_Management_System
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new StudentLoginForm());
        }
    }
}
