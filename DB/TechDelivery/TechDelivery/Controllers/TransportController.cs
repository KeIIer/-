using TechDelivery.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechDelivery.Controllers
{
    public class TransportController : Controller
    {
        private TechDeliveryEntities11 db = new TechDeliveryEntities11();
        // GET: Transport
        public ActionResult Index()
        {
            var TransportList = (from C1 in db.Transport select C1).ToList();
            return View(TransportList);
        }

        // GET: Transport/Details/5
        public ActionResult Details(int id)
        {
            var TransportDetails = (from C1 in db.Transport where C1.TransportId == id select C1).First();
            return View(TransportDetails);
        }

        // GET: Transport/Create
        public ActionResult Create(Transport transport)
        {
            SelectList companies = new SelectList(db.LeasingCompany, "LeasingCompanyId", "LeasingCompanyName");
            ViewBag.Companies = companies;
            return View();
        }

        // POST: Transport/Create
        [HttpPost]
        public ActionResult Create(Transport transport, FormCollection collection)
        {

            db.Entry(transport).State = EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Transport/Edit/5
        public ActionResult Edit(int? id)
        {
            SelectList companies = new SelectList(db.LeasingCompany, "LeasingCompanyId", "LeasingCompanyName");
            ViewBag.Companies = companies;
            if (id == null)
            {
                return HttpNotFound();
            }
            Transport transport = db.Transport.Find(id);
            if (transport != null)
            {
                return View(transport);
            }
            return HttpNotFound();
        }

        // POST: Carriage/Edit/5
        [HttpPost]
        public ActionResult Edit(Transport transport, FormCollection collection)
        {
            db.Entry(transport).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Carriage/Delete/5
        public ActionResult Delete(int id)
        {
            Transport transport = db.Transport.Find(id);
            if (transport != null)
            {
                db.Transport.Remove(transport);
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