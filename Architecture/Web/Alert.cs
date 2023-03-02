using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Architecture.Web
{
    public static class Alert{
        public static IAlert AlertBox => Browser.Driver.SwitchTo().Alert();

        public static void EnterText(string text) => AlertBox.SendKeys(text);

        public static void Accept() => AlertBox.Accept();
    }
}
