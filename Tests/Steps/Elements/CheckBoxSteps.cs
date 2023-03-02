using System;
using NUnit.Framework;using Architecture.EnvironmentConfig;
using NUnit;
using Pages.PageObjects.Elements;
using Architecture.Web;
using TechTalk.SpecFlow;

namespace Tests.Steps.Elements
{
    [Binding]
    public class CheckBoxSteps
    {
        CheckBoxPage CheckBoxPage = new CheckBoxPage();

       [Given(@"I'm on the Checkbox Pages")]
        public void ImOnCheckboxPage(){
            Browser.GoToUrl($"{EnvironmentDetails.BaseUrl}/checkbox");
        }
       [When(@"I check the Desktop Checkbox")]
       public void ICheckDocumentsCheckbox(){
            CheckBoxPage.ClickExpandAll();
            CheckBoxPage.ClickDesktopCheckbox();
       }

       [Then(@"The results pane contains the text (.*)")]
       public void ResultsPaneContainsTextDocuments(string text){
            StringAssert.Contains(text,CheckBoxPage.ResultText);
       }

        [When(@"I check the Desktop And Documents Checkbox")]
        public void WhenIchecktheDesktopAndDocumentsCheckbox()
        {
            CheckBoxPage.ClickExpandAll();
            CheckBoxPage.ClearAllCheckBoxes();

            CheckBoxPage.ClickDesktopCheckbox();
            CheckBoxPage.ClickDocumentsCheckbox();
        }

        [When(@"I check the Home Checkbox")]
        public void ICheckHomeCheckbox(){
            CheckBoxPage.ClickExpandAll();
            CheckBoxPage.ClearAllCheckBoxes();

            CheckBoxPage.ClickHomeCheckbox();
       }
    }
}