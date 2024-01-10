using FluentAssertions;
using FormulaApp.Api.Controllers;
using FormulaApp.Api.Models;
using FormulaApp.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace TddxUnity.Systems.Controllers;

public class TestFansController
{
    [Fact]
    public async Task Get_Onsuccess_ReturnStatusCode200()
    {
        // Arrange
        var mockFanService = new Mock<IFanServices>();
        mockFanService.Setup(services => services.GetAllFans())
            .ReturnsAsync(new List<Fan>());
        var fansController = new FansController(mockFanService.Object);

        // Act
        var result = (OkObjectResult) await fansController.Get();

        // Assert
        result.StatusCode.Should().Be(200);
    }

    [Fact]
    public async Task Get_OnSuccess_InvokeServices()
    {
        // Arrange
        var mockFanService = new Mock<IFanServices>();
        mockFanService.Setup(services => services.GetAllFans())
            .ReturnsAsync(new List<Fan>());
        var fansController = new FansController(mockFanService.Object);
        
        // Act
        var result = (OkObjectResult) await fansController.Get();
        
        //Assert
        mockFanService.Verify(service => service.GetAllFans(), Times.Once);
        
    }

    [Fact]
    public async Task Get_OnSuccess_ReturnListOfFans()
    {
        // Arrange
        var mockFanService = new Mock<IFanServices>();
        mockFanService.Setup(services => services.GetAllFans())
            .ReturnsAsync(new List<Fan>());
        var fansController = new FansController(mockFanService.Object);

        // Act
        var result = (OkObjectResult) await fansController.Get();
        
        // Assert
        result.Should().BeOfType<OkObjectResult>();

         result.Value.Should().BeOfType<List<Fan>>();
    }
}