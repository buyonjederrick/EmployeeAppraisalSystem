using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Security.AccessControl;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EmployeeAppraisalSystem.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? NIN { get; set; }
        public string? TelephoneNumber { get; set; }

        public List<Contract>? Contracts { get; set; }
        public List<Objective>? Objectives { get; set; }
        public List<Appraisal>? Appraisals { get; set; }

    }
}
