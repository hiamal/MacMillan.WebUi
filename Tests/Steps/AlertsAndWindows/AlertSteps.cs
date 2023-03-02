using System;
using TechTalk.SpecFlow;
using Pages.PageObjects;
using Architecture.Web;
using NUnit.Framework;
using Architecture.EnvironmentConfig;
using Pages.PageObjects.AlertsAndWindows;
using Architecture.EnvironmentConfig;

namespace Tests.Steps.AlertsAndWindows
{
    [Binding]
    public class AlertSteps
    {		
        AlertPage AlertPage = new AlertPage();

        [Given(@"I'm on the Alerts Page")]
        public void GivenImontheAlertsPage()
        {
            Browser.GoToUrl($"{EnvironmentDetails.BaseUrl}/alerts");
        }

        [When(@"I click on the prompt box button")]
        public void WhenIclickonthepromptboxbutton()
        {
            AlertPage.ClickPromptButon();
        }

        [Then(@"I can enter text '(.*)' into the alert")]
        public void ThenIcanentertextsampletextintothealert(string text)
        {
            AlertPage.EnterAlertText(text);
        }

        [Then(@"I can accept the alert")]
        public void GivenIcanacceptthealert()
        {
            AlertPage.AceptAlert();
        }
			
        [Then(@"I can see '(.*)' in the prompt result")]
        public void ThenIcanseesampletextinthepromptresult(string text)
        {
            StringAssert.Contains(text, AlertPage.PromptResult);
        }

    }
}

