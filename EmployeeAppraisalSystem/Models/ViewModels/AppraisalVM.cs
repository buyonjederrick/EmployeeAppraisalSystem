using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeAppraisalSystem.Models.ViewModels
{
    // This class represents the ViewModel for the Appraisal view. It's used to combine
    // the Appraisal object with several lists of SelectListItem objects to populate dropdowns
    // and select elements in the view.

    public class AppraisalVM
    {
        // Gets or sets the Appraisal object that holds information about the appraisal.
        public Appraisal Appraisal { get; set; }

        // The following properties are decorated with [ValidateNever].
        // This attribute tells the ASP.NET Core Model Binding system not to validate these properties.

        // Gets or sets a list of SelectListItem objects for displaying employees in a dropdown.
        [ValidateNever]
        public IEnumerable<SelectListItem> EmployeeList { get; set; }

        // Gets or sets a list of SelectListItem objects for displaying objectives in a dropdown.
        [ValidateNever]
        public IEnumerable<SelectListItem> ObjectiveList { get; set; }

        // Gets or sets a list of SelectListItem objects for displaying appraisal periods in a dropdown.
        [ValidateNever]
        public IEnumerable<SelectListItem> AppraisalPeriodList { get; set; }
    }
}
