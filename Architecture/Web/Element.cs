using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;

namespace Architecture.Web
{
    public class Element
    {
        private string locator;
        private LocatorType locatorType;
        private IWebDriver driver => Browser.Driver;
        
        public Element(LocatorType locatorType, string locator)
        {
            this.locatorType = locatorType;
            this.locator = locator;

        }

        public IWebElement thisElement => locatorType == LocatorType.Id ? driver.FindElement(By.Id(locator))
                                                : locatorType == LocatorType.ClassName ? driver.FindElement(By.ClassName(locator))
                                                : locatorType == LocatorType.Name ? driver.FindElement(By.Name(locator))
                                                : locatorType == LocatorType.XPath ? driver.FindElement(By.XPath(locator))
                                                : locatorType == LocatorType.TagName ? driver.FindElement(By.TagName(locator))
                                                : null;

        public ReadOnlyCollection<IWebElement> FindElements(LocatorType locatorType, string locator ) => locatorType == LocatorType.Id ? thisElement.FindElements(By.Id(locator))
                                                : locatorType == LocatorType.ClassName ? thisElement.FindElements(By.ClassName(locator))
                                                : locatorType == LocatorType.Name ? thisElement.FindElements(By.Name(locator))
                                                : locatorType == LocatorType.XPath ? thisElement.FindElements(By.XPath(locator))
                                                : locatorType == LocatorType.TagName ? thisElement.FindElements(By.TagName(locator))
                                                : null;
        public string Text
        {
            get => thisElement.Text;
            set {
                    thisElement.Clear();
                    thisElement.SendKeys(value);
                }
        }

        public void Click() => thisElement.Click();

        public void CheckBoxSelect() {
            if(!thisElement.Selected)
                thisElement.Click();
        }

        public void ClearCheckBox(){
            if(thisElement.Selected)
                thisElement.Click();
        }

        public string Attribute(string attributeName) => thisElement.GetAttribute(attributeName);
        public void Select(string text) => new SelectElement(thisElement).SelectByText(text);

        public void DragDrop(Element to) => new Actions(driver).DragAndDrop(thisElement, to.thisElement).Perform();

        public void Hover() => new Actions(driver).MoveToElement(thisElement).Perform();

        public void RightClick() => new Actions(driver).ContextClick(thisElement).Perform();

        public void DoubleClick() => new Actions(driver).DoubleClick(thisElement).Perform();

        public bool Exists => thisElement == null ? false : true;
    }

    public enum LocatorType{
        Id,
        ClassName,
        Name,
        XPath,
        TagName
    }
}