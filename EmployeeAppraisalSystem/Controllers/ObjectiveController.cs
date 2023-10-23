using EmployeeAppraisalSystem.Data;
using EmployeeAppraisalSystem.Models;
using EmployeeAppraisalSystem.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAppraisalSystem.Controllers
{
    public class ObjectiveController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ObjectiveController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Objective> objObjectiveList = _db.Objectives.Include(u => u.Employee).ToList();

            return View(objObjectiveList);
        }

        public IActionResult Create()
        {
            IEnumerable<SelectListItem> EmployeeList = _db.Employees.Select(u => new SelectListItem
            {
                Text = u.FirstName + " " + u.LastName,
                Value = u.EmployeeID.ToString(),
            });

            ObjectiveVM objectiveVM = new()
            {
                EmployeeList = EmployeeList,
                Objective = new Objective()
            };
            return View(objectiveVM);
        }
        [HttpPost]
        public IActionResult Create(ObjectiveVM obj)
        {
            if (ModelState.IsValid)
            {
                _db.Objectives.Add(obj.Objective);
                _db.SaveChanges();
                TempData["success"] = "Objective Data Created Successfully";
                return RedirectToAction("Index", "Objective");
            }

            return View();

        }
    }
}
