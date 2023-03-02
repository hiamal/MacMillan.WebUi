using System;
using OpenQA.Selenium;
using Architecture.Web;
using System.Collections.Generic;

namespace Pages.PageObjects.Widgets
{
    public class AutoCompletePage
    {
        public Element ddnMultiAutoCompleteBox = new Element(LocatorType.Id, "autoCompleteMultipleInput");

        public Element ddnSingleAutoCompleteBox = new Element(LocatorType.Id, "autoCompleteSingleInput");
        public Element autoCompleteMenuItem = new Element(LocatorType.XPath, "//div[contains(@class,'auto-complete__menu')]/div");

        public Element ddnMultiAutoCompleteContainer = new Element(LocatorType.XPath, "//div[contains(@class,'auto-complete__value-container--is-multi')]");
        public Element ddnSingleAutoCompleteContainer = new Element(LocatorType.Id, "autoCompleteSingleContainer");

        public void EnterMultipleAutoCompleteItems(List<string> colors){
            foreach(string color in colors){
                ddnMultiAutoCompleteBox.Text = color;
                autoCompleteMenuItem.Click();
            }
        }

        public void EnterSingleAutoCompleteItem(string color = "Black") {
            ddnSingleAutoCompleteBox.Text = color;
            autoCompleteMenuItem.Click();
        }

        public string MultipleAutoCompleteBoxText => ddnMultiAutoCompleteContainer.Text;

        public string SingleAutoCompleteBoxText => ddnSingleAutoCompleteContainer.Text;


    }
}