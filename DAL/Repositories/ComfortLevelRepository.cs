using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Domain;

namespace DAL.Repositories
{
    public class ComfortLevelRepository : IRepository<ComfortLevel>
    {
        private Context DBcontext;
        public ComfortLevelRepository()
        {
            this.DBcontext = new Context();
        }
        public void Create(ComfortLevel item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ComfortLevel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ComfortLevel Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(ComfortLevel item)
        {
            throw new NotImplementedException();
        }
    }
}
