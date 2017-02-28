using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalR_Server.Controllers
{
    public class MessageSenderController : Controller
    {
        // GET: MessageSender
        public ActionResult Index()
        {
            return View();
        }
    }
}