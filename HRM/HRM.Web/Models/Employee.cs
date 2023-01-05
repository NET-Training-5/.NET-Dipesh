﻿using HRM.Web.Enums;
using System.ComponentModel.DataAnnotations;

namespace HRM.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public Gender Gender { get; set; }

        public DateTime? Dob { get; set; }
        public DateTime JoinDate { get; set; }

        public string Department { get; set; }

        public string Designation { get; set; }
    }
}