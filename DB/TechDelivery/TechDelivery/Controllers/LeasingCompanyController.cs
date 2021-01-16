using TechDelivery.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechDelivery.Controllers
{
    public class LeasingCompanyController : Controller
    {
        private TechDeliveryEntities11 db = new TechDeliveryEntities11();
        // GET: LeasingCompany
        public ActionResult Index()
        {
            var LeasingCompanyList = (from C1 in db.LeasingCompany select C1).ToList();
            return View(LeasingCompanyList);
        }
        public ActionResult ToCarriageTable()
        {
            return Redirect("~/Carriage/Index");
        }
        public ActionResult ToClientTable()
        {
            return Redirect("~/Client/Index");
        }
        public ActionResult ToEmployeesTable()
        {
            return Redirect("~/Employees/Index");
        }
        public ActionResult ToOrderTable()
        {
            return Redirect("~/Order/Index");
        }
        public ActionResult ToLeasingCompanyTable()
        {
            return Redirect("~/LeasingCompany/Index");
        }
        public ActionResult ToStorageTable()
        {
            return Redirect("~/Storage/Index");
        }
        public ActionResult ToTransportTable()
        {
            return Redirect("~/Transport/Index");
        }

        // GET: LeasingCompany/Details/5
        public ActionResult Details(int id)
        {
            var LeasingCompanyDetails = (from C1 in db.LeasingCompany where C1.LeasingCompanyId == id select C1).First();
            return View(LeasingCompanyDetails);
        }

        // GET: LeasingCompany/Create
        public ActionResult Create()
        {
            ViewBag.LSList = new SelectList(db.LeasingCompanyTransportTable, "LSTransportId", "LSTransportTypes");
            return View();
        }

        // POST: Carriage/Create
        [HttpPost]
        public ActionResult Create(LeasingCompany leasingCompany, FormCollection collection)
        {
            db.Entry(leasingCompany).State = EntityState.Added;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Carriage/Edit/5
        public ActionResult Edit(int? id)
        {
            ViewBag.LSList1 = new SelectList(db.LeasingCompanyTransportTable, "LSTransportId", "LSTransportTypes");
            if (id == null)
            {
                return HttpNotFound();
            }
            LeasingCompany leasingCompany = db.LeasingCompany.Find(id);
            if (leasingCompany != null)
            {
                return View(leasingCompany);
            }
            return HttpNotFound();
        }

        // POST: Carriage/Edit/5
        [HttpPost]
        public ActionResult Edit(LeasingCompany leasingCompany, FormCollection collection)
        {
            ViewBag.LSList1 = new SelectList(db.LeasingCompanyTransportTable, "LSTransportId", "LSTransportTypes");
            db.Entry(leasingCompany).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Carriage/Delete/5
        public ActionResult Delete(int id)
        {
            LeasingCompany leasingCompany = db.LeasingCompany.Find(id);
            if (leasingCompany != null)
            {
                db.LeasingCompany.Remove(leasingCompany);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // POST: Carriage/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                return View("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}