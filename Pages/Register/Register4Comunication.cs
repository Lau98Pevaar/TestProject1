using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Pages.Register
{
    public class Register4Comunication : DriverHelper
    {
        public IWebElement MoveUpdateSwitch => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div/form/div[5]/div/div[2]/div/div[2]/label/span"));

       public IWebElement ButtonPolicyAndPrivacyLink => Driver.FindElement(By.Id("PrivacyPolicy"));

        public IWebElement PagePolicyAndPrivacy => Driver.FindElement(By.Id("privacyPolicyModal"));

        public IWebElement ClosePolicyAndPriv => Driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/button"));

        public IWebElement TermsAndConditionLink => Driver.FindElement(By.Id("TermsAndConditions"));

        public IWebElement PageTermsAndConditionLink => Driver.FindElement(By.Id("termsModal"));
        public IWebElement CloseTermsAndCondition => Driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div[3]/button"));

        public IWebElement AgreeSwitch => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div/form/div[5]/div/div[3]/div/div[2]/label/span"));
         
        public IWebElement NextButton => Driver.FindElement(By.Id("nextBtn4"));

    }
}
