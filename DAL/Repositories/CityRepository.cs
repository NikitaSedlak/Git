using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

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
            DBcontext.Cities.Add(item);
        }

        public void Delete(int id)
        {
            City city = DBcontext.Cities.Find(id);
            if (city != null)
            {
                DBcontext.Cities.Remove(city);
            }
        }

        public IEnumerable<City> GetAll()
        {
            return DBcontext.Cities;
        }

        public City Read(int id)
        {
            return DBcontext.Cities.Find(id);
        }

        public void Save()
        {
            DBcontext.SaveChanges();
        }

        public void Update(City item)
        {
            DBcontext.Entry(item).State = EntityState.Modified;
        }
    }
}
