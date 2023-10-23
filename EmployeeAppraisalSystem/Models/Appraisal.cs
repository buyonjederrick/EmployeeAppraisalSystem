using System.ComponentModel.DataAnnotations;

namespace EmployeeAppraisalSystem.Models
{
    public class Appraisal
    {
        public int AppraisalID { get; set; }
        [Display(Name = "Objective")]
        public int ObjectiveID { get; set; }
        [Display(Name = "Appraisal Period")]
        public int AppraisalPeriodID { get; set; }

        [Display(Name = "Rating")]
        [Range(1, 5, ErrorMessage = "Rating Must be 1-5")]
        public int Rating { get; set; }
        [Display(Name = "Appraisal Comment")]
        public string? Comment { get; set; }
        [Display(Name = "Employee Name")]
        public int EmployeeID { get; set; }
        [Display(Name = "Workflow Status")]
        public string? WorkflowStatus { get; set; }
        [Display(Name = "Approver Comment")]
        public string? ApproverComment { get; set; }

        public Objective? Objective { get; set; }
        public AppraisalPeriod? AppraisalPeriod { get; set; }
        public Employee? Employee { get; set; }
    }
}
