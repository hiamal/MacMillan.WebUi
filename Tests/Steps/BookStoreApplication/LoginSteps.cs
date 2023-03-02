using System;
using TechTalk.SpecFlow;
using Architecture.Web;
using Architecture.EnvironmentConfig;
using Pages.PageObjects.BookStoreApplication;
using NUnit.Framework;

namespace MyNamespace
{
    [Binding]
    public class StepDefinitions
    {		
        LoginPage LoginPage = new LoginPage();
        ProfilePage ProfilePage = new ProfilePage();

        [Given(@"I'm on the Login Page")]
        public void GivenImontheLoginPage()
        {
            Browser.GoToUrl($"{EnvironmentDetails.BaseUrl}/login");
        }

        [When(@"I login using the correct username and password")]
        public void WhenIloginusingthecorrectusernameandpassword()
        {
            LoginPage.Login(EnvironmentDetails.Username, EnvironmentDetails.Password);
        }

        [Then(@"I'm logged in successfully")]
        public void ThenImloggedinsuccessfully()
        {
            Assert.IsTrue(String.Compare(ProfilePage.Username, EnvironmentDetails.Username, StringComparison.OrdinalIgnoreCase)==0);
            ProfilePage.Logout();
        }

        [When(@"I login using the incorrect username and password")]
        public void WhenIloginusingtheincorrectusernameandpassword()
        {
            LoginPage.Login("test", "test");
        }

        [Then(@"I get an '(.*)' error")]
        public void ThenIgetanInvalidusernameorpassworderror(string error)
        {
            Assert.IsTrue(LoginPage.LoginButtonPresent);
            Assert.AreEqual(LoginPage.ErrorMessage, error);
        }

        [When(@"I login using the incorrect username")]
        public void WhenIloginusingtheincorrectusername()
        {
            LoginPage.Login("test", EnvironmentDetails.Password);
        }

        [Then(@"I'm not logged in")]
        public void ThenImnotloggedin()
        {
            Assert.IsTrue(LoginPage.LoginButtonPresent);
        }

        [When(@"I login using the incorrect password")]
        public void WhenIloginusingtheincorrectpassword()
        {
            LoginPage.Login(EnvironmentDetails.Username, "test");
        }

        [When(@"I login using empty username and password")]
        public void WhenIloginusingemptyusernameandpassword()
        {
            LoginPage.Login("", "");
        }

        [When(@"I login using empty username and correct password")]
        public void WhenIloginusingemptyusernameandcorrectpassword()
        {
            LoginPage.Login("", EnvironmentDetails.Password);
        }

        [When(@"I login using correct username and empty password")]
        public void WhenIloginusingcorrectusernameandemptypassword()
        {
            LoginPage.Login(EnvironmentDetails.Username, "");
        }
    }
}