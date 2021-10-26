using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProject1.Pages;

namespace TestProject1.StepDefinitions
{
    [Binding]
    public class LoginFailedSteps
    {
        //LoginPage loginPage = new LoginPage();
        LoginFailed loginFailedPage = new LoginFailed();

        [Given(@"QA enviroment LoginFailed")]
        public void GivenQAEnviromentLoginFailed()
        {
            Assert.That(loginFailedPage.ElementExist(loginFailedPage.containerLogin), Is.True, "Login container did not displayed");

        }
        
        [Given(@"Find the text box to enter the Email and Password")]
        public void GivenFindTheTextBoxToEnterTheEmailAndPassword()
        {
            Assert.That(loginFailedPage.ElementExist(loginFailedPage.txtUserName), Is.True, "Email fields did not displayed");
            Assert.That(loginFailedPage.ElementExist(loginFailedPage.txtPassword), Is.True, "Password fields did not displayed");
        }
        
        [When(@"Fill the fields Email and Password")]
        public void WhenFillTheFieldsEmailAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginFailedPage.EnterUserNameAndPassword(data.Email, data.Password);
        }
        
        [When(@"Click on Enter Button")]
        public void WhenClickOnEnterButton()
        {
            loginFailedPage.btnLogin.Click();
        }
        
        [When(@"Click on Lost Your Password")]
        public void WhenClickOnLostYourPassword()
        {
            loginFailedPage.LinkForgotPassword.Click();
        }
        
        [When(@"Fill the Email")]
        public void WhenFillTheEmail()
        {
            Assert.That(loginFailedPage.ElementExist(loginFailedPage.PageForgotPassword), Is.True, "Page Forgot Password did not displayed");
            loginFailedPage.txtEmail.SendKeys("marianaconde@gmail.com");
        }
        
        [When(@"Click on Send Email")]
        public void WhenClickOnSendEmail()
        {
            loginFailedPage.BtnSendEmail.Click();
        }
        
        [When(@"Get Email Link")]
        public void WhenGetEmailLink()
        {
            loginFailedPage.EmailText();
        }
        
        [When(@"Go to Email Link")]
        public void WhenGoToEmailLink()
        {
            loginFailedPage.GoToPage();
            Assert.That(loginFailedPage.ElementExist(loginFailedPage.ContainerResetPassword), Is.True, "Page Reset Password did not displayed");

        }
        
        [When(@"Fill the security question")]
        public void WhenFillTheSecurityQuestion()
        {
            Assert.That(loginFailedPage.ElementExist(loginFailedPage.ContainerResetPassword), Is.True, "Page Reset Password did not displayed");
            loginFailedPage.txtSecurityQuestion.SendKeys("Answer");
        }
        
        [When(@"Click on Next Button")]
        public void WhenClickOnNextButton()
        {
            loginFailedPage.NextButton.Click();
        }
        
        [When(@"Then Click on Reset Password")]
        public void WhenThenClickOnResetPassword()
        {
            loginFailedPage.ClickResetPassword.Click();
        }
    
        [Then(@"Show again QA enviroment")]
        public void ThenShowAgainQAEnviroment()
        {
            loginFailedPage.ClickQAButton.Click();
        }
    }
}
