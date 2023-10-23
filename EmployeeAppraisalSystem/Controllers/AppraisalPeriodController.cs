using EmployeeAppraisalSystem.Data;
using EmployeeAppraisalSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAppraisalSystem.Controllers
{
    public class AppraisalPeriodController : Controller
    {
        private readonly ApplicationDbContext _db;

        // Constructor to initialize the database context
        public AppraisalPeriodController(ApplicationDbContext db)
        {
            _db = db;
        }

        // Action to display a list of Appraisal Period
        public IActionResult Index()
        {
            List<AppraisalPeriod> objAppraisalPeriodList = _db.AppraisalPeriods.ToList();
            return View(objAppraisalPeriodList);
            
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AppraisalPeriod obj)
        {



            if (ModelState.IsValid)
            {
                _db.AppraisalPeriods.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Appraisal Period Data Created successfully";
                return RedirectToAction("Index", "AppraisalPeriod");
            }

            return View();

        }
    }
}
