using System;
using TechTalk.SpecFlow;
using Pages;
using NUnit.Framework;
using Architecture.Web;
using Architecture.EnvironmentConfig;

namespace Tests
{
    [Binding]
    public class Start
    {
        [BeforeTestRun]
        public static void BeforeAllTests(){
            Browser.GoToUrl(EnvironmentDetails.BaseUrl);
        }

        [AfterTestRun]
        public static void AfterAllTests(){
            Browser.CloseBrowsers();
        }
    }
}