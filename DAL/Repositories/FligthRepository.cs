using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Flight> GetAll()
        {
            throw new NotImplementedException();
        }

        public Flight Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Flight item)
        {
            throw new NotImplementedException();
        }
    }
}
