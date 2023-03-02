using System;
using TechTalk.SpecFlow;
using Architecture.Web;
using Pages.PageObjects.AlertsAndWindows;
using NUnit.Framework;using Architecture.EnvironmentConfig;

namespace Tests.Steps.AlertsAndWindows
{
    [Binding]
    public class WindowSteps
    {
        WindowPage WindowPage = new WindowPage();

        [Given(@"I'm on the Window Page")]
        public void GivenImontheWindowPage()
        {
            Browser.GoToUrl($"{EnvironmentDetails.BaseUrl}/browser-windows");
        }

        [When(@"I click on the '(.*)' button")]
        public void WhenIclickontheNewTabbutton(string buttonText)
        {
            WindowPage.ClickButton(buttonText);
        }

        [Then(@"I see '(.*)' in a new window")]
        public void ThenIseeThisisasamplepageinanewwindow(string text)
        {
            Window.MoveToNewWindow();
            StringAssert.Contains(text, WindowPage.WindowText);
            Browser.CloseBrowser();
            Window.ReturnToPreviousWindow();
        }
    }
}