using System;

namespace Tax_Reminder.Models
{
    public class TaxInformationModel
    {
        public int Id { get; set; }
        public int VehicleRegistration { get; set; }
        public string VehicleMake { get; set; }
        public string Email { get; set; }
        public string ReferralCode { get; set; }
        public int CardNumber { get; set; }
        public string CvcSecurityCode { get; set; }
        public DateTime Expiry { get; set; }
        public bool IsAgree { get; set; }
    }
}