using System.ComponentModel.DataAnnotations;

namespace CoreMVCDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }
        [Required]
        [Display(Name= "Office Email")]
        public string Email { get; set; }

        [Required]
        public Dept?  Department { get; set; }

        public String PhotoPath { get; set; }

    }
}
