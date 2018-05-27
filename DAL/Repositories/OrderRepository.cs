using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Domain;

namespace DAL.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private Context DBcontext;
        public OrderRepository()
        {
            this.DBcontext = new Context();
        }
        public void Create(Order item)
        {
            DBcontext.Orders.Add(item); ;
        }

        public void Delete(int id)
        {
            Order order = DBcontext.Orders.Find(id);
            if (order != null)
            {
                DBcontext.Orders.Remove(order);
            }
        }

        public IEnumerable<Order> GetAll()
        {
            return DBcontext.Orders;
        }

        public Order Read(int id)
        {
            return DBcontext.Orders.Find(id);
        }

        public void Save()
        {
            DBcontext.SaveChanges();
        }

        public void Update(Order item)
        {
            DBcontext.Entry(item).State = EntityState.Modified;
        }
    }
}
