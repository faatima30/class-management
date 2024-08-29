using classManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace classManagementSystem.Controllers
{
    public class ServiceController : Controller
    {
        TechDocEntities1 db = new TechDocEntities1();
        // GET: Service
        public ActionResult Index(string msg)
        {
            ViewBag.msg = msg;
            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
        public ActionResult Insert(string customer_name, string service_type, string issue, decimal price)
        {
            if (customer_name != null)
            {
                db.tbl_Services.Add(entity: new tbl_Services
                {
                    Customer_name = customer_name,
                    Service_type = service_type,
                    Issue = issue,
                    Price = price
                });
                db.SaveChanges();
            }
            return RedirectToAction("Service", new { msg = "data has been saved" });
        }
    }
}