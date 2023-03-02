using System;
using TechTalk.SpecFlow;
using Architecture.Web;
using Pages.PageObjects;
using NUnit.Framework;using Architecture.EnvironmentConfig;
using Pages.PageObjects.Widgets;

namespace Tests.Steps.Widgets
{
    [Binding]
    public class DatePickerSteps
    {
        DatePickerPage DatePickerPage = new DatePickerPage();
			
        [Given(@"I'm on the DatePicker Page")]
        public void GivenImontheDatePickerPage()
        {
            Browser.GoToUrl($"{EnvironmentDetails.BaseUrl}/date-picker");
        }

        [When(@"I select the date '(.*)-(.*)-(.*)' in the date field")]
        public void WhenIselectthedateinthedatefield(int day, int month, int year)
        {
            DatePickerPage.EnterDate(new DateTime(year, month, day));
        }

        [Then(@"I see the date set to '(.*)'")]
        public void ThenIseethedatesetto(string date)
        {
            Assert.AreEqual(date, DatePickerPage.EnteredDate);
        }

        [When(@"I select the date '(.*)-(.*)-(.*)' and time '(.*):(.*)' in the date and time field")]
        public void WhenIselectthedateandtimeinthedateandtimefield(int day, int month, int year, int hour, int minute)
        {
            //Console.WriteLine(new DateTime(year, month, day, hour, minute, 0));
            DatePickerPage.EnterDateAndTime(new DateTime(year, month, day, hour, minute, 0));
        }

        [Then(@"I see the date and time set to '(.*)'")]
        public void ThenIseethedateandtimesetto(string date)
        {
            Assert.AreEqual(date, DatePickerPage.EnteredDateAndTime);
        }

    }
}