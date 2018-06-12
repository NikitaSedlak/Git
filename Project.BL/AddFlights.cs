using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using DAL.Repositories;
using DAL.Domain;

namespace Project.BL
{
    public class AddFlights
    {
        FlightRepository flight;
        AircraftRepository aircraftRepository;
        CityRepository cityRepository;

        public AddFlights()
        {
            flight = new FlightRepository();
            aircraftRepository = new AircraftRepository();
            cityRepository = new CityRepository();
        }

        public bool AddNewFlight(string aircraft, DateTime dateA, DateTime dateD, string cityA, string cityD)
        {
            try
            {
                flight.Create(new Flight
                {
                    AircraftId = aircraftRepository.GetAll().Single(a => a.Name == aircraft).Id,
                    DepartureTime = dateD,
                    ArrivalTime = dateA,
                    DepartureCityId = cityRepository.GetAll().Single(c => c.Name == cityD).ID,
                    ArrivalCityId = cityRepository.GetAll().Single(c => c.Name == cityA).ID,
                });

                flight.Save();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool CheckFlight(DateTime dateD, DateTime dateA, string cityA, string cityD)
        {
            try
            {
                if (!flight.GetAll()
                        .Where(pCityD => pCityD.DepartureCity.Name == cityD).ToList()
                        .Where(pCityA => pCityA.ArrivalCity.Name == cityA).ToList()
                        .Where(pDateD => pDateD.DepartureTime == dateD).ToList()
                        .Where(pDateA => pDateA.ArrivalTime == dateA).ToList()
                        .Any()
                    )
                {
                    flight.Save();
                    return true;
                }
                else
                    return false;
            
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
