using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication15.Exceptions;
namespace WebApplication15.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Confirmation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Confirmation(string code)
        {
            string admin = code;
            Session["try"] = admin;
            
            ViewBag.grant= Admin.isAdmin(code, "Home controller");
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
    }
}