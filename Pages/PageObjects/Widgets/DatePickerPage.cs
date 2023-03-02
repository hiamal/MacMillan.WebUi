using System;
using OpenQA.Selenium;
using Architecture.Web;

namespace Pages.PageObjects.Widgets
{
    public class DatePickerPage
    {
        public Element txtDate = new Element(LocatorType.Id, "datePickerMonthYearInput");
        public Element txtDateAndTime = new Element(LocatorType.Id, "dateAndTimePickerInput");

        public Element ddnYearPicker = new Element(LocatorType.ClassName, "react-datepicker__year-select");

        public Element ddnMonthPicker = new Element(LocatorType.ClassName, "react-datepicker__month-select");

        public Element lblDayList = new Element(LocatorType.ClassName, "react-datepicker__month");

        public Element lstTimeList = new Element(LocatorType.ClassName, "react-datepicker__time-list");

        public Element btnYearPickerDownArrow = new Element(LocatorType.ClassName, "react-datepicker__year-read-view--down-arrow");

        public Element lstYearList = new Element(LocatorType.ClassName, "react-datepicker__year-dropdown");

        public Element btnMonthPickerDownArrow = new Element(LocatorType.ClassName, "react-datepicker__month-read-view--down-arrow");

        public Element lstMonthList = new Element(LocatorType.ClassName, "react-datepicker__month-dropdown");


        public void EnterDate(DateTime date) {
            var year = date.ToString("yyyy");
            var month = date.ToString("MMMM");
            var day = date.ToString("dd");

            txtDate.Click();
            ddnYearPicker.Select(year);
            ddnMonthPicker.Select(month);
            lblDayList.thisElement.FindElement(By.XPath("//div[.='" + day +"']")).Click();
        }

        public void EnterDateAndTime(DateTime date) {
            var year = date.ToString("yyyy");
            var month = date.ToString("MMMM");
            var day = date.ToString("dd");
            var time = date.ToString("HH:mm");
            
            txtDateAndTime.Click();

            btnYearPickerDownArrow.Click();
            lstYearList.thisElement.FindElement(By.XPath("//div[.='" + year +"']")).Click();
            btnMonthPickerDownArrow.Click();
            lstMonthList.thisElement.FindElement(By.XPath("//div[.='" + month +"']")).Click();
            lblDayList.thisElement.FindElement(By.XPath("//div[.='" + day +"']")).Click();

            lstTimeList.thisElement.FindElement(By.XPath("//li[.='" + time +"']")).Click();
        }

        public string EnteredDate => txtDate.Attribute("value");
        public string EnteredDateAndTime => txtDateAndTime.Attribute("value");

    }
}