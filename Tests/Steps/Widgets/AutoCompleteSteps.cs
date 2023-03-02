using System;
using TechTalk.SpecFlow;
using Pages.PageObjects;
using Architecture.Web;
using NUnit.Framework;using Architecture.EnvironmentConfig;
using System.Collections.Generic;
using Pages.PageObjects.Widgets;

namespace Tests.Steps.Widgets
{
    [Binding]
    public class AutoCompleteSteps
    {
        AutoCompletePage AutoCompletePage = new AutoCompletePage();
        string color = null;
			
        [Given(@"I'm on the Auto-Complete Page")]
        public void GivenImontheAutoCompletePage()
        {
            Browser.GoToUrl($"{EnvironmentDetails.BaseUrl}/auto-complete");
        }

        [When(@"I add colours (.*) and (.*) to the multiple auto-complete box")]
        public void WhenIaddmultiplecolourstothemultipleautocompletebox(string color1, string color2)
        {
            var colors = new List<string>{color1, color2};
            AutoCompletePage.EnterMultipleAutoCompleteItems(colors);
        }

        [Then(@"The colours are successfully entered in the multiple auto-complete box")]
        public void ThenThecoloursaresuccessfullyenteredinthemultipleautocompletebox()
        {
            StringAssert.Contains("Blue", AutoCompletePage.MultipleAutoCompleteBoxText);
            StringAssert.Contains("Green", AutoCompletePage.MultipleAutoCompleteBoxText);
        }
        [When(@"I add the colour '(.*)' to the single auto-complete box")]
        public void WhenIaddthecolourBluetothesingleautocompletebox(string color)
        {
            AutoCompletePage.EnterSingleAutoCompleteItem(color);
            this.color = color;
        }

        [Then(@"The colour is successfully entered in the single auto-complete box")]
        public void ThenThecolourissuccessfullyenteredinthesingleautocompletebox()
        {
            StringAssert.Contains(color, AutoCompletePage.SingleAutoCompleteBoxText);
        }

    }
}