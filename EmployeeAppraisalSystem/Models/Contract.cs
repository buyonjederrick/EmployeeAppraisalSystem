using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAppraisalSystem.Models
{
    public class Contract
    {
        public int ContractID { get; set; }
        [Display(Name = "Employee")]

        [ValidateNever]
        public int EmployeeID { get; set; }
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        [Display(Name = "Status")]
        public string? Status { get; set; }
        [Display(Name = "Department")]
        public string? Department { get; set; }
        [Display(Name = "Position")]
        public string? Position { get; set; }

        public Employee? Employee { get; set; }
    }
}
