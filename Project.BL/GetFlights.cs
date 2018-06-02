using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using DAL.Repositories;
using DAL.Domain;

namespace Project.BL
{
    public class GetFlights
    {
        //private FlightRepository flightRepository;
        private Context context;
        public GetFlights()
        {
            context = new Context();
            //flightRepository = new FlightRepository();
        }

        public IEnumerable ReturnFlights(DateTime date, string city1, string city2)
        {
            var query = from fligth in context.Flights
                        join aircraft in context.Aircrafts on fligth.AircraftId equals aircraft.Id
                        join Dcity in context.Cities on fligth.DepartureCityId equals Dcity.ID
                        join Acity in context.Cities on fligth.ArrivalCityId equals Acity.ID
                        where Dcity.Name == city1
                        where Acity.Name == city2
                        where fligth.DepartureTime == date
                        select new
                        {
                            Aircraft = aircraft.Name,
                            Date = fligth.DepartureTime,
                            DepartureCity = Dcity.Name,
                            ArrivalCity = Acity.Name
                        };

            return query.ToList();
        }
    }
}
