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
    public class LoginPage
    {
        public Element txtUsername = new Element(LocatorType.Id, "userName");
        public Element txtPassword = new Element(LocatorType.Id, "password");

        public Element btnLogin = new Element(LocatorType.Id, "login");

        public Element lblErrorMessage = new Element(LocatorType.Id, "name");

        public void Login(string username, string password){
            txtUsername.Text = username;
            txtPassword.Text = password;
            btnLogin.Click();
        }

        public string ErrorMessage => lblErrorMessage.Text;

        public bool LoginButtonPresent => btnLogin.Exists;
        
    }
}