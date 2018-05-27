using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Domain;

namespace DAL.Repositories
{
    public class FlightRepository : IRepository<Flight>
    {
        private Context DBcontext;
        public FlightRepository()
        {
            this.DBcontext = new Context();
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
    }
}
