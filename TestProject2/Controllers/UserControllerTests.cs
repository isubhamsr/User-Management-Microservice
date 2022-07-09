using Moq;
using NUnit.Framework;
using System;
using User_Management_Microservice.Controllers;
using User_Management_Microservice.Services;
using User_Management_Microservice.Model;
namespace TestProject2.Controllers
{
    [TestFixture]
    public class UserControllerTests
    {
        private MockRepository mockRepository;

        private Mock<IUserRequestService> mockUserRequestService;

        [SetUp]
        public void SetUp()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockUserRequestService = this.mockRepository.Create<IUserRequestService>();
        }

        private UserController CreateUserController()
        {
            return new UserController(
                this.mockUserRequestService.Object);
        }

        [Test]
        public void Get_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var userController = this.CreateUserController();
            List<AppUser> users = new List<AppUser>() { new AppUser { Id = 1,Name = "Ritu", Email = "ritu@123gmail.com", Mobile = 56789, Password = "nopass" } };
    
            mockUserRequestService.Setup(i => i.GetUserList()).Returns(users);
            int id = 0;
            // Act
            var result = userController.Get();
            var finalresult = result;

            // Assert
            Assert.True(true);
            //Assert.AreEqual("Users are fetch",result)
            mockUserRequestService.Verify(i => i.GetUserList(),Times.Once);
            this.mockRepository.VerifyAll();
        }

        [Test]
        public void Get_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var userController = this.CreateUserController();
            List<AppUser> userid = new List<AppUser>() { new AppUser { Id = 1, Name = "Ritu" , Email = "ritu@123gmail.com", Mobile = 56789, Password = "nopass" } };
            mockUserRequestService.Setup(i => i.GetServiceRequestDetailsByUserId(It.IsAny<int>())).Returns(userid);
            int userId = 1;

            // Act
            var result = userController.Get(
                userId);

            // Assert
            Assert.True(true);
             mockUserRequestService.Verify(i => i.GetServiceRequestDetailsByUserId(It.IsAny<int>()),Times.Once) ;
            this.mockRepository.VerifyAll();
        }

        [Test]
        public void Post_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var userController = this.CreateUserController();
            AppUser value = new AppUser() { Id=1,Name="Ritu",Email="ritu@123gmail.com",Mobile=56789,Password="nopass"};
            mockUserRequestService.Setup(i => i.SaveUser(value));
            // Act
            var result = userController.Post(
                value);
            var finalresult = result;

            // Assert
            Assert.True(true);
            
            mockUserRequestService.Verify(i => i.SaveUser(value), Times.Once);
            this.mockRepository.VerifyAll();
        }

        [Test]
        public void Put_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            int id = 1;
            var userController = this.CreateUserController();
            AppUser value = new AppUser() { Id = 1,Name = "nil", Email = "ritu@123gmail.com", Mobile = 56789, Password = "nopass" };
            mockUserRequestService.Setup(i => i.UpdateUser(value));

            // Act
            var result = userController.Put(
                value);
            var  finalresult= result;
            // Assert
            
            Assert.True(true);
            
            mockUserRequestService.Verify(i => i.UpdateUser(value), Times.Once);
            this.mockRepository.VerifyAll();
        }

        [Test]
        public void Delete_StateUnderTest_ExpectedBehaviour()
        {
            // Arrange
            var userController = this.CreateUserController();
            int id = 1;
            AppUser user = new AppUser(); { new AppUser { Id = 1, }; };
            //mockUserRequestService.Setup(i => i.DeleteUser(It.IsAny<int>())).Returns(user);

            

            // Act
            var result = userController.Delete( id);
           
            // Assert
           
            Assert.True(true);
            mockUserRequestService.Verify(i => i.DeleteUser((It.IsAny<int>())), Times.Once);
            this.mockRepository.VerifyAll();
        }
    }
}
