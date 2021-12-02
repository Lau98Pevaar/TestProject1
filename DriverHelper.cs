using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using SeleniumExtras.WaitHelpers;

namespace TestProject1
{
    public class DriverHelper
    {
        public static IWebDriver Driver { get; set; }
        public string PathFiles = Path.GetFullPath("../../..");
        public string Actualdate = DateTime.Now.ToString(" dd-MM-yyyy,HH:mm");
       
        //public WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        public void SelectOpOfDropdown(By Dropdown, By Option)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement DropdownS = Driver.FindElement(Dropdown);
            wait.Until(ExpectedConditions.ElementToBeClickable(Dropdown));
            DropdownS.Click();
            IWebElement OptionS = Driver.FindElement(Option);
            OptionS.Click();
            
        }

    }
}
