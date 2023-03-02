using System;
using OpenQA.Selenium;
using Architecture.Web;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace Pages.PageObjects.BookStoreApplication
{
    public class ProfilePage
    {
        public Element lblUsername = new Element(LocatorType.Id, "userName-value");
        public Element btnLogout = new Element(LocatorType.Id, "submit");

        public string Username => lblUsername.Text;

        public void Logout() => btnLogout.Click();
    }
}