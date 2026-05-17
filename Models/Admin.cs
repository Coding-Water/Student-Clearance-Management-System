using System;

namespace Student_Clearance_Management_System.Models
{
   public class Admin : User
   {
     public bool CanManageRecords()
      {
         return true;
      }
   }
}

//admin will inherit from user
