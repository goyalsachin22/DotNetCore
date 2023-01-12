namespace CoreMVCDemo.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> _employees = new List<Employee>();

        public EmployeeRepository()
        {
            _employees.Add(new Employee() { Id = 1, Name = "Sachin", Department = "S4Hana" });
            _employees.Add(new Employee() { Id = 2, Name = "Atharv", Department = "S4HanaCloud" });
            _employees.Add(new Employee() { Id = 3, Name = "Krati", Department = "CRM" });
            _employees.Add(new Employee() { Id = 4, Name = "Ankit", Department = "Goyal" });
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
    }
}
