using System;
using OpenQA.Selenium;
using Architecture.Web;

namespace Pages.PageObjects.AlertsAndWindows
{
    public class WindowPage
    {
        public void ClickButton(string buttonText) => new Element(LocatorType.XPath, "//button[.='"+ buttonText+"']").Click();

        public string WindowText => new Element(LocatorType.TagName, "body").Text;
    }
}