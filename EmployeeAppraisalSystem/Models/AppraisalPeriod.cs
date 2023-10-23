using System.ComponentModel;

namespace EmployeeAppraisalSystem.Models
{
    public class AppraisalPeriod
    {
        public int AppraisalPeriodID { get; set; }
        [DisplayName("Appraisal Period Title")]
        public string? Name { get; set; }
        [DisplayName("Reporting Start Date")]
        public DateTime ReportingStartDate { get; set; }
        [DisplayName("Reporting End Date")]
        public DateTime ReportingEndDate { get; set; }

        public List<Appraisal>? Appraisals { get; set; }
    }
}
