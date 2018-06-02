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
        public ProfileRepository profileRepository;
        public UserRepository userRepository;

        public AddUserProfile()
        {
            profileRepository = new ProfileRepository();
            userRepository = new UserRepository();
        }

        public bool AddUser(string _login, string _password, string _name, string _surname, int _age, string _email)
        {
            try
            {
                if (!(userRepository.GetAll().Single(x => x.Login == _login).Login == _login))
                {
                    userRepository.Create(new User
                    {
                        Login = _login,
                        Password = _password,
                    });

                    userRepository.Save();

                    profileRepository.Create(new Profile
                    {
                        Name = _name,
                        Surname = _surname,
                        Order = null,
                        Access = false,
                        Age = _age,
                        Email = _email,
                        Id = userRepository.GetAll().Single(p => p.Login == _login).Id
                    });

                    profileRepository.Save();

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
