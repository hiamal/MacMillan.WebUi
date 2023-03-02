using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace Architecture.Web
{
    public class Browser
    {
        private static IWebDriver driver;

        public static IWebDriver Driver {
            get
            {   
                driver = driver ?? (driver = GetChromeDriver());
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                return driver;
            }
        }

        public static IWebDriver GetChromeDriver(){
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized"); // Set the window size to maximize
            var chromeDriver = new ChromeDriver(options);
            return chromeDriver;
        }
        
        public static void GoToUrl(string url) => Driver.Navigate().GoToUrl(url);

        public static void CloseBrowser() => Driver.Close();

        public static void CloseBrowsers() => Driver.Quit();

    }
}