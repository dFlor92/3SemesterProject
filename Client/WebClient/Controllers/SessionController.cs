using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClient.Models;
using WebClient.SessionService;

namespace WebClient.Controllers
{
    public class SessionController : Controller
    {
        private SessionServiceClient client;
        public SessionController()
        {
            client = new SessionServiceClient();
        }
        // GET: Session
        public ActionResult Index()
        {
            SessionList sessions = new SessionList { Sessions = client.All() };
            return View();
        }
    }
}