using Homework_1.BussinessLogic;
using Homework_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework_1.Controllers
{
    public class HomeController : Controller
    {
        InformationRetrieval Informations = new InformationRetrieval();
        public ActionResult Index()
        {
            WeatherModel model = new WeatherModel();
            model.City = Informations.GetCity();
            model.Degrees = Informations.GetDegreesCelcius();
            model.PhotoUrl = Informations.GetPhotoUrl();
            return View(model);
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