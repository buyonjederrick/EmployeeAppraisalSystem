using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAppraisalSystem.Models
{
    // The Objective class represents an individual objective or goal within the employee appraisal system.
    public class Objective
    {
        // Unique identifier for the objective.
        public int ObjectiveID { get; set; }

        // Display name for the objective, shown in user interfaces.
        [Display(Name = "Name Of The Objective")]
        public string? NameOfTheObjective { get; set; }

        // Start date for the activity related to this objective.
        [Display(Name = "Activity Start Date")]
        [DataType(DataType.Date)]
        public DateTime ActivityStartDate { get; set; }

        // End date for the activity related to this objective.
        [Display(Name = "Activity End Date")]
        [DataType(DataType.Date)]
        public DateTime ActivityEndDate { get; set; }

        // Identifier of the employee associated with this objective.
        [Display(Name = "Employee Name")]
        public int EmployeeID { get; set; }

        // Navigation property to represent the associated employee.
        public Employee? Employee { get; set; }

        // Collection of appraisals related to this objective.
        public List<Appraisal>? Appraisals { get; set; }
    }
}
