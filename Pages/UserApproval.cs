using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Pages
{
    class UserApproval : DriverHelper
    {

        public IWebElement MyProfileMenu => Driver.FindElement(By.XPath("/html/body/app-root/app-home/app-synapze-app-menu/div/div[2]/nav/div/ul/user-profile-menu/li/a"));
        public IWebElement SwitchToAdmin => Driver.FindElement(By.XPath("/html/body/app-root/app-home/app-synapze-app-menu/div/div[2]/nav/div/ul/user-profile-menu/li/div/div/a[1]/div"));
        
        public IWebElement WelcomeToAdminPage => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-admin-home/div"));

        public IWebElement AdminComponent => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[2]/div[2]/div/div/ul/li[3]/a"));
        public IWebElement UserApprovalsOption => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[2]/div[2]/div/div/ul/li[3]/ul/li[4]/a"));
        public IWebElement SearchInput => Driver.FindElement(By.Id("searchInput"));
        public void SearchName() => SearchInput.SendKeys("Laura");





        


    }
}
