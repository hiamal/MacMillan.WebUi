using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Architecture.Web
{
    public static class Wait{
        public static void Until(int seconds)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(seconds));
            //wait.Until(false);
        }
    }
}