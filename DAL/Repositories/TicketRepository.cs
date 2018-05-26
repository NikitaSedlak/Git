using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Domain;

namespace DAL.Repositories
{
    public class TicketRepository : IRepository<Ticket>
    {
        private Context DBcontext;
        public TicketRepository()
        {
            this.DBcontext = new Context();
        }
        public void Create(Ticket item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ticket> GetAll()
        {
            throw new NotImplementedException();
        }

        public Ticket Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Ticket item)
        {
            throw new NotImplementedException();
        }
    }
}
