using System;
using OpenQA.Selenium;
using Architecture.Web;

namespace Pages.PageObjects.Elements
{
    public class TablePage
    {
        public Element tblPersonalDetails = new Element(LocatorType.ClassName, "rt-table");
        public Element txtFirstName = new Element(LocatorType.Id, "firstName");
        public Element txtEmail = new Element(LocatorType.Id, "userEmail");
        public Element btnSubmit = new Element(LocatorType.Id, "submit");

        public void ClickEditButton(string rowText){
            var row = tblPersonalDetails.Row(rowText);
            row.FindElement(By.ClassName("mr-2")).Click();
        }

        public void ChangeEmail(string email){
            txtEmail.Text = email;
            btnSubmit.Click();
        }

        public string GetCellContent(string rowText, string columnText){
            return tblPersonalDetails.Cell(rowText, columnText).Text;
        }
    }
}