using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAppraisalSystem.Models
{
    // The AppraisalPeriod class represents a period within the employee appraisal system.
    public class AppraisalPeriod
    {
        // Unique identifier for the appraisal period.
        public int AppraisalPeriodID { get; set; }

        // The title or name of the appraisal period, displayed as "Appraisal Period Title."
        [DisplayName("Appraisal Period Title")]
        public string? Name { get; set; }

        // The start date for reporting during the appraisal period, displayed as "Reporting Start Date."
        [DisplayName("Reporting Start Date")]
        [DataType(DataType.Date)]
        public DateTime ReportingStartDate { get; set; } = DateTime.Now;

        // The end date for reporting during the appraisal period, displayed as "Reporting End Date."
        [DisplayName("Reporting End Date")]
        [DataType(DataType.Date)]
        public DateTime ReportingEndDate { get; set; } = DateTime.Now;

        // A collection of appraisal records associated with this appraisal period.
        public List<Appraisal>? Appraisals { get; set; }
    }
}
