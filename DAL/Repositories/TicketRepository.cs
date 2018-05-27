using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            DBcontext.Tickets.Add(item);
        }

        public void Delete(int id)
        {
            Ticket ticket = DBcontext.Tickets.Find(id);
            if (ticket != null)
            {
                DBcontext.Tickets.Remove(ticket);
            }
        }

        public IEnumerable<Ticket> GetAll()
        {
            return DBcontext.Tickets;
        }

        public Ticket Read(int id)
        {
            return DBcontext.Tickets.Find(id);
        }

        public void Save()
        {
            DBcontext.SaveChanges();
        }

        public void Update(Ticket item)
        {
            DBcontext.Entry(item).State = EntityState.Modified;
        }
    }
}
