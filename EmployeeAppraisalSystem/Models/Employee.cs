using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Security.AccessControl;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EmployeeAppraisalSystem.Models
{
    // This class represents an Employee in the Employee Appraisal System.
    public class Employee
    {
        // Unique identifier for the employee.
        public int EmployeeID { get; set; }

        // First name of the employee.
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        // Last name of the employee.
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        // Email address of the employee.
        [Display(Name = "Email Address")]
        public string? EmailAddress { get; set; }

        // Date of birth of the employee.
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; } = DateTime.Now;

        // National Identification Number (NIN) of the employee.
        // 
        [Display(Name = "National Identification Number (NIN)")]
        public string? NIN { get; set; }

        // Telephone number of the employee.
        [Display(Name = "Telephone Number")]
        public string? TelephoneNumber { get; set; }

        // A list of contracts associated with the employee.
        public List<Contract>? Contracts { get; set; }

        // A list of objectives associated with the employee. 
        public List<Objective>? Objectives { get; set; }

        // A list of appraisals associated with the employee.
        public List<Appraisal>? Appraisals { get; set; }
    }
}
