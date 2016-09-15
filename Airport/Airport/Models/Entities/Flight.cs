using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Airport.Models.Entities
{
    public class Flight
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public string CityFrom { get; set; }
        public string CityTo { get; set; }
        public string Gate { get; set; }
        public string Terminal { get; set; }
        public Plane Plane { get; set; }
        public List<Passenger> Passengers { get; set; }
    }
}