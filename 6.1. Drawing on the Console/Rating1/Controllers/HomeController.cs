using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rating1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       

        public ActionResult DrawRating(int rating)
        {
            var fullstars = rating * 10 / 100;
            var emptystars = (100 - rating) * 10 / 100;
            var halfstars = 10 - fullstars - emptystars;

            var stars = "";
            for (int i = 0; i < fullstars; i++)
                stars += "<img src='/images/full-star.png' />";
            for (int i = 0; i < halfstars; i++)
                stars += "<img src='/images/half-star.png' />";
            for (int i = 0; i < emptystars; i++)
                stars += "<img src='/images/empty-star.png' />";

            ViewBag.Stars = stars;
            ViewBag.Rating = rating;
            return View("Index");
        }

    }
}