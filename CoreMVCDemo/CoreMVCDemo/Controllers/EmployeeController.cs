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
        public IActionResult Details(int id)
        {
            Employee model = _employeeRepository.GetEmployee(id);
            return View(model);
        }

        public Employee Index()
        {
            return _employeeRepository.GetEmployee(1);
        }
    }
}
