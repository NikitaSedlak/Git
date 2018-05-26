using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Domain;

namespace DAL.Repositories
{
    public class OrderedTicketRepository : IRepository<OrderedTicket>
    {
        private Context DBcontext;
        public OrderedTicketRepository()
        {
            this.DBcontext = new Context();
        }
        public void Create(OrderedTicket item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderedTicket> GetAll()
        {
            throw new NotImplementedException();
        }

        public OrderedTicket Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(OrderedTicket item)
        {
            throw new NotImplementedException();
        }
    }
}
