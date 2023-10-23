using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAppraisalSystem.Models
{
    // This class represents the Contract entity in the Employee Appraisal System.
    public class Contract
    {
        // Unique identifier for the contract.
        public int ContractID { get; set; }

        // The ID of the employee associated with this contract. It is marked for no validation.
        [Display(Name = "Employee")]
        [ValidateNever]
        public int EmployeeID { get; set; }

        // The start date of the contract, with a specified data type for date.
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; } = DateTime.Now;

        // The end date of the contract, with a specified data type for date.
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; } = DateTime.Now;

        // The status of the contract.
        [Display(Name = "Status")]
        public string? Status { get; set; }

        // The department associated with the contract.
        [Display(Name = "Department")]
        public string? Department { get; set; }

        // The position associated with the contract.
        [Display(Name = "Position")]
        public string? Position { get; set; }

        // Navigation property for the associated Employee entity.
        public Employee? Employee { get; set; }
    }
}
