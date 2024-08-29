using classManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace classManagementSystem.Controllers
{
    public class CustomerController : Controller
    {
        TechDocEntities1 db = new TechDocEntities1();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Customer(string msg)
        {
            ViewBag.msg = msg;
            return View();
        }
        public ActionResult Insert(string name ,string address,string phone, string gender)
        {
            if (name != null)
            {
                db.tbl_Customers.Add(new tbl_Customers
                {
                    Name = name,
                    Address = address,
                    Phone = phone,
                    Gender = gender
                });
                db.SaveChanges();
            }
            return RedirectToAction("Customer", new { msg="data has been saved" });
        }
    }
}