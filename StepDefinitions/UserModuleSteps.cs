using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestProject1.Pages;

namespace TestProject1.StepDefinitions
{
    [Binding]
    public class UserModuleSteps : DriverHelper
    {
        UserModulePage Usermodulepage = new UserModulePage();
        [When(@"Select Explore")]
        public void WhenSelectExplore()
        {
            Thread.Sleep(8000);
            Usermodulepage.ExploreNavbar.Click();
            Thread.Sleep(3000);
            Usermodulepage.ModulesOption.Click();
            Thread.Sleep(10000);
            Assert.That(Usermodulepage.LoadingCardModules.Displayed, Is.True, "Modules doesn't charge");
            
        }
    }
}
