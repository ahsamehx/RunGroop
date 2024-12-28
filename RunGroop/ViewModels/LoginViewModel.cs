using System.ComponentModel.DataAnnotations;

namespace RunGroop.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "Email Address")]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
