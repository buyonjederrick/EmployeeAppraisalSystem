using EmployeeAppraisalSystem.Data;
using EmployeeAppraisalSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAppraisalSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Employee> objEmployeeList = _db.Employees.ToList();
            return View(objEmployeeList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            

           
            if (ModelState.IsValid)
            {
                _db.Employees.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Employee Data Created Successfully";
                return RedirectToAction("Index", "Employee");
            }

            return View();

        }
    }
}
