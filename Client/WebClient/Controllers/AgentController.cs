using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClient.AgentService;

namespace WebClient.Controllers
{
    public class AgentController : Controller
    {
        private AgentServiceClient client { get; set; }

        public AgentController()
        {
            client = new AgentServiceClient();
        }
        // GET: Agent
        public ActionResult Index()
        {
            return View();
        }

        // GET: Agent/Details/5
        public ActionResult Details(int id)
        {
            Agent agent = client.Read(id);
            System.Diagnostics.Debug.WriteLine("HALOHALOAHLAJDS");
            return View(agent);
        }

        // GET: Agent/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Agent/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                System.Diagnostics.Debug.WriteLine("DATA " + collection["Name"]);
                //return RedirectToAction("Index");
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Agent/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Agent/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Agent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Agent/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
