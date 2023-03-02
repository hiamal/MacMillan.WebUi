using System;
using Architecture.Web;

namespace Pages.PageObjects.Elements
{
    public class CheckBoxPage
    {
        public Element btnExpandAll = new Element(LocatorType.XPath, "//button[contains(@title,'Expand all')]");
        public Element chkHome = new Element(LocatorType.XPath, "//span[.='Home']//span[@class='rct-checkbox']");
        public Element chkDesktop = new Element(LocatorType.XPath, "//span[.='Desktop']//span[@class='rct-checkbox']");
        public Element chkDocuments = new Element(LocatorType.XPath, "//span[.='Documents']//span[@class='rct-checkbox']");
        public Element txtResult = new Element(LocatorType.Id, "result");
        
        public void ClickExpandAll() => btnExpandAll.Click();

        public void ClickHomeCheckbox() => chkHome.CheckBoxSelect();

        public void ClickDesktopCheckbox() => chkDesktop.CheckBoxSelect();

        public void ClickDocumentsCheckbox() => chkDocuments.CheckBoxSelect();

        public void ClearAllCheckBoxes(){
            chkHome.CheckBoxSelect();
            if(!chkHome.FindElements(LocatorType.TagName, "svg")[0].GetAttribute("class").Contains("uncheck"))
                chkHome.Click();
        }

        public string ResultText => txtResult.Text;
    }

}
