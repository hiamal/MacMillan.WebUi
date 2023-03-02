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
    public class DragAndDropPage
    {
        public Element dropSource = new Element(LocatorType.Id, "draggable");
        public Element dropTarget = new Element(LocatorType.Id, "draggable");
        public void DragAndDrop() => dropSource.DragDrop(dropTarget);

        public String TargetElementText => dropTarget.Text;
        
    }
}