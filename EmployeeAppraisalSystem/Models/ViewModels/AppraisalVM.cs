using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeAppraisalSystem.Models.ViewModels
{
    public class AppraisalVM
    {
        public Appraisal Appraisal { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> EmployeeList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> ObjectiveList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> AppraisalPeriodList { get; set; }
    }
}
