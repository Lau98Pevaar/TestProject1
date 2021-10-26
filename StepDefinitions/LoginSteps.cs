using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProject1.Pages;

namespace TestProject1.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginPage = new LoginPage();
        [Given(@"QA enviroment login")]
        public void GivenQAEnviromentLogin()
        {
            Assert.That(loginPage.ElementExist(loginPage.containerLogin), Is.True, "Login container did not displayed");
        }
        
        [Given(@"Find the text box to enter the Email, Password")]
        public void GivenFindTheTextBoxToEnterTheEmailPassword()
        {
            Assert.That(loginPage.ElementExist(loginPage.txtUserName), Is.True, "Email fields did not displayed");
            Assert.That(loginPage.ElementExist(loginPage.txtPassword), Is.True, "Password fields did not displayed");
        }
        
        [When(@"Fill the fields")]
        public void WhenFillTheFields(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.EnterUserNameAndPassword(data.Email, data.Password);
        }
        
        [When(@"Move the remember me switch")]
        public void WhenMoveTheRememberMeSwitch()
        {
            loginPage.swRememberMe.Click();
        }
        
        [When(@"Select Next button login")]
        public void WhenSelectNextButtonLogin()
        {
            loginPage.btnLogin.Click(); 
        }
        
        [Then(@"Shows the Dashboard LH")]
        public void ThenShowsTheDashboardLH()
        {
            Assert.That(loginPage.ElementExist(loginPage.dashboardLH), Is.True, "Dashboard did not displayed");
        }
    }
}
