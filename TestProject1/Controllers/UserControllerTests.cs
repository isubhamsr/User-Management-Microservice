using Moq;
using System;
using User_Management_Microservices;
using User_Management_Microservice.Controllers;
using User_Management_Microservice.Services;
using Xunit;
using User_Management_Microservice.Models;

namespace TestProject1.Controllers
{
    public class UserControllerTests
    {
        private MockRepository mockRepository;

        private Mock<IUserRequestService> mockUserRequestService;

        public UserControllerTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockUserRequestService = this.mockRepository.Create<IUserRequestService>();
        }

        private UserController CreateUserController()
        {
            return new UserController(
                this.mockUserRequestService.Object);
        }

        [Fact]
        public void Get_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var userController = this.CreateUserController();

            // Act
            var result = userController.Get();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Get_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var userController = this.CreateUserController();
            int userId = 0;

            // Act
            var result = userController.Get(
                userId);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Post_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var userController = this.CreateUserController();
            AppUser value = null;

            // Act
            var result = userController.Post(
                value);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Put_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var userController = this.CreateUserController();
            AppUser value = null;

            // Act
            var result = userController.Put(
                value);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Delete_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var userController = this.CreateUserController();
            int id = 0;

            // Act
            var result = userController.Delete(
                id);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
