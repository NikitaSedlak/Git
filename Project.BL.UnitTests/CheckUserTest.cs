
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Domain;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Project.BL.UnitTests
{
    [TestClass]
    public class CheckUserTest
    {
        [TestMethod]
        public void CheckLoginedUserTest()
        {
            // Arrange
            var mock = new Mock<IUser>();
            mock.Setup(argument => argument.GetAll()).Returns(new List<User>());
            CheckUser users = new CheckUser(mock.Object);

            // Act
            var result = users.CheckLoginedUser("SomeLogin", "SomePass");

            //Assert
            Assert.IsFalse(result);
        }
    }
}
