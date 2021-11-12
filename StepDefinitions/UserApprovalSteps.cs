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

        
        [When(@"Select Admin Component")]
        public void WhenSelectAdminComponent()
        {
            Userapproval.AdminComponent.Click();
        }
        
        [When(@"Select User Approvals")]
        public void WhenSelectUserApprovals()
        {

            Userapproval.UserApprovalsOption.Click();
            Thread.Sleep(30);
            //Assert.That(Userapproval.WelcomeToAdminPage, Is.True, "/html/body/app-root/app-dashboard/div/section[1]/div/app-approvals/app-users-approval/div[2]");
        }
        [When(@"Search the user recently registered")]
        public void WhenSearchTheUserRecentlyRegistered()
        {
            //Userapproval.SearchName("Laura");
            Thread.Sleep(3000);
        }

    }
}
