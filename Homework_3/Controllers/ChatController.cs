using Homework_3.BussinessLogic;
using Homework_3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework_3.Controllers
{
    public class ChatController : Controller
    {
        Comunication com = new Comunication(); 
        // GET: Chat
        public ActionResult Index()
        {
            return View(com.GetAllUsers());
        }

        public ActionResult LatestMessages(string name)
        {
            Message msg = com.GetMessage(name);
            return View(msg);
        }

        public void SendMessage(string mess, string sender, string receiver)
        {
            com.SendMessage(mess, sender, receiver);
        }
    }
}