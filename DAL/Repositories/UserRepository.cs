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
    public class UserRepository : IUser
    {
        private Context DBcontext;
        public UserRepository()
        {
            this.DBcontext = new Context();
        }
        public void Create(User item)
        {
            DBcontext.Users.Add(item);
        }

        public void Delete(int id)
        {
            User user = DBcontext.Users.Find(id);
            if (user != null)
            {
                DBcontext.Users.Remove(user);
            }
        }

        

        public virtual IEnumerable<User> GetAll()
        {
            return DBcontext.Users;
        }

        public User Read(int id)
        {
            return DBcontext.Users.Find(id);
        }

        public void Save()
        {
            DBcontext.SaveChanges();
        }

        public void Update(User item)
        {
            DBcontext.Entry(item).State = EntityState.Modified;
        }
    }
}
