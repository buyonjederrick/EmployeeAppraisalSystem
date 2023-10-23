using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeAppraisalSystem.Models.ViewModels
{
    // The ObjectiveVM class represents a ViewModel used for displaying objective-related data in views.
    public class ObjectiveVM
    {
        // Gets or sets the Objective object, which holds information about the employee's objectives.
        public Objective Objective { get; set; }

        // The [ValidateNever] attribute is used to indicate that this property should not be automatically validated
        // during model binding. In this case, it holds a list of SelectListItem objects for populating a dropdown
        // list in a view, and we don't need validation for it as it's not user input.
        [ValidateNever]
        public IEnumerable<SelectListItem> EmployeeList { get; set; }
    }
}
