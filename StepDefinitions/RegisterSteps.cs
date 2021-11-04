using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProject1.Pages.Register;

namespace TestProject1.StepDefinitions
{
    [Binding]
    public class RegisterSteps : DriverHelper
    {
        Register1Info Register1info = new Register1Info();
        Register2Location Register2location = new Register2Location();
        Register3Security Register3security = new Register3Security();
        Register4Comunication Register4comunication = new Register4Comunication();
        Register5Successful Register5successful = new Register5Successful();
        public string Usernamerecently;
        [Given(@"Register button exists")]
        public void GivenRegisterButtonExists()
        {
            Assert.That(Register1info.BtnRegister.Displayed, Is.True, "Register button doesn't exist");
        }
        
        [When(@"Click the register button")]
        public void WhenClickTheRegisterButton()
        {
            Register1info.BtnRegister.Click();
        }
        
        [When(@"Fill all fields about personal information")]
        public void WhenFillAllFieldsAboutPersonalInformation(Table table)
        {
            
            dynamic data = table.CreateDynamicInstance();
            Usernamerecently = data.Email;
            Register1info.EnterNameLastNameAndEmail(data.Name, data.LastName, data.Email);

            
            Assert.That(Register1info.DropdownSpeciality.Displayed, Is.True, "Speciality dropdown didn't displayed");
            Register1info.DropdownSpeciality.Click();
            Register1info.DropdownSpeciality.Click();
                       
            Register1info.SelectSpeciality.Click();
            

            Register1info.DropdownRole.Click();
            Register1info.DropdownRole.Click();

            Register1info.SelectRole.Click();

        }

        [When(@"Click on the first Next button")]
        public void WhenClickOnTheFirstNextButton()
        {
            Register1info.NextButton.Click();
        }

        [When(@"Fill all fields about location")]
        public void WhenFillAllFieldsAboutLocation()
        {
            //Assert.That(Register2location.DropdownLocation.Displayed, Is.True, "Location dropdown didn't displayed");
            Thread.Sleep(1000);
            Register2location.DropdownLocation.Click();
            Thread.Sleep(1000);
            Register2location.DropdownLocation.Click();
            
            //Register2location.DropdownLocation.Click(>);
            Register2location.SelectLocation.Click();

            Register2location.DropdownMarketAreas.Click();
            Register2location.DropdownMarketAreas.Click();
            Register2location.SelectMarketAreas.Click();

            Register2location.DropdownRegion.Click();
            Register2location.DropdownRegion.Click();
            Register2location.SelectRegion.Click();
        }
        
        [When(@"Click on the second Next button")]
        public void WhenClickOnTheSecondNextButton()
        {
            Register2location.NextButton.Click();
        }
        
        [When(@"Fill all fields about security")]
        public void WhenFillAllFieldsAboutSecurity(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Register3security.EnterSecurityBoxes(data.Password, data.AnswerA, data.AnswerB, data.AnswerC);
        }
        
        [When(@"Click on the third Next button")]
        public void WhenClickOnTheThirdNextButton()
        {
            Register3security.NextButton.Click();
        }
        
        [When(@"Select language, read all and click on both switches for comunication")]
        public void WhenSelectLanguageReadAllAndClickOnBothSwitchesForComunication()
        {
            Register4comunication.MoveUpdateSwitch.Click();
            Register4comunication.AgreeSwitch.Click();
        }
        
        [When(@"Click on the fourth Next button")]
        public void WhenClickOnTheFourthNextButton()
        {
            Register4comunication.NextButton.Click();
        }
        
        [When(@"Click login button at register successfull page")]
        public void WhenClickLoginButtonAtRegisterSuccessfullPage()
        {
            Register5successful.RedirectLogin.Click();
        }
        
        [Then(@"Shows Login page")]
        public void ThenShowsLoginPage()
        {
            Assert.That(Register1info.BtnRegister.Displayed, Is.True, "Register button doesn't exist");
        }
    }
}
