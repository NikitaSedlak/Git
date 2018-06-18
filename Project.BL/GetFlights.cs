using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using DAL.Repositories;
using DAL.Domain;
using DAL.Interfaces;

namespace Project.BL
{
    public class GetFlights
    {
        public IFlight flight;

        public GetFlights() {   }

        public GetFlights(IFlight _flight)
        {
            flight = _flight;
        }

        public IEnumerable ReturnFlights(DateTime dateD, DateTime dateA, string city1, string city2)
        {
            return flight.ReturnFlights(dateD, dateA, city1, city2);
        }
    }
}
