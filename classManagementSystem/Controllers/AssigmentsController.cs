using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace classManagementSystem.Controllers
{
    public class AssigmentsController : Controller
    {
        // GET: Assigments
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Assigments()
        {
            return View();
        }
    }
}