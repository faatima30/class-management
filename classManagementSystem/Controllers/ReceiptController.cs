using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using classManagementSystem.Models;

namespace classManagementSystem.Controllers
{
    public class ReceiptController : Controller
    {
        TechDocEntities1 db = new TechDocEntities1();
        // GET: Receipt
        public ActionResult Index(string msg)
        {
            ViewBag.msg = msg;
            return View();
        }
        public ActionResult Receipt()
        {
            return View();
        }
        public ActionResult Insert(string customer_name, string service_type, decimal receipt_amount, decimal balance)
        {
            if (customer_name != null)
            {
                db.tbl_Receipts.Add(entity:new tbl_Receipts
                {
                    Customer_name = customer_name,
                    Service = service_type,
                    Receipt_Amount = receipt_amount,
                    Balance = balance
                });
                db.SaveChanges();
            }
            return RedirectToAction("Receipt", new { msg = "data has been saved" });
        }
    }
}