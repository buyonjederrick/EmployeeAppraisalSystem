using System.ComponentModel.DataAnnotations;

namespace EmployeeAppraisalSystem.Models
{
    // The Appraisal class represents an appraisal record in the Employee Appraisal System.
    public class Appraisal
    {
        // Unique identifier for the appraisal.
        public int AppraisalID { get; set; }

        // The ID of the associated objective for this appraisal.
        [Display(Name = "Objective")]
        public int ObjectiveID { get; set; }

        // The ID of the appraisal period to which this appraisal belongs.
        [Display(Name = "Appraisal Period")]
        public int AppraisalPeriodID { get; set; }

        // The rating given to the employee's performance in this appraisal, within the range of 1 to 5.
        [Display(Name = "Rating")]
        [Range(1, 5, ErrorMessage = "Rating Must be 1-5")]
        public int Rating { get; set; }

        // Additional comments or notes regarding the appraisal.
        [Display(Name = "Appraisal Comment")]
        public string? Comment { get; set; }

        // The ID of the employee being appraised.
        [Display(Name = "Employee Name")]
        public int EmployeeID { get; set; }

        // The current workflow status of the appraisal.
        [Display(Name = "Workflow Status")]
        public string? WorkflowStatus { get; set; }

        // Comments from the approver of the appraisal.
        [Display(Name = "Approver Comment")]
        public string? ApproverComment { get; set; }

        // Navigation properties to related objects (Objectives, AppraisalPeriod, and Employee).
        public Objective? Objective { get; set; }
        public AppraisalPeriod? AppraisalPeriod { get; set; }
        public Employee? Employee { get; set; }
    }
}
