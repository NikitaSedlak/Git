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
            User u1 = new User
            {
                Login = "Admin",
                Password = "Admin"
            };

            Profile p1 = new Profile
            {
                Id = u1.Id,
                Name = "Admin",
                Surname = "Admin",
                Access = true,
                Age = 20,
                Email = "admin.admin@admin.com",
                Order = null
            };

            context.Profiles.Add(p1);
            context.Users.Add(u1);
            context.SaveChanges();
        }
    }
}
