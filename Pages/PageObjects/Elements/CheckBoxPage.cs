using System;
using Architecture.Web;

namespace Pages.PageObjects.Elements
{
    public class CheckBoxPage
    {
        public Element btnExpandAll = new Element(LocatorType.XPath, "//button[contains(@title,'Expand all')]");
        public Element chkHome = new Element(LocatorType.XPath, "//span[.='Home']//span[@class='rct-checkbox']");
        public Element chkDesktop = new Element(LocatorType.XPath, "//span[.='Desktop']//span[@class='rct-checkbox']");
        public Element chkDownloads = new Element(LocatorType.XPath, "//span[.='Downloads']//span[@class='rct-checkbox']");
        public Element txtResult = new Element(LocatorType.Id, "result");
        public Element txtOutput = new Element(LocatorType.Id, "output");

        public void ClickExpandAll() => btnExpandAll.Click();

        public void ClickHomeCheckbox() => chkHome.Click();

        public void ClickDesktopCheckbox() => chkDesktop.Click();

        public void ClickDownloadsCheckbox() => chkDownloads.Click();

        public string ResultText => txtResult.Text;
    }

    public class TextBoxDetails
    {
        public string fullName { get; set; }
        public string email { get; set; }
        public string currentAddress { get; set; }
        public string permanentAddress { get; set; }
    }
}
