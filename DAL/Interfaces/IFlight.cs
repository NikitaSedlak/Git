using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Domain;
using System.Collections;

namespace DAL.Interfaces
{
    public interface IFlight : IRepository<Flight>
    {
        IEnumerable ReturnFlights(DateTime dateD, DateTime dateA, string city1, string city2);
    }
}
