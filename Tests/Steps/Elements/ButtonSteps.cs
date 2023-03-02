using System;
using Pages.PageObjects;
using TechTalk.SpecFlow;
using Architecture.Web;
using NUnit.Framework;using Architecture.EnvironmentConfig;
using System.Collections.Generic;
using Pages.PageObjects.Elements;

namespace Tests.Steps.Elements
{
    [Binding]
    public class ButtonSteps
    {	
        ButtonPage ButtonPage = new ButtonPage();

        [Given(@"I'm on the Button Page")]
        public void GivenImontheButtonPage()
        {
            Browser.GoToUrl($"{EnvironmentDetails.BaseUrl}/buttons");
        }

        [When(@"I click on the Click Me button")]
        public void WhenIclickontheClickMebutton()
        {
            ButtonPage.ClickButtonClickMe();
        }

        [Then(@"I see a text '(.*)'")]
        public void ThenIseeatextYouhavedoneadynamicclick(string text)
        {
            Assert.AreEqual(text, ButtonPage.DynamicClickMessage);
        }
    }
}