using HRM.Web.Enums;
using HRM.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace HRM.Web.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "We need your name")]
        [MinLength(2, ErrorMessage = "Please enter atleat 2 letters")]
        public string Name { get; set; }

        public string? Address { get; set; }

        [Required(ErrorMessage = "We need your email")]
        public string Email { get; set; }

        public Gender Gender { get; set; }

        [Display(Name = "")]
        public DateTime? Dob { get; set; }

        [Display(Name = "Join Date")]
        public DateTime JoinDate { get; set; }

        public string Designation { get; set; }

        [Display(Name = "Upload Your Avatar")]
        public IFormFile ProfileImage { get; set; }

        public string? ProfileImagePath { get; set; }

        [Display(Name = "Department")]
        public string? DepartmentName { get; set; }

        public int DepartmentId { get; set; }
    }
}