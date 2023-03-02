using System;
using OpenQA.Selenium;
using Architecture.Web;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Reflection;

namespace Pages.PageObjects.Elements
{
    public class UploadDownloadPage
    {
        public Element btnDownload = new Element(LocatorType.Id, "downloadButton");
        public Element btnChooseFile = new Element(LocatorType.Id, "uploadFile");
        public Element txtUploadedFilePath = new Element(LocatorType.Id, "uploadedFilePath");


        public void DownloadFile() {
            btnDownload.Click();

            string downloadPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Downloads";
            new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(2)).Until(d => File.Exists(Path.Combine(downloadPath, "sampleFile.jpeg")));
        }

        public void UploadFile(string filePath) => btnChooseFile.Text = filePath;

        public string UploadedFilePath => txtUploadedFilePath.Text;

    }
}