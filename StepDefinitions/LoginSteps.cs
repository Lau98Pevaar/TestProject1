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
            Assert.That(loginPage.containerLogin.Displayed, Is.True, "Email fields did not displayed");
        }
        [Given(@"Find the text box to enter the Email, Password")]
        public void GivenFindTheTextBoxToEnterTheEmailPassword()
        {
            Assert.That(loginPage.txtUserName.Displayed, Is.True, "Email fields did not displayed");
            Assert.That(loginPage.txtPassword.Displayed, Is.True, "Password fields did not displayed");
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
            Assert.That(loginPage.txtUserName.Displayed, Is.True, "Email fields did not displayed");
            Assert.That(loginPage.txtPassword.Displayed, Is.True, "Password fields did not displayed");
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
                //Thread.Sleep(5000);
                //WaitForElement(Userapproval.MyProfileMenu);
            }
           else if (Usertype == "New")
            {
                loginPage.AdministrativeProcesses.Click();
                loginPage.Algebra.Click();
                loginPage.Books.Click();
                loginPage.Geometria.Click();
                loginPage.Microsoft.Click();
                loginPage.Music.Click();
                loginPage.ContinueBtn.Click();
                loginPage.GotIt.Click();
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
                
                Thread.Sleep(5000);
                //Assert.That(loginPage.dashboardLH.Displayed, Is.True,"Dashboard did not displayed");
                //SelectOpOfDropdown(loginPage.LanguageDropdown, loginPage.LanguageOptionEN);
                //Thread.Sleep(10000);
                // Dashboard Header
                Assert.That(loginPage.navEvents.Displayed, Is.True,"txtTitle Events did not displayed");
                Assert.That(loginPage.navExplore.Displayed, Is.True,"txtTitle Explore did not displayed");
                Assert.That(loginPage.navLearn.Displayed, Is.True,"txtTitle Learn did not displayed");
                Assert.That(loginPage.navNews.Displayed, Is.True,"txtTitle News did not displayed");
                Assert.That(loginPage.navTrivia.Displayed, Is.True,"txtTitle Trivia did not displayed");
                Assert.That(loginPage.ImageHeader.Displayed, Is.True,"Image Header did not displayed");
                // Dashboard Filters
                Assert.That(loginPage.btnFilter.Displayed, Is.True,"Button Filter did not displayed");
                Assert.That(loginPage.searchBar.Displayed, Is.True, "Search Bar did not displayed");
                Assert.That(loginPage.btnSearch.Displayed, Is.True, "Button Search did not displayed");
                Assert.That(loginPage.btnClear.Displayed, Is.True, "Clear Button did not displayed");
                loginPage.btnFilter.Click();
                Assert.That(loginPage.filterFrom.Displayed, Is.True, "Field From did not displayed");
                Assert.That(loginPage.filterTo.Displayed, Is.True, "Field To did not displayed");
                Assert.That(loginPage.filterTopics.Displayed, Is.True, "Field Topics did not displayed");
                Assert.That(loginPage.filterBtnClear.Displayed, Is.True, "Button Clear in filter did not displayed");
                Assert.That(loginPage.filterBtnApply.Displayed, Is.True, "Button Apply in filter did not displayed");
                loginPage.filterBtnApply.Click();
                Thread.Sleep(5000);
                // Dashboard Body
                Assert.That(loginPage.topic1.Displayed, Is.True,"Section Topic 1 did not displayed");
                Assert.That(loginPage.topic2.Displayed, Is.True,"Section Topic 2 did not displayed");
                Assert.That(loginPage.topic3.Displayed, Is.True,"Section Topic 3 did not displayed");
                Assert.That(loginPage.containerTopics.Displayed, Is.True, "Container Topics did not displayed");
                // Dashboard Footer
                Assert.That(loginPage.progressCorePath.Displayed, Is.True,"Progress Core Path did not displayed");
                Assert.That(loginPage.resources.Displayed, Is.True,"Section Resources did not displayed");
                Assert.That(loginPage.rFavorites.Displayed, Is.True,"Section Favorites Resources did not displayed");
                Assert.That(loginPage.rTrending.Displayed, Is.True,"Section Trending Resources did not displayed");
                Assert.That(loginPage.containerResources.Displayed, Is.True, "Container Resources did not displayed");
                Assert.That(loginPage.containerTimeResources.Displayed, Is.True, "Container Time Resources did not displayed");
                

            }

            

        }
    }
}
