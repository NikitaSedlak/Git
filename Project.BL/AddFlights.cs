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
        Context context;
        FlightRepository flight;
        AircraftRepository aircraftRepository;
        CityRepository cityRepository;
        public AddFlights()
        {
            context = new Context();
            flight = new FlightRepository();
            aircraftRepository = new AircraftRepository();
            cityRepository = new CityRepository();
        }

        //public bool AddNewFlight(string _aircraft, DateTime _Adate, DateTime _Ddate, string _Acity, string _Dcity)
        //{
             
        //    try
        //    {
        //        var air = from aircraft in context.Aircrafts
        //                    where aircraft.Name == _aircraft
        //                    select aircraft;

        //        var Acity = from cityA in context.Cities
        //                    where cityA.Name == _Acity
        //                    select cityA;

        //        var Dcity = from cityD in context.Cities
        //                    where cityD.Name == _Dcity
        //                    select cityD;

        //        flight.Create(new Flight
        //        {
        //            Aircraft = (Aircraft)air,
        //            ArrivalTime = _Adate,
        //            DepartureTime = _Ddate,
        //            ArrivalCity = (City)Acity,
        //            DepartureCity = (City)Dcity
        //        });

        //        flight.Save();

        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        public string Test(string _aircraft, DateTime _Adate, DateTime _Ddate, string _Acity, string _Dcity)
        {

            try
            {
                //var air = from aircraft in context.Aircrafts
                //          where aircraft.Name == _aircraft
                //          select aircraft.Id;

                var Acity = from cityA in context.Cities
                            where cityA.Name == _Acity
                            select cityA.ID;

                var Dcity = from cityD in context.Cities
                            where cityD.Name == _Dcity
                            select cityD.ID;

                //Aircraft air = (Aircraft)context.Aircrafts.Where(p => p.Name == _aircraft);
                //City Acity = (City)context.Cities.Where(p => p.Name == _Acity);
                //City Dcity = (City)context.Cities.Where(p => p.Name == _Dcity);


                flight.Create(new Flight
                {
                    //Aircraft = (Aircraft)context.Aircrafts.Where(p => p.Name == _aircraft),
                    //Aircraft = aircraftRepository.Read(air.ToList().First()),

                    Aircraft = context.Aircrafts.Single(p => p.Name == _aircraft),

                    ArrivalTime = _Adate,
                    DepartureTime = _Ddate,

                    //ArrivalCity = (City)context.Cities.Where(p => p.Name == _Acity),
                    //DepartureCity = (City)context.Cities.Where(p => p.Name == _Dcity)

                    ArrivalCity = cityRepository.Read(Acity.ToList().First()),
                    DepartureCity = cityRepository.Read(Dcity.ToList().First()),

                    //ArrivalCity = context.Cities.Single(p => p.Name == _Acity),
                    //DepartureCity = context.Cities.Single(p => p.Name == _Dcity),

                    //IdArrivalCity = Acity.ToList().First(),
                    //IdDepartureCity = Dcity.ToList().First()

                });

                flight.Save();

                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
