using System;
using TechTalk.SpecFlow;
using Pages.PageObjects;
using Architecture.Web;
using NUnit.Framework;using Architecture.EnvironmentConfig;
using System.Collections.Generic;
using Pages.PageObjects.Interactions;

namespace Tests.Steps.Interactions
{
    [Binding]
    public class SortableSteps
    {
        SortablePage SortablePage = new SortablePage();

        [Given(@"I'm on the Sortable Page")]
        public void GivenImontheSortablePage()
        {
            Browser.GoToUrl($"{EnvironmentDetails.BaseUrl}/sortable");
        }

        [When(@"I arrange the items in descending order")]
        public void WhenIarrangetheitemsindescendingorder()
        {
            SortablePage.RearrangeListInDescendingOrder();
        }

        [Then(@"The list is sorted in descending order")]
        public void Thenthelistissortedindescendingorder()
        {
            Assert.AreEqual(SortablePage.listItemsText, new List<string> {"Six", "Five", "Four", "Three", "Two", "One"});
        }
    }
}