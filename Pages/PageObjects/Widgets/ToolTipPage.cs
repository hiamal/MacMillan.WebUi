using System;
using OpenQA.Selenium;
using Architecture.Web;

namespace Pages.PageObjects.Widgets
{
    public class ToolTipPage
    {
        public Element btnHoverMe = new Element(LocatorType.Id , "toolTipButton");

        public void HoverOnHoverMeButton() => btnHoverMe.Hover();

        public string ToolTipText => new Element(LocatorType.XPath, "//div[@role='tooltip']").Text;


    }
}