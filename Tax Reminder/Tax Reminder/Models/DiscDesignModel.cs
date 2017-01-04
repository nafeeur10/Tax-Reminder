using System;

namespace Tax_Reminder.Models
{
    public class DiscDesignModel
    {
        public int Id { get; set; }
        public ApplicationUser VehicleName { get; set; }
        public DateTime TaxDateTime { get; set; }
        public DateTime MotDateTime { get; set; }
    }
}