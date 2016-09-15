using System;
using System.Collections.Generic;
using System.Data.Entity;
using Airport.Models.Entities;
using System.Linq;
using System.Web;

namespace Airport.Models
{
    public class AirportContext:DbContext
    {
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
    }
}