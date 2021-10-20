using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProject1.Pages;

namespace TestProject1.Feature
{
    [Binding]
    public class LoginSteps : DriverHelper
    {
        
        LoginPage loginPage = new LoginPage();

        [Given(@"QA enviroment login")]
        public void GivenQAEnviromentLogin()
        {
            Assert.That(loginPage.containerLoginExist(), Is.True, "Container did not displayed");
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
            loginPage.SwitchRememberMe();
        }
        
        [When(@"Select Next button login")]
        public void WhenSelectNextButtonLogin()
        {
            loginPage.ClickLogin();
        }
        
        [Then(@"Find the text box to enter the Email, Password")]
        public void ThenFindTheTextBoxToEnterTheEmailPassword()
        {
            Assert.That(loginPage.txtUserNameAndPasswordExist(), Is.True, "Email and Password fields did not displayed");
        }
        
        [Then(@"Shows the Dashboard LH")]
        public void ThenShowsTheDashboardLH()
        {
            Assert.That(loginPage.dashboardLHExist(), Is.True, "Dashboard did not displayed");
        }
    }
}
