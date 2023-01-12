using CoreMVCDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }
        public ViewResult Index()
        {
            IEnumerable<Employee> model = _employeeRepository.GetAllEmployees();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            Employee model = _employeeRepository.GetEmployee(id);
            ViewData["Title"] = "Employee Details View";
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if(ModelState.IsValid)
            {
                Employee newEmployee = _employeeRepository.Add(employee);
                return RedirectToAction("details", new { id = newEmployee.Id }); 
            }

            return View();
          
        }
    }
}
