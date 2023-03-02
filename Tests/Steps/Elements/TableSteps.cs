using System;
using NUnit.Framework;using Architecture.EnvironmentConfig;
using NUnit;
using Pages.PageObjects;
using Architecture.Web;
using TechTalk.SpecFlow;
using Pages.PageObjects.Elements;

namespace Tests.Steps.Elements
{
    [Binding]
    public class TableSteps
    {
        TablePage TablePage = new TablePage();
        string newEmail = null;
        string rowText = null;
        
        [Given(@"I'm on the Table Page")]
        public void GivenImontheTablePage()
        {
            Browser.GoToUrl($"{EnvironmentDetails.BaseUrl}/webtables");
        }

        [When(@"I click Edit button in row (.*)")]
        public void WhenIclickEditbuttoninrowAlden(string text)
        {
            TablePage.ClickEditButton(text);
            rowText = text;
        }

        [When(@"I enter email as '(.*)'")]
        public void GivenIenteremailasaldennewEmailcom(string email)
        {
            TablePage.ChangeEmail(email);
            this.newEmail = email;
        }

        [Then(@"The email is updated")]
        public void ThenTheemailisupdated()
        {
            Assert.AreEqual(newEmail, TablePage.GetCellContent(rowText, "Email"));
        }

    }
}