using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Tax_Reminder.Models;

namespace Tax_Reminder.Controllers
{
    public class AdminPanelController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TaxInformationModels
        public ActionResult Index()
        {
            return View(db.TaxInformationModels.ToList());
        }

        // GET: TaxInformationModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaxInformationModel taxInformationModel = db.TaxInformationModels.Find(id);
            if (taxInformationModel == null)
            {
                return HttpNotFound();
            }
            return View(taxInformationModel);
        }

        // GET: TaxInformationModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaxInformationModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,VehicleRegistration,VehicleMake,Email,ReferralCode,CardNumber,CvcSecurityCode,Expiry,IsAgree")] TaxInformationModel taxInformationModel)
        {
            if (ModelState.IsValid)
            {
                db.TaxInformationModels.Add(taxInformationModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taxInformationModel);
        }

        // GET: TaxInformationModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaxInformationModel taxInformationModel = db.TaxInformationModels.Find(id);
            if (taxInformationModel == null)
            {
                return HttpNotFound();
            }
            return View(taxInformationModel);
        }

        // POST: TaxInformationModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,VehicleRegistration,VehicleMake,Email,ReferralCode,CardNumber,CvcSecurityCode,Expiry,IsAgree")] TaxInformationModel taxInformationModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taxInformationModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taxInformationModel);
        }

        // GET: TaxInformationModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaxInformationModel taxInformationModel = db.TaxInformationModels.Find(id);
            if (taxInformationModel == null)
            {
                return HttpNotFound();
            }
            return View(taxInformationModel);
        }

        // POST: TaxInformationModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TaxInformationModel taxInformationModel = db.TaxInformationModels.Find(id);
            db.TaxInformationModels.Remove(taxInformationModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
