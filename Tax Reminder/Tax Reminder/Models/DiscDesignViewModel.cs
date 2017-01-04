using System.ComponentModel.DataAnnotations;

namespace Tax_Reminder.Models
{
    public class DiscDesignViewModel
    {
        [Required]
        public string VehicleName { get; set; }

        [Required]
        public int TaxDay { get; set; }

        [Required]
        public int TaxMonth { get; set; }

        [Required]
        public int TaxYear { get; set; }

        [Required]
        public int MotDay { get; set; }

        [Required]
        public int MotMonth { get; set; }

        [Required]
        public int MotYear { get; set; }
    }
}