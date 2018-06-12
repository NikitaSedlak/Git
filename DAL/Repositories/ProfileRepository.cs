using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public UserRepository UserRepository
        {
            get => default(UserRepository);
            set
            {
            }
        }

        public void Create(Profile item)
        {
            DBcontext.Profiles.Add(item);
        }

        public void Delete(int id)
        {
            Profile profile = DBcontext.Profiles.Find(id);
            if (profile != null)
            {
                DBcontext.Profiles.Remove(profile);
            }
        }

        public IEnumerable<Profile> GetAll()
        {
            return DBcontext.Profiles;
        }

        public Profile Read(int id)
        {
            return DBcontext.Profiles.Find(id);
        }

        public void Save()
        {
            DBcontext.SaveChanges();
        }

        public void Update(Profile item)
        {
            DBcontext.Entry(item).State = EntityState.Modified;
        }
    }
}
