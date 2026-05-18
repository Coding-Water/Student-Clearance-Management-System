
namespace Student_Clearance_Management_System.Models
{
    // ENCAPSULATION: Properties (getters and setters) encapsulate the class's data,
    // controlling how state is accessed and modified.
    public static class AppSession
    {
        public static int LoggedInUserID { get; set; }
        public static string LoggedInUsername { get; set; } = string.Empty;
        public static string LoggedInRole { get; set; } = string.Empty;

        public static int SelectedTermID { get; set; }
        public static string SelectedTermText { get; set; } = string.Empty;
    }
}
