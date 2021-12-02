using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Pages
{
    class UserModulePage : DriverHelper
    {
        public IWebElement ExploreNavbar => Driver.FindElement(By.XPath("//a[contains(text(), 'Explore') and @class='nav-link hasChildren']"));
        public IWebElement ModulesOption => Driver.FindElement(By.XPath("//a[@title='Modules' and @class='nav-link']"));
        public IWebElement LoadingCardModules => Driver.FindElement(By.XPath("//app-loading-card[@class='container v-align-flex ng-star-inserted']"));
        ////app-loading
    }
}
