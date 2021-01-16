using TechDelivery.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechDelivery.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        private TechDeliveryEntities11 db = new TechDeliveryEntities11();
        public ActionResult Index()
        {
            var OrderList = (from O1 in db.OrderTable select O1).ToList();
            return View(OrderList);
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
        public ActionResult ToStorageTable()
        {
            return Redirect("~/Storage/Index");
        }
        public ActionResult ToTransportTable()
        {
            return Redirect("~/Transport/Index");
        }
        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            var OrderDetails = (from C1 in db.OrderTable where C1.OrderId == id select C1).First();
            return View(OrderDetails);
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            ViewBag.ClientList = new SelectList(db.Client, "ClientId", "ClientName");
            ViewBag.StorageList = new SelectList(db.Storage, "StorageId", "StorageName");
            ViewBag.AnotherEmployeeReferenceList = new SelectList(db.Employees, "EmployeeId", "EmployeeName");
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(OrderTable order, FormCollection collection)
        {
            db.Entry(order).State = EntityState.Added;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Carriage/Edit/5
        public ActionResult Edit(int? id)
        {
            ViewBag.ClientList1 = new SelectList(db.Client, "ClientId", "ClientName");
            ViewBag.StorageList1 = new SelectList(db.Storage, "StorageId", "StorageName");
            ViewBag.AnotherEmployeeReferenceList1 = new SelectList(db.Employees, "EmployeeId", "EmployeeName");
            if (id == null)
            {
                return HttpNotFound();
            }
            OrderTable order = db.OrderTable.Find(id);
            if (order != null)
            {
                return View(order);
            }
            return HttpNotFound();
        }

        // POST: Carriage/Edit/5
        [HttpPost]
        public ActionResult Edit(OrderTable order, FormCollection collection)
        {
            ViewBag.ClientList1 = new SelectList(db.Client, "ClientId", "ClientName");
            ViewBag.StorageList1 = new SelectList(db.Storage, "StorageId", "StorageName");
            ViewBag.AnotherEmployeeReferenceList1 = new SelectList(db.Employees, "EmployeeId", "EmployeeName");
            db.Entry(order).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Carriage/Delete/5
        public ActionResult Delete(int id)
        {
            OrderTable order = db.OrderTable.Find(id);
            if (order != null)
            {
                db.OrderTable.Remove(order);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // POST: Order/Delete/5
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