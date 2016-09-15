namespace Airport.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using Airport.Models.Entities;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Airport.Models.AirportContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Airport.Models.AirportContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Flights.AddOrUpdate(

              new Flight { Number = "FN545", CityFrom = "Kyiv", CityTo = "Kharkiv", ArrivalTime = new DateTime(2016, 10, 10, 10, 0, 0), DepartureTime = new DateTime(2016, 10, 10, 8, 0, 0) },
              new Flight { Number = "FN546", CityFrom = "Kyiv", CityTo = "Lviv", ArrivalTime = new DateTime(2016, 9, 10, 10, 0, 0), DepartureTime = new DateTime(2016, 9, 10, 8, 0, 0) }
              
            );
            context.SaveChanges();
            //
        }
    }
}
