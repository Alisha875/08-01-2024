using Assignment;
using NUnit.Framework;

[TestFixture]
public class UserAuthenticatorTests
{
    private UserAuthenticator _userAuthenticator;

    [SetUp]
    public void Setup()
    {
        _userAuthenticator = new UserAuthenticator();
    }

    [Test]
    public void RegisterUser_ValidCredentials_ReturnsTrue()
    {
        // Arrange
        string username = "testuser";
        string password = "password123";

        // Act
        bool result = _userAuthenticator.RegisterUser(username, password);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void LoginUser_ValidCredentials_ReturnsTrue()
    {
        // Arrange
        string username = "testuser";
        string password = "password123";
        _userAuthenticator.RegisterUser(username, password);

        // Act
        bool result = _userAuthenticator.LoginUser(username, password);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void ChangePassword_ValidCredentials_ReturnsTrue()
    {
        // Arrange
        string username = "testuser";
        string oldPassword = "password123";
        string newPassword = "newpassword456";
        _userAuthenticator.RegisterUser(username, oldPassword);

        // Act
        bool result = _userAuthenticator.ChangePassword(username, oldPassword, newPassword);

        // Assert
        Assert.IsTrue(result);
    }
}
