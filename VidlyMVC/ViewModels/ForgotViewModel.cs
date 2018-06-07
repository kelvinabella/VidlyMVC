using System.ComponentModel.DataAnnotations;

namespace VidlyMVC.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
