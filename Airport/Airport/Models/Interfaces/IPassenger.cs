using System;
using System.Collections.Generic;
using Airport.Models.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Models.Interfaces
{
    interface IPassenger
    {
        List<Passenger> Passengers();
        //Passenger GetPassengerById(int id);
        //void Add(Passenger passenger);
        //void Update(Passenger passenger);
        //void Delete(int id);
    }
}
