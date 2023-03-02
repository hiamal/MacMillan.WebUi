using System;
using TechTalk.SpecFlow;
using Architecture.Web;
using Pages.PageObjects;
using NUnit.Framework;using Architecture.EnvironmentConfig;
using System.Threading.Tasks;
using Pages.PageObjects.Widgets;

namespace Tests.Steps.Widgets
{
    [Binding]
    public class ToolTipSteps
    {

        ToolTipPage ToolTipPage = new ToolTipPage();
        
        [Given(@"I'm on the ToolTip Page")]
        public void GivenImontheToolTipPage()
        {
            Browser.GoToUrl($"{EnvironmentDetails.BaseUrl}/tool-tips");
        }

        [When(@"I hover over the Hover me button")]
        public void WhenIhoverovertheHovermebutton()
        {
            ToolTipPage.HoverOnHoverMeButton();
        }

        [Then(@"I see tooltip text '(.*)'")]
        public void ThenIseetooltiptext(string toolTipText)
        {
            Assert.AreEqual(toolTipText, ToolTipPage.ToolTipText);
        }

    }
}