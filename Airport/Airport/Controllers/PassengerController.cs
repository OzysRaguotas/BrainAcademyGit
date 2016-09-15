using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Airport.Models.Entities;
using Airport.Models.Repositories;
using System.Web.Mvc;

namespace Airport.Controllers
{
    public class PassengerController : Controller
    {
        private PassengerRepository Repository = new PassengerRepository();
        // GET: Passenger
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Passenger passenger)
        {
            Repository.Add(passenger);
            return RedirectToAction("Index", "Passenger");
        }
        public ActionResult Update(int id)
        {

            var _passenger = Repository.GetPassengerById(id);
            return View(_passenger);
        }

        [HttpPost]
        public ActionResult Update(Passenger passenger)
        {
            Repository.Update(passenger);
            return RedirectToAction("Index", "Flight");
        }
    }
}