using System.ComponentModel.DataAnnotations;

namespace Omadiko.WebApp.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
