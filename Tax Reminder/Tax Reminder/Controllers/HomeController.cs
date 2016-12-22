using System.Web.Mvc;

namespace Tax_Reminder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
             return View();
        }


        [Authorize]
        public ActionResult TaxInformation()     
        {      
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}