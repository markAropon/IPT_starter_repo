using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sept_16.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var studInfo = new[] {
            new studentModel { Name = "John", Age = 20 , Id = 1001 , email = "John@email.com" , gender = "Male"},
            new studentModel { Name = "Alice", Age = 22, Id = 1002 , email = "Alice@email.com" , gender = "Female" },
            new studentModel { Name = "Mark", Age = 19 , Id = 1003 , email = "Mark@email.com" , gender = "Male"},
            new studentModel { Name = "Cindy", Age = 26, Id = 1004 , email = "Cindy@email.com" , gender = "Female" },
            new studentModel { Name = "sarah", Age = 23, Id = 1005 , email = "Sarah@email.com" , gender = "Female" },
            };
            return View(studInfo);
        }

        public ActionResult About()
        {
            ViewBag.Message = "IPT102 Laboratory Activity#1, ASP.net web application";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "contact page.";

            return View();
        }
    }
}