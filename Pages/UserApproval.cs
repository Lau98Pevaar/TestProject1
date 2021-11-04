using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject1.Pages
{
    class UserApproval : DriverHelper
    {
        public string UserType = "Admin";

        public IWebElement MyProfileMenu => Driver.FindElement(By.XPath("/html/body/app-root/app-home/app-synapze-app-menu/div/div[2]/nav/div/ul/user-profile-menu/li/a"));
        public IWebElement SwitchToAdmin => Driver.FindElement(By.XPath("/html/body/app-root/app-home/app-synapze-app-menu/div/div[2]/nav/div/ul/user-profile-menu/li/div/div/a[1]/div"));
        
       

        public IWebElement AdminComponent => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[2]/div[2]/div/div/ul/li[3]/a"));
        public IWebElement UserApprovalsOption => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[2]/div[2]/div/div/ul/li[3]/ul/li[4]/a"));
        public IWebElement SearchInput => Driver.FindElement(By.Id("searchInput"));
        public IWebElement SearchInputBtn => Driver.FindElement(By.XPath("/html/body/app-root/app-dashboard/div/section[1]/div/app-approvals/app-users-approval/div[2]/div/div/div/user-search-parameters/form/div/div[2]/button[1]"));
        public void SearchName()
        {
            //SearchInput.Click();
            SearchInput.SendKeys("Laura");
            Thread.Sleep(9000);
            SearchInputBtn.Click();
        }
            
            





        


    }
}
