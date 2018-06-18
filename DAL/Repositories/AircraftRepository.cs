using DAL.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Interfaces;

namespace DAL.Repositories
{
    public class AircraftRepository : IRepository<Aircraft>
    {
        private Context DBcontext;
        public AircraftRepository()
        {
            this.DBcontext = new Context();
        }
        public void Create(Aircraft item)
        {
            DBcontext.Aircrafts.Add(item);
        }

        public void Delete(int id)
        {
            Aircraft aircraft = DBcontext.Aircrafts.Find(id);
            if (aircraft != null)
            {
                DBcontext.Aircrafts.Remove(aircraft);
            }
        }

        public IEnumerable<Aircraft> GetAll()
        {
            return DBcontext.Aircrafts;
        }

        public Aircraft Read(int id)
        {
            return DBcontext.Aircrafts.Find(id);
        }

        public void Save()
        {
            DBcontext.SaveChanges();
        }

        public void Update(Aircraft item)
        {
            DBcontext.Entry(item).State = EntityState.Modified;
        }
    }
}
