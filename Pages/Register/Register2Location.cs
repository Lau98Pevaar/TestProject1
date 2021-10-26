using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Pages.Register
{
    public class Register2Location : DriverHelper
    {


        //Location
        
        public IWebElement DropdownLocation => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div/form/div[3]/div[1]/div/div/div"));
        
        public IWebElement DropdownLocationOptions => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div/form/div[3]/div[1]/div/div/div/div[2]/div/div[2]/div"));

        public IWebElement SelectLocation => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div/form/div[3]/div[1]/div/div/div/div[2]/div/div[2]/div/div[1]"));
        


        //MarketAreas
        public IWebElement DropdownMarketAreas => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div/form/div[3]/div[2]/div/div/div/div/div[1]"));
        
        public IWebElement DropdownMarketAreasOptions => Driver.FindElement(By.XPath(""));
        public IWebElement SelectMarketAreas => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div/form/div[3]/div[2]/div/div/div/div/div[2]/div/div"));
        
        //Region
        public IWebElement DropdownRegion => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div/form/div[3]/div[2]/div[2]/div/div/div/div[1]"));
        
        //public IWebElement DropdownRegionOptions => Driver.FindElement(By.XPath(""));
        public IWebElement SelectRegion => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div/form/div[3]/div[2]/div[2]/div/div/div/div[2]"));
        
        //

        //Next B
        public IWebElement NextButton => Driver.FindElement(By.Id("nextBtn2"));
        
    }
}
