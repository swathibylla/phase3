using NUnit.Framework;
using Moq;
using System.Data;
using Login;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1

{
    [TestFixture]
    public class LoginServicesTests
    {


        private LoginService loginService;


        [SetUp]
        public void Setup()
        {
            loginService = new LoginService();
        }

        [Test]
        public void AuthenticateUser_ValidUser_ReturnsTrue()
        {
            //Arrange
            string userType = "User";
            string username = "user123";
            string password = "password123";

            //Act
            bool result = loginService.AuthenticateUser(userType, username, password);

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result);
            
        }
        [Test]
        public void AuthenticaterUser_InValidUser_ReturnsFalse()
        {
            //Arrange
            string userType = "User1";
            string username = "invalidUser";
            string password = "invalidPassword";

            //Act
            bool result = loginService.AuthenticateUser(userType, username, password);

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(result);
        }
        [Test]
        public void AuthenticaterUser_ValidAdmin_ReturnsTrue()
        {
            //Arrange
            string userType = "Admin";
            string username = "admin";
            string password = "adminpass";

            //Act
            bool result = loginService.AuthenticateUser(userType, username, password);

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result);
        }
        [Test]
        public void AuthenticaterUser_InValidAdmin_ReturnsFalse()
        {
            //Arrange
            string userType = "Admin";
            string username = "invalidAdmin";
            string password = "invalidAdminPassword";

            //Act
            bool result = loginService.AuthenticateUser(userType, username, password);

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(result);
        }



    }
}