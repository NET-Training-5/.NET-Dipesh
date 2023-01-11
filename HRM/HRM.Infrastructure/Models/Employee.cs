using HRM.ApplicationCore.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }

        public string Email { get; set; }

        public Gender Gender { get; set; }

        public DateTime? Dob { get; set; }
        public DateTime JoinDate { get; set; }

        public string Designation { get; set; }

        public string ProfileImagePath { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }
    }
}