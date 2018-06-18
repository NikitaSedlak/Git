using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Domain;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Project.BL.UnitTests
{
    [TestClass]
    public class CheckFlightTest
    {
        [TestMethod]
        public void ReturnFlightsTest()
        {
            // Arrange
            
            var mock = new Mock<IFlight>();
            mock.Setup(argument => argument.GetAll()).Returns(new List<Flight>());
            GetFlights flights = new GetFlights(mock.Object);


            // Act
            var result = flights.ReturnFlights(Convert.ToDateTime("2018-06-05 00:00:00.000"), Convert.ToDateTime("2018-06-05 00:00:00.000"), "Ankara", "Antalya");

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
