// WebApiProject.Tests/AuthControllerTests.cs
using WebApiProject.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

public class AuthControllerTests
{
    private readonly AuthController _controller;

    public AuthControllerTests()
    {
        _controller = new AuthController(new UserService(new UserRepository()));
    }

    [Fact]
    public void Register_ReturnsOkResult_WhenValidModel()
    {
        var result = _controller.Register(new RegisterModel { Username = "test", Password = "password" });
        Assert.IsType<OkResult>(result);
    }

    [Fact]
    public void Login_ReturnsUnauthorized_WhenInvalidCredentials()
    {
        var result = _controller.Login(new LoginModel { Username = "wrong", Password = "wrong" });
        Assert.IsType<UnauthorizedResult>(result);
    }
}
