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
    public class AddUserProfile
    {
        private Context context;
        //public ProfileRepository profileRepository;
        public UserRepository userRepository;

        public AddUserProfile()
        {
            context = new Context();
            //profileRepository = new ProfileRepository();
            userRepository = new UserRepository();
        }

        public bool AddUser(string _login, string _password, string _name, string _surname)
        {
            try
            {
                if (!context.Users.All(x => x.Login == _login))
                {
                    Profile profile = new Profile
                    {
                        Name = _name,
                        Surname = _surname,
                        Orders = null
                    };
                    //User user = new User
                    //{
                    //    Login = _login,
                    //    Password = _password,
                    //    Access = false,
                    //    IdProfile = profile.Id,
                    //    Profile = profile
                    //};
                    userRepository.Create(new User
                    {
                        Login = _login,
                        Password = _password,
                        Access = false,
                        IdProfile = profile.Id,
                        Profile = profile
                    });
                    userRepository.Save();
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
