using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechDelivery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
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
        public ActionResult ToStorageTable()
        {
            return Redirect("~/Storage/Index");
        }
        public ActionResult ToTransportTable()
        {
            return Redirect("~/Transport/Index");
        }
    }
}