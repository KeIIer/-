using TechDelivery.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechDelivery.Controllers
{
    public class StorageController : Controller
    {
        // GET: Storage
        private TechDeliveryEntities11 db = new TechDeliveryEntities11();
        public ActionResult Index()
        {
            var StorageList = (from S1 in db.Storage select S1).ToList();
            return View(StorageList);
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
        public ActionResult ToLeasingCompanyTable()
        {
            return Redirect("~/LeasingCompany/Index");
        }
        public ActionResult ToOrderTable()
        {
            return Redirect("~/Order/Index");
        }
        public ActionResult ToTransportTable()
        {
            return Redirect("~/Transport/Index");
        }
        // GET: Storage/Details/5
        public ActionResult Details(int id)
        {
            var StorageDetails = (from C1 in db.Storage where C1.StorageId == id select C1).First();
            return View(StorageDetails);
        }

        // GET: Storage/Create
        public ActionResult Create(Storage storage)
        {
            ViewBag.StorageTypesList = new SelectList(db.StorageTypeTable, "TypeId", "StorageTypes");
            return View();
        }

        // POST: Storage/Create
        [HttpPost]
        public ActionResult Create(Storage storage, FormCollection collection)
        {
            db.Entry(storage).State = EntityState.Added;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Storage/Edit/5
        public ActionResult Edit(int? id)
        {
            ViewBag.StorageTypesList1 = new SelectList(db.StorageTypeTable, "TypeId", "StorageTypes");
            if (id == null)
            {
                return HttpNotFound();
            }
            Storage storage = db.Storage.Find(id);
            if (storage != null)
            {
                return View(storage);
            }
            return HttpNotFound();
        }

        // POST: Storage/Edit/5
        [HttpPost]
        public ActionResult Edit(Storage order, FormCollection collection)
        {
            ViewBag.StorageTypesList1 = new SelectList(db.StorageTypeTable, "TypeId", "StorageTypes");
            db.Entry(order).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Storage/Delete/5
        public ActionResult Delete(int id)
        {
            Storage storage = db.Storage.Find(id);
            if (storage != null)
            {
                db.Storage.Remove(storage);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // POST: Storage/Delete/5
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