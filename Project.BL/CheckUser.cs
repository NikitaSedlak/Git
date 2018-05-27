using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using DAL.Repositories;
using DAL.Domain;

namespace Project.BL
{
    public class CheckUser
    {
        //public UserRepository userRepository;
        public Context context;
        public CheckUser()
        {
            //userRepository = new UserRepository();
            context = new Context();
        }

        public bool LoginedUser(string login, string password)
        {
            try
            {
                User user = context.Users.Single(x => x.Login == login);
                if (user.Password == password)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AdminUser(string login)
        {
            try
            {
                User user = context.Users.Single(x => x.Login == login);
                if (user.Access == true)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                
                return false;
            }
        }
        //public string Test(string login, string password)
        //{
        //    try
        //    {
        //        User user = context.Users.Single(x => x.Login == login);
        //        if (user.Password == password)
        //            return "ok";
        //        else
        //            return "try not ok";
        //    }
        //    catch (Exception e)
        //    {

        //        return e.Message;
        //    }
        //}

    }
}
