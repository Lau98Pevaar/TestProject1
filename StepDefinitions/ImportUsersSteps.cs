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
            ImportUserPage.ImportUsersButton.SendKeys(@"C:\Users\Public\Archivos\UserImportTemplate.xlsm");
        }
        [When(@"Select Upload Button")]
        public void WhenSelectUploadButton()
        {
            Thread.Sleep(5000);
            ImportUserPage.UploadButton.Click();
        }

    }
}
