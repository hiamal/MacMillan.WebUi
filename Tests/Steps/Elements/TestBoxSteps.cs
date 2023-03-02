using System;
using TechTalk.SpecFlow;
using Pages.PageObjects;
using NUnit.Framework;using Architecture.EnvironmentConfig;
using Architecture.Web;
using Pages.PageObjects.Elements;

namespace Tests.Steps.Elements
{
    [Binding]
    public class TextBoxSteps
    {
        TextBoxPage textBoxPage = new TextBoxPage();
        TextBoxDetails userDetails = new TextBoxDetails();

        [Given(@"I'm on the Textbox Pages")]
        public void GivenImontheTextboxPages()
        {
            Browser.GoToUrl($"{EnvironmentDetails.BaseUrl}/text-box");
        }

        [Given(@"I submit the form")]
        [When(@"I submit the form")]
        public void WhenIsubmittheform()
        {
            textBoxPage.ClickSubmit();
        }

        [Then(@"The output box is empty")]
        public void ThenTheoutputboxisempty()
        {
            Assert.AreEqual(textBoxPage.OutputText, "");
        }

        [When(@"I enter the details in the form")]
        public void WhenIenterthedetailsintheform()
        {
            userDetails.fullName = "Test Peter";
            userDetails.email = "Peter@test.com";
            userDetails.currentAddress = "5, Wimbledon Street, California, US 292282";
            userDetails.permanentAddress = "3, Melbourne Street, Melbourne, VIC 3399, Australia";

            textBoxPage.EnterDetails(userDetails);
        }

        [Then(@"The output box contains the details")]
        public void ThenTheoutputboxcontainsthedetails()
        {
            StringAssert.Contains(userDetails.fullName, textBoxPage.OutputText);
            StringAssert.Contains(userDetails.email, textBoxPage.OutputText);
            StringAssert.Contains(userDetails.currentAddress, textBoxPage.OutputText);
            StringAssert.Contains(userDetails.permanentAddress, textBoxPage.OutputText);
    
        }

        [Given(@"I clear all the details in the form")]

        [When(@"I clear all the details in the form")]            public void GivenIclearallthedetailsintheform()
        {
            userDetails.fullName = "";
            userDetails.email = "";
            userDetails.currentAddress = "";
            userDetails.permanentAddress = "";

            textBoxPage.EnterDetails(userDetails);
        }

    }
}