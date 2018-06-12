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
        private UserRepository userRepository;

        public CheckUser()
        {
            userRepository = new UserRepository();
        }

        public bool CheckLoginedUser(string login, string password)
        {
            try
            {
                if (userRepository.GetAll().Single(p => p.Login == login).Password == password)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool CheckAdminUser(string login)
        {
            try
            {
                if (userRepository.GetAll().Single(p => p.Login == login).Profile.Access == true)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
