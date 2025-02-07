using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MyCompany.Models
{
    public class Job
    {
        public int JobID { get; set; }
        public string JobName { get; set; } = string.Empty;
        [JsonIgnore]
        public ICollection<Employee>? Employees { get; set; }
    }
}




