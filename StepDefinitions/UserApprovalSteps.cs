using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestProject1.Pages;

namespace TestProject1.StepDefinitions
{
    [Binding]
    public class UserApprovalSteps : DriverHelper
    {
        UserApproval Userapproval = new UserApproval();

        [When(@"Click on My Profile Menu")]
        public void WhenClickOnMyProfileMenu()
        {
            Userapproval.MyProfileMenu.Click();
        }
        
        [When(@"Switch to admin")]
        public void WhenSwitchToAdmin()
        {
            Userapproval.SwitchToAdmin.Click();
            Thread.Sleep(1000);
            //Assert.That(Userapproval.WelcomeToAdminPage, Is.True, "Welcome to Admin Page did not displayed");
        }
        
        [When(@"Select Admin Component")]
        public void WhenSelectAdminComponent()
        {
            
            Userapproval.AdminComponent.Click();
        }
        
        [When(@"Select User Approvals")]
        public void WhenSelectUserApprovals()
        {

            Userapproval.UserApprovalsOption.Click();
            
            Assert.That(Userapproval.WelcomeToAdminPage, Is.True, "/html/body/app-root/app-dashboard/div/section[1]/div/app-approvals/app-users-approval/div[2]");
        }
        [When(@"Search the user recently registered")]
        public void WhenSearchTheUserRecentlyRegistered()
        {
            Userapproval.SearchInput.Click();
            Userapproval.SearchName();
        }

    }
}
