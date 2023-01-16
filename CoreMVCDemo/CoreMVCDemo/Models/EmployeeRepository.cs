namespace CoreMVCDemo.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> _employees = new List<Employee>();

        public EmployeeRepository()
        {
            _employees.Add(new Employee() { Id = 1, Name = "Sachin", Department = Dept.IT, Email = "goyalsachin22@gmail.com" });
            _employees.Add(new Employee() { Id = 2, Name = "Atharv", Department = Dept.HR, Email = "goyalatharv22@gmail.com" });
            _employees.Add(new Employee() { Id = 3, Name = "Krati", Department = Dept.PAYROLL, Email = "kj@gmail.com" });
            _employees.Add(new Employee() { Id = 4, Name = "Ankit", Department = Dept.NONE, Email = "ankit17goyal@gmail.com" });
        }



        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(emp => emp.Id == id);
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

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employees.FirstOrDefault(emp => emp.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
                employee.Name = employeeChanges.Name;
            }
            return employee;

        }

        public Employee Delete(int id)
            {
                Employee employee = _employees.FirstOrDefault(emp => emp.Id == id);
                if (employee != null)
                {
                    _employees.Remove(employee);
                }
                return employee;
            }
        }
    }
