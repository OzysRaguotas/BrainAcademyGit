using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Airport.Models.Entities
{
    public class Plane
    { public int Id { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public int BusinessCapacity { get; set; }
        public int EconomyCapacity { get; set; }
    }
}