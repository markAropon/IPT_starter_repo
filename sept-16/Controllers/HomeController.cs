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
            new studentModel { Name = "mark", Age = 21 , Id = 1001 , email = "mark@email.com" , gender = "Male"},
            new studentModel { Name = "Alice", Age = 17, Id = 1002 , email = "Alice@email.com" , gender = "Female" },
            new studentModel { Name = "john", Age = 26 , Id = 1003 , email = "john@email.com" , gender = "Male"},
            new studentModel { Name = "sandy", Age = 24, Id = 1004 , email = "sandy@email.com" , gender = "Female" },
            new studentModel { Name = "dean", Age = 23, Id = 1005 , email = "dean@email.com" , gender = "male" },
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