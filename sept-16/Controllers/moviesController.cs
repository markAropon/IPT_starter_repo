using sept_16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sept_16.Controllers
{
    public class moviesController : Controller
    {
        private moviesMOdel[] movieList = new moviesMOdel[] 
        {
            new moviesMOdel{ ID = 16, Title = "titanic" },
        };

      
        public ActionResult Details(int ? ID)
        {
            moviesMOdel movie = null;

            foreach (var M in movieList)
            {
                if (M.ID == ID)
                {
                    movie = M;
                    break;

                }
            }
            if (movie == null) {
                return HttpNotFound();
            }
            return View(movie);
        }
    }
}