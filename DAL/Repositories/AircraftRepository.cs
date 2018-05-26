using DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aircraft> GetAll()
        {
            throw new NotImplementedException();
        }

        public Aircraft Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Aircraft item)
        {
            throw new NotImplementedException();
        }
    }
}
