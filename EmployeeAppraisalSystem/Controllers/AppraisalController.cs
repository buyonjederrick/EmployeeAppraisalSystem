using EmployeeAppraisalSystem.Data;
using EmployeeAppraisalSystem.Models;
using EmployeeAppraisalSystem.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAppraisalSystem.Controllers
{
    public class AppraisalController : Controller
    {
        private readonly ApplicationDbContext _db;

        // Constructor to initialize the database context
        public AppraisalController(ApplicationDbContext db)
        {
            _db = db;
        }

        // Action to display a list of appraisals
        public IActionResult Index()
        {
            // Fetch a list of appraisals including related data (Employee, Objective, AppraisalPeriod)
            List<Appraisal> objAppraisalList = _db.Appraisals.Include(u => u.Employee).Include(u => u.Objective).Include(u => u.AppraisalPeriod).ToList();
            return View(objAppraisalList);
        }

        // Action to create a new appraisal
        public IActionResult Create()
        {
            // Create a list of SelectListItem for Employees
            IEnumerable<SelectListItem> EmployeeList = _db.Employees.Select(u => new SelectListItem
            {
                Text = u.FirstName + " " + u.LastName,
                Value = u.EmployeeID.ToString(),
            });

            // Create a list of SelectListItem for Objectives
            IEnumerable<SelectListItem> ObjectiveList = _db.Objectives.Select(u => new SelectListItem
            {
                Text = u.NameOfTheObjective,
                Value = u.ObjectiveID.ToString(),
            });

            // Create a list of SelectListItem for Appraisal Periods
            IEnumerable<SelectListItem> AppraisalPeriodList = _db.AppraisalPeriods.Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.AppraisalPeriodID.ToString(),
            });

            // Create an instance of the AppraisalVM view model and initialize it with the lists and an empty Appraisal object
            AppraisalVM appraisalVM = new()
            {
                EmployeeList = EmployeeList,
                ObjectiveList = ObjectiveList,
                AppraisalPeriodList = AppraisalPeriodList,
                Appraisal = new Appraisal()
            };
            return View(appraisalVM);
        }

        // Action to handle the HTTP POST request for creating a new appraisal
        [HttpPost]
        public IActionResult Create(AppraisalVM obj)
        {
            if (ModelState.IsValid)
            {
                // If the model state is valid, add the new appraisal to the database, save changes, and redirect to the Index action
                _db.Appraisals.Add(obj.Appraisal);
                _db.SaveChanges();
                TempData["success"] = "Employee Appraisal Data Created successfully"; // Temporary success message
                return RedirectToAction("Index", "Appraisal");
            }

            // If the model state is not valid, return to the Create view to display validation errors
            return View();
        }
    }
}
