using System;
using System.Collections.Generic;
using System.Linq;
using Airport.Models.Entities;
using Airport.Models.Repositories;
using System.Web;

namespace Airport.Models.Repositories
{
    public class FlightRepository
    {
        AirportContext _db;
        public FlightRepository()
        {
            _db = new AirportContext();
        }
        public List<Flight> GetFlights()
        {
            return _db.Flights.ToList<Flight>();
        }

        public Flight GetFlightById(int id)
        {
            return _db.Flights.First(f => f.Id == id);
        }
        public void Delete(int id)
        {
            var flight = GetFlightById(id);
            _db.Flights.Remove(flight);
            _db.SaveChanges();
        }

        public void Add(Flight flight)
        {
            _db.Flights.Add(flight);
            _db.SaveChanges();
        }

        public void Update(Flight flight)
        {
            var _flight = _db.Flights.Find(flight.Id);
            if (_flight != null)
            {
                _db.Entry(_flight).CurrentValues.SetValues(flight);
                _db.SaveChanges();
            }
            else
            {
                throw new Exception("Current entity cannot be updated, because it doesn't exist");
            }
        }


        

    }
}