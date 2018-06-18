using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Domain;
using DAL.Interfaces;

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
            DBcontext.OrderedTickets.Add(item); ;
        }

        public void Delete(int id)
        {
            OrderedTicket orderedTicket = DBcontext.OrderedTickets.Find(id);
            if (orderedTicket != null)
            {
                DBcontext.OrderedTickets.Remove(orderedTicket);
            }
        }

        public IEnumerable<OrderedTicket> GetAll()
        {
            return DBcontext.OrderedTickets;
        }

        public OrderedTicket Read(int id)
        {
            return DBcontext.OrderedTickets.Find(id);
        }

        public void Save()
        {
            DBcontext.SaveChanges();
        }

        public void Update(OrderedTicket item)
        {
            DBcontext.Entry(item).State = EntityState.Modified;
        }
    }
}
