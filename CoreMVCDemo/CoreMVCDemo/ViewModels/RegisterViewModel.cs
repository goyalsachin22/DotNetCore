using System.ComponentModel.DataAnnotations;

namespace CoreMVCDemo.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password", ErrorMessage = "Password & Confirm Password do not match")]
        public string ConfirmPassword { get; set;}
    }
}
