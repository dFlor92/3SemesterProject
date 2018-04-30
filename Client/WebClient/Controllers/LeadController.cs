using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClient.LeadService;

namespace WebClient.Controllers
{
    public class LeadController : Controller
    {
        LeadServiceClient client;

        public LeadController()
        {
            client = new LeadServiceClient();
        }
        // GET: Lead
        public ActionResult Index()
        {
            List<Lead> leads = client.All();
            return View(leads);
        }

        // GET: Lead/Details/5
        public ActionResult Details(int id)
        {
            Lead lead = client.Read(id);
            return View(lead);
        }

        // GET: Lead/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lead/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Lead/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lead/Edit/5
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

        // GET: Lead/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lead/Delete/5
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
