using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeAppraisalSystem.Models.ViewModels
{
    // This class represents the ViewModel for the Contract view. It's used to combine
    // the Contract object with several lists of SelectListItem objects to populate dropdowns
    // and select elements in the view.
    public class ContractVM
    {
        // Gets or sets the Contract object, which holds information about the employee's contracts.
        public Contract Contract { get; set; }

        // The [ValidateNever] attribute is used to indicate that this property should not be automatically validated
        // during model binding. In this case, it holds a list of SelectListItem objects for populating a dropdown
        // list in a view, and we don't need validation for it as it's not user input.
        public IEnumerable<SelectListItem> EmployeeList { get; set; }
    }
}
