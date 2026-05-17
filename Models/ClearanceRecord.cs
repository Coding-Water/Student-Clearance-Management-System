using System;

namespace Student_Clearance_Management_System.Models
{
    public class ClearanceRecord
    {
        public int ClearanceID { get; set; }
        public int StudentID { get; set; }
        public int DepartmentID { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
    }
}
