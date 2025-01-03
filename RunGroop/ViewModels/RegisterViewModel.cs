using System.ComponentModel.DataAnnotations;

namespace RunGroop.ViewModels
{
    public class RegisterViewModel
    {
        [Display (Name = "Email Address")]
        [Required (ErrorMessage ="Email Address is required")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType (DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm password is required")]
        [Display(Name  = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password doesn't match")]
        public string ConfirmPassword { get; set; }
    }
}
