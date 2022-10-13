using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace WebApiCoreproject.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Emp_Id { get; set; }
        public string? Emp_FirstName { get; set; }
        public string? Emp_lastName { get; set; }
        public DateTime Emp_dob { get; set; }
        public string?  Emp_Contact { get; set; }
        public string? Emp_Email { get; set; }
    }
}
