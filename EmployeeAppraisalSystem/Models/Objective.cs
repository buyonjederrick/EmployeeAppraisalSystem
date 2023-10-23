using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAppraisalSystem.Models
{
    public class Objective
    {
        public int ObjectiveID { get; set; }
        [Display(Name = "Name Of The Objective")]
        public string? NameOfTheObjective { get; set; }
        [Display(Name = "Activity Start Date")]
        [DataType(DataType.Date)]
        public DateTime ActivityStartDate { get; set; }
        [Display(Name = "Activity End Date")]
        [DataType(DataType.Date)]
        public DateTime ActivityEndDate { get; set; }
        [Display(Name = "Employee Name")]
        public int EmployeeID { get; set; }

        public Employee? Employee { get; set; }
        public List<Appraisal>? Appraisals { get; set; }
    }
}
