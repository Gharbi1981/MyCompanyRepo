using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace MyCompany.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int JobID { get; set; }
        public int DepartmentID { get; set; }

        // Clé étrangère vers Job
        //public int JobID { get; set; }
        // Clé étrangère vers Department
        //public int DepartmentID { get; set; }

        [ForeignKey("JobID")] 
        public Job? Job { get; set; }

        [ForeignKey("DepartmentID")]
        public Department? Department { get; set; }
    }
}
