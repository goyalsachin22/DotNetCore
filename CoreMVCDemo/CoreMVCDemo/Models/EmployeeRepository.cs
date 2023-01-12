namespace CoreMVCDemo.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> _employees = new List<Employee>();

        public EmployeeRepository()
        {
            _employees.Add(new Employee() { Id = 1, Name = "Sachin", Department = Dept.IT, Email="goyalsachin22@gmail.com"});
            _employees.Add(new Employee() { Id = 2, Name = "Atharv", Department = Dept.HR, Email= "goyalatharv22@gmail.com" });
            _employees.Add(new Employee() { Id = 3, Name = "Krati", Department = Dept.PAYROLL, Email="kj@gmail.com" });
            _employees.Add(new Employee() { Id = 4, Name = "Ankit", Department = Dept.NONE , Email = "ankit17goyal@gmail.com" });
        }

     

        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(emp => emp.Id == id);
        }

        public void saveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employees;
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employees.Max(emp => emp.Id) + 1;
            _employees.Add(employee);

            return employee;
        }
    }
}
