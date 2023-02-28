using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Architecture
{
    public class Browser
    {
        private static IWebDriver driver;

        public static IWebDriver Driver {
            get
            {
                driver = driver ?? (driver = new ChromeDriver());
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                return driver;
            }
        }

        public static void GoToUrl(string url) => Driver.Navigate().GoToUrl(url);
    }
}