using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Pages;
using TestProject.Utilities;
using Xunit;

namespace TestProject.Tests
{
    public class LoginTests
    {
        [Fact]
        public void Login_WithValidCredentials_ShouldSucceed()
        {
            var driver = Driver.Instance;
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            var loginPage = new LoginPage(driver);

            loginPage.EnterUsername("tomsmith");
            loginPage.EnterPassword("SuperSecretPassword!");
            loginPage.ClickLogin();

            Assert.True(loginPage.IsSuccessMessageDisplayed());
            Assert.Contains("You logged into a secure area!", loginPage.GetSuccessMessageText());

            Driver.CloseDriver();
        }
    }
}
