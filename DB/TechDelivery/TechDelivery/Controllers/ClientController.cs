using TechDelivery.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechDelivery.Controllers
{
    public class ClientController : Controller
    {
        private TechDeliveryEntities11 db = new TechDeliveryEntities11();
        // GET: Client
        public ActionResult Index()
        {
            var ClientList = (from C1 in db.Client select C1).ToList();
            return View(ClientList);
        }

        public ActionResult ToCarriageTable()
        {
            return Redirect("~/Carriage/Index");
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
        public ActionResult ToStorageTable()
        {
            return Redirect("~/Storage/Index");
        }
        public ActionResult ToTransportTable()
        {
            return Redirect("~/Transport/Index");
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            var ClientDetails = (from C1 in db.Client where C1.ClientId == id select C1).First();
            return View(ClientDetails);
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            ViewBag.ClientStatusList = new SelectList(db.ClientStatusTable, "ClientStatusId", "StatusOfClient");
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        public ActionResult Create(Client client, FormCollection collection)
        {
            db.Entry(client).State = EntityState.Added;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int? id)
        {
            ViewBag.ClientStatusList1 = new SelectList(db.ClientStatusTable, "ClientStatusId", "StatusOfClient");
            if (id == null)
            {
                return HttpNotFound();
            }
            Client client = db.Client.Find(id);
            if (client != null)
            {
                return View(client);
            }
            return HttpNotFound();
        }

        // POST: Client/Edit/5
        [HttpPost]
        public ActionResult Edit(Client client, FormCollection collection)
        {
            ViewBag.ClientStatusList1 = new SelectList(db.ClientStatusTable, "ClientStatusId", "StatusOfClient");
            db.Entry(client).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            Client client = db.Client.Find(id);
            if (client != null)
            {
                db.Client.Remove(client);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // POST: Client/Delete/5
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
