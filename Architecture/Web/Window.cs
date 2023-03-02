using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;
using System.Linq;

namespace Architecture.Web
{
    public static class Window{
        public static string CurrentWindowHandle = null;

        public static void MoveToNewWindow() {
            CurrentWindowHandle = Browser.Driver.CurrentWindowHandle;
            string newWindowHandle = Browser.Driver.WindowHandles.FirstOrDefault(handle => handle != CurrentWindowHandle);
            Browser.Driver.SwitchTo().Window(newWindowHandle);
        }

        public static void ReturnToPreviousWindow() {
            Browser.Driver.SwitchTo().Window(CurrentWindowHandle);
        }
    }
}