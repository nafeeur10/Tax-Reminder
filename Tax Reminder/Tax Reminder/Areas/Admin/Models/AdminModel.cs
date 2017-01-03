using System.Collections.Generic;
using Tax_Reminder.Models;

namespace Tax_Reminder.Areas.Admin.Models
{
    public class AdminModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<TaxInformationModel> TaxInformationModels { get; set; }
    }
}