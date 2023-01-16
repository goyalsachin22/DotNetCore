using Microsoft.EntityFrameworkCore;

namespace CoreMVCDemo.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
             new Employee
             {
                 Id = 1,
                 Email = "markRuffalo@pragimtech",
                 Name = "MarkRufflo",
                 Department = Dept.PAYROLL,
                 PhotoPath = "noimage.png"
             },
             new Employee
             {
                 Id = 2,
                 Email = "John@pragrimtech",
                 Name = "Jonn",
                 Department = Dept.HR,
                 PhotoPath = "noimage.png"
             });
        }
    }
}
