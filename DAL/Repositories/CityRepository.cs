using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Domain;

namespace DAL.Repositories
{
    public class CityRepository : IRepository<City>
    {
        private Context DBcontext;
        public CityRepository()
        {
            this.DBcontext = new Context();
        }
        public void Create(City item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetAll()
        {
            throw new NotImplementedException();
        }

        public City Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(City item)
        {
            throw new NotImplementedException();
        }
    }
}
