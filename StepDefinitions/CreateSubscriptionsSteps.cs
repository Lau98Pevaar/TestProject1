using System;
using TestProject1.Pages;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace TestProject1.StepDefinitions
{
    [Binding]

    public class CreateSubscriptionsSteps : DriverHelper
    {
        CreateSubscriptionPage Createsubscriptionpage = new CreateSubscriptionPage();
        [When(@"Select Subscriptions Component")]
        public void WhenSelectSubscriptionsComponent()
        {
            Createsubscriptionpage.SubscriptionComponent.Click();
            Createsubscriptionpage.SubscriptionSubcomponent.Click();
        }

        [When(@"Create a new Subscription")]
        public void WhenCreateANewSubscription()
        {
            Createsubscriptionpage.NewSubscriptionBtn.Click();
        }

        [When(@"Fill all fields about Subscriptions")]
        public void WhenFillAllFieldsAboutSubscriptions()
        {
            Createsubscriptionpage.TxtTitle.SendKeys(Createsubscriptionpage.SubsTitle);
            Createsubscriptionpage.TxtName.SendKeys("Name");
            Createsubscriptionpage.TxtDescription.SendKeys("Description");
            //Createsubscriptionpage.EffectiveDateInput.SendKeys(DateTime.Now.ToString("yyyy-MM-dd"));
            Createsubscriptionpage.EffectiveDateBtn.Click();
            Createsubscriptionpage.EffectiveDateTodayBtn.Click();
            Createsubscriptionpage.FrecuencyInput.SendKeys("1");
            Createsubscriptionpage.TimeUnitFrecuencyDropdown.Click();
            Createsubscriptionpage.TimeUnitOpYear.Click();
            Createsubscriptionpage.AmountInput.SendKeys("5");
            Createsubscriptionpage.AddPathsBtn.Click();
            Createsubscriptionpage.SelectOp1.Click();
            Createsubscriptionpage.ConfirmPath.Click();

            Createsubscriptionpage.AddModulesBtn.Click();
            Createsubscriptionpage.SelectOp1.Click();
            Createsubscriptionpage.ConfirmPath.Click();

            Createsubscriptionpage.AddResourcesBtn.Click();
            Createsubscriptionpage.SelectOpRes.Click();
            Createsubscriptionpage.ConfirmPath.Click();

        }

        [When(@"Save and Publish the Subscription")]
        public void WhenSaveAndPublishTheSubscription()
        {
            Createsubscriptionpage.SaveBtn.Click();
            Createsubscriptionpage.ConfirmModalBtn.Click();
            Createsubscriptionpage.PublishBtn.Click();
            Createsubscriptionpage.ConfirmModalBtn.Click();
        }

        [Then(@"Display the Subscription in the Subscriptions table")]
        public void ThenDisplayTheSubscriptionInTheSubscriptionsTable()
        {
            Assert.AreEqual(Createsubscriptionpage.FirstElementTable.Text, Createsubscriptionpage.SubsTitle, "Strings are not matching");
        }
    }
}
