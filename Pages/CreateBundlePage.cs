using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Pages
{
    class CreateBundlePage :DriverHelper
    {
        public IWebElement BundleSubcomponent => Driver.FindElement(By.XPath("//a[@class='sidebar-menu-button ng-star-inserted' and @href='/admin/subscription/bundle']"));
        public IWebElement NewBundleBtn => Driver.FindElement(By.XPath("//button[contains(text(), '+ Bundle')]"));
        public string BundleTitle => "A.T Bundle" + Actualdate;
    }
}
