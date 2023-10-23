using EmployeeAppraisalSystem.Data;
using EmployeeAppraisalSystem.Models;
using EmployeeAppraisalSystem.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAppraisalSystem.Controllers
{
    public class ContractController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ContractController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Contract> objContractList = _db.Contracts.Include(u => u.Employee).ToList();
            
            return View(objContractList);
        }

        public IActionResult Create()
        {
            IEnumerable<SelectListItem> EmployeeList = _db.Employees.Select(u => new SelectListItem
            {
                Text = u.FirstName + " " + u.LastName,
                Value = u.EmployeeID.ToString(),
            });

            //ViewBag.EmployeeList = EmployeeList;

            ContractVM contractVM = new()
            {
                EmployeeList = EmployeeList,
                Contract = new Contract()
            };
            return View(contractVM);
        }
        [HttpPost]
        public IActionResult Create(ContractVM obj)
        {
            if (ModelState.IsValid)
            {
                _db.Contracts.Add(obj.Contract);
                _db.SaveChanges();
                TempData["success"] = "Employee Contract Data Created Successfully";
                return RedirectToAction("Index", "Contract");
            }

            return View();

        }
    }
}
