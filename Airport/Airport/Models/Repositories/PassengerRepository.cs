using System;
using System.Collections.Generic;
using System.Linq;
using Airport.Models.Entities;
using System.Web;

namespace Airport.Models.Repositories
{
    public class PassengerRepository
    {
        AirportContext _db;
        public PassengerRepository()
        {
            _db = new AirportContext();
        }

        public List<Passenger> GetPassengers()
        {
            return _db.Passengers.ToList<Passenger>();
        }

        public void Add(Passenger passenger)
        {
            _db.Passengers.Add(passenger);
            _db.SaveChanges();
        }

        public Passenger GetPassengerById(int id)
        {
            return _db.Passengers.First(p=> p.Id == id);
        }
        public void Delete(int id)
        {
            var passenger = GetPassengerById(id);
            _db.Passengers.Remove(passenger);
            _db.SaveChanges();
        }
        public void Update(Passenger passenger)
        {
            var _passenger = _db.Passengers.Find(passenger.Id);
            if (_passenger != null)
            {
                _db.Entry(_passenger).CurrentValues.SetValues(passenger);
                _db.SaveChanges();
            }
            else
            {
                throw new Exception("Current entity cannot be updated, because it doesn't exist");
            }
        }
    }
}