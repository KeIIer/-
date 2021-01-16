using TechDelivery.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechDelivery.Controllers
{
    public class EmployeesController : Controller
    {
        private TechDeliveryEntities11 db = new TechDeliveryEntities11();
        // GET: Employees
        public ActionResult Index()
        {
            var EmployeesList = (from C1 in db.Employees select C1).ToList();
            return View(EmployeesList);
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id)
        {
            var EmployeesDetails = (from C1 in db.Employees where C1.EmployeeId == id select C1).First();
            return View(EmployeesDetails);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewBag.StatusList = new SelectList(db.EmployeeStatusTable, "StatusId", "CurrentStatus");
            ViewBag.CarriageReferenceList = new SelectList(db.Carriage, "CarriageId", "CarriageContactInfo");
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        public ActionResult Create(Employees employees, FormCollection collection)
        {
            db.Entry(employees).State = EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            ViewBag.StatusList = new SelectList(db.EmployeeStatusTable, "StatusId", "CurrentStatus");
            ViewBag.CarriageReferenceList1 = new SelectList(db.Carriage, "CarriageId", "CarriageContactInfo");
            if (id == null)
            {
                return HttpNotFound();
            }
            Employees employees = db.Employees.Find(id);
            if (employees != null)
            {
                return View(employees);
            }
            return HttpNotFound();
        }

        // POST: Employees/Edit/5
        [HttpPost]
        public ActionResult Edit(Employees employees, FormCollection collection)
        {
            ViewBag.StatusList = new SelectList(db.EmployeeStatusTable, "StatusId", "CurrentStatus");
            ViewBag.CarriageReferenceList1 = new SelectList(db.Carriage, "CarriageId", "CarriageContactInfo");
            db.Entry(employees).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            Employees employees = db.Employees.Find(id);
            if (employees != null)
            {
                db.Employees.Remove(employees);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // POST: Employees/Delete/5
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