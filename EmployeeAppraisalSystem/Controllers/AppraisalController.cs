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

        public AppraisalController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Appraisal> objAppraisalList = _db.Appraisals.Include(u => u.Employee).Include(u => u.Objective).Include(u => u.AppraisalPeriod).ToList();
            return View(objAppraisalList);
        }

        public IActionResult Create()
        {
            IEnumerable<SelectListItem> EmployeeList = _db.Employees.Select(u => new SelectListItem
            {
                Text = u.FirstName + " " + u.LastName,
                Value = u.EmployeeID.ToString(),
            });

            IEnumerable<SelectListItem> ObjectiveList = _db.Objectives.Select(u => new SelectListItem
            {
                Text = u.NameOfTheObjective,
                Value = u.ObjectiveID.ToString(),
            });

            IEnumerable<SelectListItem> AppraisalPeriodList = _db.AppraisalPeriods.Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.AppraisalPeriodID.ToString(),
            });

            AppraisalVM appraisalVM = new()
            {
                EmployeeList = EmployeeList,
                ObjectiveList = ObjectiveList,
                AppraisalPeriodList = AppraisalPeriodList,
                Appraisal = new Appraisal()
            };
            return View(appraisalVM);
        }
        [HttpPost]
        public IActionResult Create(AppraisalVM obj)
        {
            if (ModelState.IsValid)
            {
                _db.Appraisals.Add(obj.Appraisal);
                _db.SaveChanges();
                TempData["success"] = "Employee Appraisal Data Created successfully";
                return RedirectToAction("Index", "Appraisal");
            }

            return View();

        }
    }
}
