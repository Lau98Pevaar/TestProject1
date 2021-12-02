using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace TestProject1
{
    public class DriverHelper
    {
        public static IWebDriver Driver { get; set; }
        public string PathFiles = Path.GetFullPath("../../..");      
    }
}
