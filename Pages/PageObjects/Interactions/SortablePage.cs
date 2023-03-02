using System;
using OpenQA.Selenium;
using Architecture.Web;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace Pages.PageObjects.Interactions
{
    public class SortablePage
    {
        public Element listItemContainer = new Element(LocatorType.XPath, "//div[contains(@class,'vertical-list-container')]");
        public Element gridContainer = new Element(LocatorType.ClassName, "create-grid");

        public ReadOnlyCollection<IWebElement> listItems => listItemContainer.FindElements(LocatorType.TagName, "div");

        public void RearrangeListInDescendingOrder(){
            ReadOnlyCollection<IWebElement> listItems = listItemContainer.FindElements(LocatorType.XPath, "./div");
            List<String> descendingOrderList = new List<String> {"Six", "Five", "Four", "Three", "Two", "One"};
            for(int i=0; i<descendingOrderList.Count; i++){
                foreach (IWebElement item in listItems)
                    if (item.Text == descendingOrderList[i])
                        new Actions(Browser.Driver).ClickAndHold(item).MoveToElement(listItems[i], 10, 10).Release().Perform();
            }
        }

        public List<String> listItemsText{
            get{
                var listItemTextCollection = new List<String>();
                foreach(var item in listItems){
                    listItemTextCollection.Add(item.Text);
                }
                return listItemTextCollection;
            }
        }
    }
}