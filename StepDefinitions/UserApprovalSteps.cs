using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProject1.Pages;

namespace TestProject1.StepDefinitions
{
    [Binding]
    public class UserApprovalSteps : DriverHelper
    {
        RegisterSteps Registersteps = new RegisterSteps();
        UserApproval Userapproval = new UserApproval();
        LoginPage Loginpage = new LoginPage();


        [When(@"Select Admin Component")]
        public void WhenSelectAdminComponent()
        {
            Assert.That(Userapproval.AdminComponent.Displayed, Is.True, "User Approvals option did not displayer");
            Userapproval.AdminComponent.Click();
        }
        
        [When(@"Select User Approvals")]
        public void WhenSelectUserApprovals()
        {
            //Thread.Sleep(5000);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(driver => Userapproval.UserApprovalsOption.Displayed);
            

            Userapproval.UserApprovalsOption.Click();


        }
        [When(@"Search the user recently registered")]
        public void WhenSearchTheUserRecentlyRegistered(Table tabla)
        {
            dynamic UserForApproval = tabla.CreateDynamicInstance();

            string Userforapproval = UserForApproval.UserForApproval;
        
            //Thread.Sleep(10000);
            //Assert.That(Userapproval.UserApprovalsOption.Displayed, Is.True, "Bar not displayed");
            Userapproval.SearchName(Userforapproval);
            
        }

        [When(@"Select the user found")]
        public void WhenSelectTheUserFound()
        {
            Thread.Sleep(10000);
            Userapproval.SelectTheUser();
            
        }

        [Then(@"No matching records found")]
        public void ThenNoMatchingRecordsFound()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            wait.Until(driver => Userapproval.NoResults.Displayed);
            Assert.That(Userapproval.NoResults.Displayed, Is.True, " the user is not approved");
        }



    }
}
