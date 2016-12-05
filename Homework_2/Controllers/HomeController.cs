using Homework_2.BussinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework_2.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeRepository empRep = EmployeeRepository.Instance;
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            var emps = empRep.GetAllEmployees();

            return View(emps);
        }
    }
}
