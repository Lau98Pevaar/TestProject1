using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Pages.Register
{
    public class Register5Successful : DriverHelper
    {
        public IWebElement SuccessfullyTitle => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[2]"));
        public IWebElement RedirectLogin => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[3]/a"));

     }
}
