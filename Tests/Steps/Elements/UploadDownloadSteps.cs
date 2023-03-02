using System;
using TechTalk.SpecFlow;
using Architecture.Web;
using Pages.PageObjects;
using NUnit.Framework;
using Architecture.EnvironmentConfig;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using Pages.PageObjects.Elements;

namespace Tests.Steps.Elements
{
    [Binding]
    public class UploadDownloadSteps
    {	
        UploadDownloadPage UploadDownloadPage = new UploadDownloadPage();
        string fileName;

        [Given(@"I'm on the Upload Download Page")]
        public void GivenImontheUploadDownloadPage()
        {
            Browser.GoToUrl($"{EnvironmentDetails.BaseUrl}/upload-download");
        }

        [When(@"I click on the Download button")]
        public void WhenIclickontheDownloadbutton()
        {
            UploadDownloadPage.DownloadFile();
        }

        [Then(@"A '(.*)' file is downloaded to downloads folder")]
        public void ThenASampleFileisdownloadedtodownloadsfolder(string fileName)
        {
            string downloadPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile) + "/Downloads";
            Assert.True(File.Exists(Path.Combine(downloadPath, fileName)));
        }

        [When(@"I upload the '(.*)' file")]
        public void WhenIuploadtheSampleFilefile(string fileName)
        {
            // Get the directory of the current file
            string currentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // Navigate to the TestData folder relative to the current file
            string testDataDirectory = Path.Combine(currentDirectory, "..", "..", "..", "..", "Architecture", "TestData");

            // Get the full path to the test file in TestData folder under Architecture
            string filePath = Path.GetFullPath(Path.Combine(testDataDirectory, fileName));

            UploadDownloadPage.UploadFile(filePath);
            this.fileName = fileName;
        }

        [Then(@"I see the 'SampleFile' path after the upload")]
        public void ThenIseetheSampleFilepathaftertheupload()
        {
            StringAssert.Contains(fileName, UploadDownloadPage.UploadedFilePath);
        }
    }
}