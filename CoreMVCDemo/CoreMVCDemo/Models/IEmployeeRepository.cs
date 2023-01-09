namespace CoreMVCDemo.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);

        void saveEmployee(Employee employee);

    }
}
