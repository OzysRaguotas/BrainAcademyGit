using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Airport.Models.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public Passenger Passenger { get; set; }
        
    }
}