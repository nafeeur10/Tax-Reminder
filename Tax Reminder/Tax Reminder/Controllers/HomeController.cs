using System;
using System.Linq;
using System.Web.Mvc;
using Tax_Reminder.Models;

namespace Tax_Reminder.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;

        public HomeController()
        {
            db = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
             return View();
        }


        [Authorize]
        public ActionResult TaxInformation()     
        {  
            return View();
        }

        // POST: Home/TaxInformation
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TaxInformation([Bind(Include = "Id,VehicleRegistration,VehicleMake,Email,ReferralCode,CardNumber,CvcSecurityCode,Expiry,IsAgree")] TaxInformationModel taxInformation)
        {
            if (ModelState.IsValid)
            {
                db.TaxInformationModels.Add(taxInformation);
                db.SaveChanges();
                return RedirectToAction("ThankYou", "Home");
            }

            return View(taxInformation);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult ThankYou()
        {
            return View();
        }

        [Authorize]
        public ActionResult DiscDesign(DiscDesignViewModel discDesignView)
        {
            var discDesign = new DiscDesignModel()
            {
                VehicleName = db.Users.Single(u => u.Id == discDesignView.VehicleName),
                TaxDateTime = DateTime.Parse(string.Format("{0} {1} {2} ", discDesignView.TaxDay, discDesignView.TaxMonth, discDesignView.TaxYear)),
                MotDateTime = DateTime.Parse(string.Format("{0} {1} {2} ", discDesignView.MotDay, discDesignView.MotMonth, discDesignView.MotYear))
            };

            db.DiscDesignModels.Add(discDesign);
            db.SaveChanges();

            return RedirectToAction("ThankYou", "Home");
        }
    }
}