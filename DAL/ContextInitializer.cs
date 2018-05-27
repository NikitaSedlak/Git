using DAL.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ContextInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            Profile p1 = new Profile {Name = "Admin", Surname = "Admin", Orders = null};
            User u1 = new User {Access = true, Login = "SuperAdmin", Password = "Pa$$w0rd", Profile = p1, IdProfile = p1.Id};

            context.Profiles.Add(p1);
            context.Users.Add(u1);
            context.SaveChanges();
        }
    }
}
