using BusinessLogic;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AgentController ctr = new AgentController();
            Agent test = ctr.Read(1);
            ViewData["model"] = test;
            return View(test);
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