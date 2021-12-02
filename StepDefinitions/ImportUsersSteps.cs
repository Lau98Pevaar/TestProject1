using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestProject1.Pages;

namespace TestProject1.StepDefinitions
{
    [Binding]
    public class ImportUsersSteps : DriverHelper
    {
        ImportUsersPage ImportUserPage = new ImportUsersPage();

        [When(@"Select User Manager")]
        public void WhenSelectUserManager()
        {
            ImportUserPage.UserManagerOption.Click();
        }
        
        [When(@"Select Import Users Button")]
        public void WhenSelectImportUsersButton()
        {
            Thread.Sleep(2000);
            ImportUserPage.ImportUsersButton.SendKeys(PathFiles + @"\Files\Resources\UserImportTemplate.xlsm");
        }
        [When(@"Select Upload Button")]
        public void WhenSelectUploadButton()
        {
            //Thread.Sleep(5000);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("/html/body/app-root/app-dashboard/div/section[1]/div/ng-component/div[2]/div/content-loader")));
            ImportUserPage.UploadButton.Click();
        }
        [When(@"Select Ok Button")]
        public void WhenSelectOkButton()
        {
            Thread.Sleep(8000);
            Assert.That(ImportUserPage.ElementExist(ImportUserPage.ContainerUpload), Is.True, "Container did not displayed");
            ImportUserPage.OkButton.Click();
        }
        [Then(@"Shows page User Manager")]
        public void ThenShowsPageUserManager()
        {
            Assert.That(ImportUserPage.ElementExist(ImportUserPage.ContainerUserManager), Is.True, "Page User Manager did not displayed");
        }


    }
}
