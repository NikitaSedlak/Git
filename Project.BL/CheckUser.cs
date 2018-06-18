using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using DAL.Repositories;
using DAL.Interfaces;
using DAL.Domain;

namespace Project.BL
{
    public class CheckUser
    {
        public IUser user;


        public CheckUser() { }   

        public CheckUser(IUser _user)
        {
            user = _user;
        }

        public bool CheckLoginedUser(string login, string password)
        {
            try
            {
                if (user.GetAll().Single(p => p.Login == login).Password == password)
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
                if (user.GetAll().Single(p => p.Login == login).Profile.Access == true)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

        //public string Test1(string login, string password)
        //{
        //    try
        //    {
        //        if (userRepository.GetAll().Single(p => p.Login == login).Password == password)
        //            return "Ok";
        //        else
        //            return "not ok";
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.Message;
        //    }
        //}
        //public string Test2(string login)
        //{
        //    try
        //    {
        //        if (userRepository.GetAll().Single(p => p.Login == login).Profile.Access == true)
        //            return "ok";
        //        else
        //            return "not ok";
        //    }
        //    catch (Exception ex)
        //    {

        //        return ex.Message;
        //    }
        //}
    }
}
