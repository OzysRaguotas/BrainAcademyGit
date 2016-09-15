using System;
using System.Collections.Generic;
using Airport.Models.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Models.Interfaces
{
    interface IFlight
    {
        List<Flight> GetFlights();
        Flight GetFlightById(int id);
        void Add(Flight flight);
        void Update(Flight flight);
        void Delete(int id);
    }
}
