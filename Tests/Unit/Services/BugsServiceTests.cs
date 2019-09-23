using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xunit;
using Moq;
using AireLogicBugTrackingFrontend.Gateways.Interfaces;
using AireLogicBugTrackingFrontend.Models;
using AireLogicBugTrackingFrontend.Services;

namespace AireLogicBugTrackingFrontend.Tests.Unit.Services
{
    public class BugsServiceTests
    {
        private readonly Mock<IBugsGateway> _bugsGatewayMock = new Mock<IBugsGateway>();
        private readonly BugsService _bugsService;

        public BugsServiceTests()
        {
            _bugsService = new BugsService(_bugsGatewayMock.Object);
        }

        [Fact]
        public void GetAllBugsShouldNotReturnNull()
        {
            //Arrange
            _bugsGatewayMock.Setup(gateway => gateway.GetAllBugs())
                .ReturnsAsync(new List<BugsModel>(1)
                {
                    new BugsModel()
                    {
                        BugTitle = "test",
                        IsOpen = true
                    }
                });

            //Act
            var result = _bugsService.GetAllBugs();

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void GetAllBugsServiceShouldCallGateway()
        {
            //Arrange
            var model = new BugsModel() { };


            //Act
            _bugsService.GetAllBugs();

            //Assert
            _bugsGatewayMock.Verify(m => m.GetAllBugs(), Times.Once);

        }

        [Fact]
        public  void GetBugShouldReturnResultsMatchingObject()
        {
            var model = new BugsModel()
            {
                Status = "new",
                Description = "test"

            };

            //Arrange
            _bugsGatewayMock.Setup(_ => _.GetBug(It.IsAny<int>())).ReturnsAsync(model);


            //Act
            var results =  _bugsService.GetBug(It.IsAny<int>());

            //Assert
            Assert.Equal(results, model);
        }


        [Fact]
        public void GetBugShouldNotReturnNull()
        {
            //Arrange
            _bugsGatewayMock.Setup(gateway => gateway.GetBug(1))
                .ReturnsAsync(new BugsModel()
                {
                    BugTitle = "test",
                    IsOpen = true
                });

            //Act
            var result = _bugsService.GetBug(1);

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetBugsServiceShouldCallGateway()
        {
            //Arrange
            var model = new BugsModel() { };


            //Act
            _bugsService.GetBug(1);

            //Assert
            _bugsGatewayMock.Verify(m => m.GetBug(1), Times.Once);
        }
    }
}