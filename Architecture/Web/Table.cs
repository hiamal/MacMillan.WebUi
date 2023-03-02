using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;

namespace Architecture.Web
{
    public static class Table
    {
        public static IWebElement Cell(this Element table, string rowHeader, string columnHeader){
            var columnIndex = -1;
            var headers = table.FindElements(LocatorType.XPath, ".//div[contains(@class,'rt-th ')]");
            for(var i=0;i<headers.Count; i++)
                if(headers[i].Text.Contains(columnHeader))
                    columnIndex = i;
            
            var rows = table.FindElements(LocatorType.XPath, ".//div[contains(@class,'rt-tr ')]");

            foreach(var row in rows)
                if(row.Text.Contains(rowHeader))
                    return row.FindElements(By.ClassName("rt-td"))[columnIndex];

            throw new Exception("Row with rowHeader '"+ rowHeader + "' not found");
        }

        public static IWebElement Row(this Element table, string rowText){
            var rows = table.FindElements(LocatorType.XPath, ".//div[contains(@class,'rt-tr ')]");
            foreach(var row in rows)
                if(row.Text.Contains(rowText))
                    return row;

            throw new Exception("Row with rowText '"+ rowText + "' not found");
        }
    }
}
