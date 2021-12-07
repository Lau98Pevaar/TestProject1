using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestProject1.Pages;

namespace TestProject1.StepDefinitions
{
    [Binding]
    public class CreateBundlesSteps : DriverHelper
    {
        CreateBundlePage Createbundlepage = new CreateBundlePage();
        CreateSubscriptionPage Createsubscriptionpage = new CreateSubscriptionPage();
        [When(@"Create a new Bundle")]
        public void WhenCreateANewBundle()
        {
            Createbundlepage.BundleSubcomponent.Click();
            Createbundlepage.NewBundleBtn.Click();
            Createsubscriptionpage.TxtTitle.SendKeys(Createbundlepage.BundleTitle);
        }
        
        [Then(@"Display the Bundle in the Bundles table")]
        public void ThenDisplayTheBundleInTheBundlesTable()
        {
            Assert.AreEqual(Createsubscriptionpage.FirstElementTable.Text, Createbundlepage.BundleTitle, "Strings are not matching");
        }
    }
}
