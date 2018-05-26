using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Domain;

namespace DAL.Repositories
{
    public class ProfileRepository : IRepository<Profile>
    {
        private Context DBcontext;
        public ProfileRepository()
        {
            this.DBcontext = new Context();
        }
        public void Create(Profile item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Profile> GetAll()
        {
            throw new NotImplementedException();
        }

        public Profile Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Profile item)
        {
            throw new NotImplementedException();
        }
    }
}
