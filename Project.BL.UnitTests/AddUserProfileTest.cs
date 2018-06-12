using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DAL.Domain;
//using Moq;

namespace Project.BL.UnitTests
{
    [TestClass]
    class AddUserProfileTest
    {
        [TestMethod]
        public void AddUserProfile_input_login_pass_name_surname_age_email_output_true()
        {
            string login = "TestLogin";
            string pass = "TestPfss";
            string name = "TestUser";
            string surname = "UserTest";
            int age = 1000;
            string email = "test@test.test";

            //var user = new User()
        }
    }
}
