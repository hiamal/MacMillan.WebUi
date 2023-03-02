using System;
using OpenQA.Selenium;
using Architecture.Web;

namespace Pages.PageObjects.Elements
{
    public class ButtonPage
    {
        public Element btnClickMe = new Element(LocatorType.XPath, "//button[.='Click Me']");
        public Element txtDynamicClickMessage = new Element(LocatorType.Id, "dynamicClickMessage");
        public void ClickButtonClickMe() => btnClickMe.Click();

        public string DynamicClickMessage => txtDynamicClickMessage.Text;
    }
}