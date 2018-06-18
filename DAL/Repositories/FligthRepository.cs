using System;
using System.Collections.Generic;
using System.Collections;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Domain;
using DAL.Interfaces;


namespace DAL.Repositories
{
    public class FlightRepository : IFlight
    {
        private Context DBcontext;
        public FlightRepository()
        {
            this.DBcontext = new Context();
        }

        public AircraftRepository AircraftRepository
        {
            get => default(AircraftRepository);
            set
            {
            }
        }

        public CityRepository CityRepository
        {
            get => default(CityRepository);
            set
            {
            }
        }

        public void Create(Flight item)
        {
            DBcontext.Flights.Add(item);
        }

        public void Delete(int id)
        {
            Flight flight = DBcontext.Flights.Find(id);
            if (flight != null)
            {
                DBcontext.Flights.Remove(flight);
            }
        }

        public IEnumerable<Flight> GetAll()
        {
            return DBcontext.Flights;
        }

        public Flight Read(int id)
        {
            return DBcontext.Flights.Find(id);
        }

        public void Save()
        {
            DBcontext.SaveChanges();
        }

        public void Update(Flight item)
        {
            DBcontext.Entry(item).State = EntityState.Modified;
        }

        public IEnumerable ReturnFlights(DateTime dateD, DateTime dateA, string city1, string city2)
        {
            var query = from fligth in DBcontext.Flights
                        join aircraft in DBcontext.Aircrafts on fligth.AircraftId equals aircraft.Id
                        join Dcity in DBcontext.Cities on fligth.DepartureCityId equals Dcity.ID
                        join Acity in DBcontext.Cities on fligth.ArrivalCityId equals Acity.ID
                        where Dcity.Name == city1
                        where Acity.Name == city2
                        where fligth.DepartureTime == dateD
                        where fligth.ArrivalTime == dateA
                        select new
                        {
                            Aircraft = aircraft.Name,
                            DateD = fligth.DepartureTime,
                            DateA = fligth.ArrivalTime,
                            DepartureCity = Dcity.Name,
                            ArrivalCity = Acity.Name
                        };

            return query.ToList();
        }
    }
}
