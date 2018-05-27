using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            DBcontext.ComfortLevels.Add(item);
        }

        public void Delete(int id)
        {
            ComfortLevel comfortLevel = DBcontext.ComfortLevels.Find(id);
            if (comfortLevel != null)
            {
                DBcontext.ComfortLevels.Remove(comfortLevel);
            }
        }

        public IEnumerable<ComfortLevel> GetAll()
        {
            return DBcontext.ComfortLevels;
        }

        public ComfortLevel Read(int id)
        {
            return DBcontext.ComfortLevels.Find(id);
        }

        public void Save()
        {
            DBcontext.SaveChanges();
        }

        public void Update(ComfortLevel item)
        {
            DBcontext.Entry(item).State = EntityState.Modified;
        }
    }
}
