using TechDelivery.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechDelivery.Controllers
{
    public class CarriageController : Controller
    {
        private TechDeliveryEntities11 db = new TechDeliveryEntities11();
        // GET: Carriage
        public ActionResult Index()
        {
            var CarriageList = (from C1 in db.Carriage select C1).ToList();
            return View(CarriageList);
        }

        // GET: Carriage/Details/5
        public ActionResult Details(int id)
        {
            var CarriageDetails = (from C1 in db.Carriage where C1.CarriageId == id select C1).First();
            return View(CarriageDetails);
        }

        // GET: Carriage/Create
        public ActionResult Create()
        {
            ViewBag.TransportTypeList1 = new SelectList(db.Transport, "TransportId", "TransportType");
            return View();
        }

        // POST: Carriage/Create
        [HttpPost]
        public ActionResult Create(Carriage carriage, FormCollection collection)
        {
            db.Entry(carriage).State = EntityState.Added;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Carriage/Edit/5
        public ActionResult Edit(int? id)
        {
            ViewBag.TransportTypeList = new SelectList(db.Transport, "TransportId", "TransportType");
            if (id == null)
            {
                return HttpNotFound();
            }
            Carriage carriage = db.Carriage.Find(id);
            if (carriage != null)
            {
                return View(carriage);
            }
            return HttpNotFound();
        }

        // POST: Carriage/Edit/5
        [HttpPost]
        public ActionResult Edit(Carriage carriage, FormCollection collection)
        {
            ViewBag.TransportTypeList = new SelectList(db.Transport, "TransportId", "TransportType");
            db.Entry(carriage).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Carriage/Delete/5
        public ActionResult Delete(int id)
        {
            Carriage carriage = db.Carriage.Find(id);
            if (carriage != null)
            {
                db.Carriage.Remove(carriage);
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
