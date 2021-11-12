using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Pages
{
    class ImportUsersPage : DriverHelper
    {
        public IWebElement UserManagerOption => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[2]/div[2]/div/div/ul/li[3]/ul/li[2]/a"));
        public IWebElement ImportUsersButton => Driver.FindElement(By.XPath("/html/body/app-root/app-dashboard/div/section[1]/div/ng-component/div[2]/div/div/div[2]/permission-block[3]/div/upload-media/div/label/input"));
        public IWebElement UploadButton => Driver.FindElement(By.XPath("/html/body/app-root/app-dashboard/div/section[1]/div/ng-component/div[2]/div/div/div[2]/permission-block[3]/div/div/div/button[2]"));
        public IWebElement ContainerUpload => Driver.FindElement(By.XPath("/html/body/modal-container/div/div"));
        public IWebElement OkButton => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[3]/div/button"));
        public IWebElement ContainerUserManager => Driver.FindElement(By.XPath("/html/body/app-root/app-dashboard/div/section[1]/div"));

        public bool ElementExist(IWebElement e) => e.Displayed;
    }
}
