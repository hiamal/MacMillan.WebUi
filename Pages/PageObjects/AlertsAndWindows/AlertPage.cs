using System;
using OpenQA.Selenium;
using Architecture.Web;

namespace Pages.PageObjects.AlertsAndWindows
{
    public class AlertPage
    {
        public Element btnPromtButton = new Element(LocatorType.Id , "promtButton");

        public Element txtPromptResult = new Element(LocatorType.Id, "promptResult");

        public void ClickPromptButon() => btnPromtButton.Click();

        public void EnterAlertText(string text) => Alert.EnterText(text);

        public void AceptAlert() => Alert.Accept();

        public string PromptResult => txtPromptResult.Text;


    }
}