using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Airport.Models.Entities;
using Airport.Models.Repositories;
using System.Web.Mvc;

namespace Airport.Controllers
{
    public class FlightController : Controller
    {
        private FlightRepository Repository = new FlightRepository();

        public ActionResult Index()
        {
            List<Flight> _flights;
            _flights = Repository.GetFlights();
            return View(_flights);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Repository.Delete(id);
            return RedirectToAction("Index", "Flight");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Flight flight)
        {
            Repository.Add(flight);
            return RedirectToAction("Index", "Flight");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {

            var _flight = Repository.GetFlightById(id);
            return View(_flight);
        }

        [HttpPost]
        public ActionResult Update(Flight flight)
        {
            Repository.Update(flight);
            return RedirectToAction("Index", "Flight");
        }

        [HttpGet]
        public ActionResult Buy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Buy(Passenger passenger)
        {
            return View(passenger);
        }
    }
}