using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject.Utilities
{
    public static class Driver
    {
        private static IWebDriver _driver;

        public static IWebDriver Instance
        {
            get
            {
                if (_driver == null)
                {
                    _driver = new ChromeDriver();
                    _driver.Manage().Window.Maximize();
                }
                return _driver;
            }
        }

        public static void CloseDriver()
        {
            _driver?.Quit();
            _driver = null;
        }
    }
}
