public class UserControllerTests
{
    [Fact]
    public void Register_ReturnsCreatedResponse_WhenValidRequest()
    {
        // Arrange
        var controller = new UserController(mockUserService);

        // Act
        var result = controller.Register(new RegisterModel { Username = "test", Password = "test123" });

        // Assert
        var actionResult = Assert.IsType<CreatedResult>(result);
    }
}
