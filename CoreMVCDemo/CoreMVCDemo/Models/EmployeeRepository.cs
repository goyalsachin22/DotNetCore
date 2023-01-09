namespace CoreMVCDemo.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> _employees = new List<Employee>();

        public EmployeeRepository()
        {
            _employees.Add(new Employee() { Id = 1, Name = "Sachin", Department = "S4Hana" });
        }
      

        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(emp => emp.Id == id);
        }

        public void saveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
