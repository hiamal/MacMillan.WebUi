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
        CheckBoxPage checkboxBoxPage = new CheckBoxPage();

       [Given(@"I'm on the Checkbox Pages")]
        public void ImOnCheckboxPage(){
            Browser.GoToUrl($"{EnvironmentDetails.BaseUrl}/checkbox");
        }
       [When(@"I check the Desktop Checkbox")]
       public void ICheckDocumentsCheckbox(){
            checkboxBoxPage.ClickExpandAll();
            checkboxBoxPage.ClickDesktopCheckbox();
       }

       [Then(@"The results pane contains the text (.*)")]
       public void ResultsPaneContainsTextDocuments(string text){
            StringAssert.Contains(text,checkboxBoxPage.ResultText);
       }

        //[Test, Order(1)]
        public void SelectDesktopAndDocumentsCheckbox()
        {
            Browser.GoToUrl($"{EnvironmentDetails.BaseUrl}/checkbox");
            checkboxBoxPage.ClickDesktopCheckbox();
            checkboxBoxPage.ClickDownloadsCheckbox();
            StringAssert.Contains("Desktop", checkboxBoxPage.ResultText);
            StringAssert.Contains(checkboxBoxPage.ResultText, "Downloads");
            StringAssert.DoesNotContain(checkboxBoxPage.ResultText, "Home");
        }

        //[Test, Order(2)]
        public void SelectHomeCheckbox()
        {
            Browser.GoToUrl($"{EnvironmentDetails.BaseUrl}/checkbox");
            checkboxBoxPage.ClickHomeCheckbox();
            StringAssert.Contains(checkboxBoxPage.ResultText, "Home");
            StringAssert.Contains(checkboxBoxPage.ResultText, "Documents");
        }
    }
}