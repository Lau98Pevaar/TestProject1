using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public IWebElement CheckboxUserforApproval => Driver.FindElement(By.CssSelector("body > app-root > app-dashboard > div > section.mdk-drawer-layout__content.page > div > app-approvals > app-users-approval > div.card > div > synapze-cx-grid > div > table > tbody > tr:nth-child(1) > td:nth-child(2) > div"));
        //public IWebElement FirstUserforApproval => Driver.FindElement(By.XPath("/html/body/app-root/app-dashboard/div/section[1]/div/app-approvals/app-users-approval/div[2]/div/synapze-cx-grid/div/table/tbody/tr[1]/td[2]"));

        public ReadOnlyCollection<IWebElement> FirstUserforApproval => Driver.FindElements(By.ClassName("[type='checkbox']"));

        public IWebElement ApproveUserBtn => Driver.FindElement(By.XPath("/html/body/app-root/app-dashboard/div/section[1]/div/app-approvals/app-users-approval/div[2]/div/div/permission-block/div/user-approval-control/button"));

        public IWebElement ApprovalComments => Driver.FindElement(By.Id("approvalComments"));

        public IWebElement ApproveBtn => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[3]/div/div/permission-block/button"));

        public IWebElement ApprovalConfirm => Driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[1]"));

        public IWebElement CloseButton => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[3]/div/button"));

        public IWebElement NoResults => Driver.FindElement(By.XPath("/html/body/app-root/app-dashboard/div/section[1]/div/app-approvals/app-users-approval/div[2]/div/synapze-cx-grid/div/div"));
        //public IWebElement ApproveUserPrincipal => Driver.FindElement(By.XPath("/html/body/app-root/app-dashboard/div/section[1]/div/app-approvals/app-users-approval/div[2]/div/div/permission-block/div/user-approval-control/button"));
        public void SearchName(string Username)
        {
            //SearchInput.Click();
            SearchInput.SendKeys(Username);
            //Thread.Sleep(10000);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("/html/body/app-root/app-dashboard/div/section[1]/div/app-approvals/app-users-approval/div[2]/div/content-loader")));
            SearchInputBtn.Click(); 

            //IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            //executor.ExecuteScript("arguments[0].click();", SearchInputBtn);
            
            //Thread.Sleep(5000);
        }
        public void SelectTheUser()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", FirstUserforApproval[0]);
            ApproveUserBtn.Click();
            ApprovalComments.SendKeys("Welcome to Learning Hub");
            ApproveBtn.Click();
            ApprovalConfirm.Click();
            CloseButton.Click();
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));

            //wait.Until(ExpectedConditions.ElementToBeClickable(FirstUserforApproval[0]));
            //FirstUserforApproval[0].Click();
            //FirstUserforApproval.Click();
            //Userapproval.CheckboxUserforApproval.Selected;
            //Thread.Sleep(10000);

        }

            
            





        


    }
}
