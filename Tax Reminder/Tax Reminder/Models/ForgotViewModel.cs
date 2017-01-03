using System.ComponentModel.DataAnnotations;

namespace Tax_Reminder.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}