namespace CoreMVCDemo.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);

        IEnumerable<Employee> GetAllEmployees();

        void saveEmployee(Employee employee);
        Employee Add(Employee employee);
    }
}
