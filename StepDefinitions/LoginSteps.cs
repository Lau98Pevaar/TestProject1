using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProject1.Pages;

namespace TestProject1.Feature
{
    [Binding]
    public class LoginSteps : DriverHelper
    {
        string Usertype;
        
        LoginPage loginPage = new LoginPage();
        UserApproval Userapproval = new UserApproval();

        [Given(@"QA enviroment login")]
        public void GivenQAEnviromentLogin()
        {
            Assert.That(loginPage.ElementExist(loginPage.containerLogin), Is.True, "Email fields did not displayed");
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
        
        [Then(@"Find the text box to enter the Email, Password")]
        public void ThenFindTheTextBoxToEnterTheEmailPassword()
        {
            Assert.That(loginPage.ElementExist(loginPage.txtUserName), Is.True, "Email fields did not displayed");
            Assert.That(loginPage.ElementExist(loginPage.txtPassword), Is.True, "Password fields did not displayed");
        }

        [When(@"Switch to admin")]
        public void WhenSwitchToAdmin(Table tabla)
        {
            dynamic UserType = tabla.CreateDynamicInstance();
            
            Usertype = UserType.UserType;


           if (Usertype == "Admin")
            {
                Userapproval.MyProfileMenu.Click();
                Userapproval.SwitchToAdmin.Click();
                Thread.Sleep(1000);
            }
            else
            {
                Thread.Sleep(1000);
            }
        }

       
        [Then(@"Shows the Dashboard LH")]
        public void ThenShowsTheDashboardLH()
        {
            if (Usertype == "Admin")
            {
                Assert.That(loginPage.WelcomeToAdminPage.Displayed, Is.True, "Welcome to admin page did not displayed");
                Thread.Sleep(1000);
            }
            else {
                Assert.That(loginPage.dashboardLH.Displayed, Is.True, " Dashboard did not displayed");
                Thread.Sleep(1000);
            }
            

        }
    }
}
