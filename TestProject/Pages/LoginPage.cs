using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement UsernameField => _driver.FindElement(By.Id("username"));
        private IWebElement PasswordField => _driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => _driver.FindElement(By.CssSelector("button.radius"));
        private IWebElement SuccessMessage => _driver.FindElement(By.CssSelector(".flash.success"));

        public void EnterUsername(string username) => UsernameField.SendKeys(username);
        public void EnterPassword(string password) => PasswordField.SendKeys(password);
        public void ClickLogin() => LoginButton.Click();
        public bool IsSuccessMessageDisplayed() => SuccessMessage.Displayed;
        public string GetSuccessMessageText() => SuccessMessage.Text;
    }
}
