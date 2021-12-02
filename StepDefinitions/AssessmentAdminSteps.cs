using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProject1.Pages;

namespace TestProject1.StepDefinitions
{
    [Binding]
    public class AssessmentAdminSteps : DriverHelper
    {
        string Assessmentype;
        string Triviatype;
        AssessmentAdminPage AssessmentAdminpage = new AssessmentAdminPage();
        string NameAssesment ="Asess "+ DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
       
        [When(@"Select Assessment Component")]
        public void WhenSelectAssessmentComponent()
        {
            Thread.Sleep(1000);
            AssessmentAdminpage.AssessmentComponent.Click();
        }

        [When(@"Select Assessment set")]
        public void WhenSelectAssessmentSet()
        {
            AssessmentAdminpage.AssessmentSet.Click();
            Thread.Sleep(3000);
        }
        
        [When(@"Select New Assesment")]
        public void WhenSelectNewAssesment()
        {
            AssessmentAdminpage.NewAssessment.Click();
        }
        
        [When(@"Fill the title and date fields")]
        public void WhenFillTheTitleAndDateFields()
        {
            //Assert.That(AssessmentAdminpage.ElementExist(AssessmentAdminpage.ContainerAssessment), Is.True, "Email fields did not displayed");
            AssessmentAdminpage.aTitle.SendKeys(NameAssesment);
            AssessmentAdminpage.aEffectiveDate.Click();
            AssessmentAdminpage.aSelectEffectiveDate.Click();
        }
        
        [When(@"Choose the type of assessment")]
        public void WhenChooseTheTypeOfAssessment(Table tableA)
        {
            dynamic dataAssessment = tableA.CreateDynamicInstance();

            Assessmentype = dataAssessment.AssessmentType;
            Triviatype = dataAssessment.TriviaType;
            AssessmentAdminpage.dropdownAT.Click();
            if (Assessmentype == "Test")
            {
                AssessmentAdminpage.Test.Click();
            }
            else if (Assessmentype == "Trivia")
            {
                AssessmentAdminpage.Trivia.Click();
            }
            else if (Assessmentype == "Survey")
            {
                AssessmentAdminpage.Survey.Click();
            }

        }
        
        [When(@"Fill all text boxes")]
        public void WhenFillAllTextBoxes()
        {
            if (Assessmentype == "Test")
            {
                AssessmentAdminpage.MaxAttempts.Click();
                AssessmentAdminpage.SelectMaxAttempts.Click();
                Thread.Sleep(2000);
                AssessmentAdminpage.PassingScore.SendKeys("30");
                Thread.Sleep(2000);
                AssessmentAdminpage.TestDuration.SendKeys("2");
                Thread.Sleep(2000);
                AssessmentAdminpage.SelectDropdown(AssessmentAdminpage.dropdownTestDuration, AssessmentAdminpage.SelectTestDuration);
                Thread.Sleep(2000);
                AssessmentAdminpage.SelectFeedBackAfter(0);
                AssessmentAdminpage.HintFeedBack.Click();
                AssessmentAdminpage.btnAddTest.Click();
            }
            else if (Assessmentype == "Trivia")
            {
                AssessmentAdminpage.AssessmentTriviaType.Click();
                if (Triviatype == "RapidFire")
                {
                    AssessmentAdminpage.RapidFire.Click();
                    AssessmentAdminpage.MaxAttemptsTrivia.Click();
                    AssessmentAdminpage.SelectMaxAttemptsTrivia.Click();
                    AssessmentAdminpage.PassingScoreTrivia.SendKeys("30");
                    AssessmentAdminpage.TriviaDuration.SendKeys("2");
                    AssessmentAdminpage.dropdownTriviaDuration.Click();
                    AssessmentAdminpage.SelectTriviaDuration.Click();
                    
                }
                else if (Triviatype == "SkillBuilder")
                {
                    AssessmentAdminpage.SkillBuilder.Click();
                    AssessmentAdminpage.CompetencyType.Click();
                    AssessmentAdminpage.SelectCompetencyType.Click();
                    AssessmentAdminpage.SkillsType.Click();
                    AssessmentAdminpage.SelecytSkillsType.Click();
                    AssessmentAdminpage.MaxAttemptsSB.Click();
                    AssessmentAdminpage.SelectMaxAttemptsSB.Click();
                    AssessmentAdminpage.PassingScoreSB.SendKeys("30");
                }
                else if (Triviatype == "Featured")
                {
                    AssessmentAdminpage.Featured.Click();
                    AssessmentAdminpage.MaxAttemptsTrivia.Click();
                    AssessmentAdminpage.SelectMaxAttemptsTrivia.Click();
                    AssessmentAdminpage.PassingScoreTrivia.SendKeys("30");
                    AssessmentAdminpage.DropdownCategory.Click();
                    AssessmentAdminpage.ChooseCategory.Click();
                    AssessmentAdminpage.btnAddCategory.Click();
                }
               
                AssessmentAdminpage.TimerTrivia.Click();
                AssessmentAdminpage.SelectFeedBackAfter(1);
                AssessmentAdminpage.btnAddTrivia.Click();
            }

            else if (Assessmentype == "Survey")
            {
                AssessmentAdminpage.SurveyDuration.SendKeys("2");
                AssessmentAdminpage.dropdownSurveyDuration.Click();
                AssessmentAdminpage.SelectSurveyDuration.Click();
                AssessmentAdminpage.btnAddSurvey.Click();
            }
        }

        [When(@"Complete the form")]
        public void WhenCompleteTheForm()
        {
            if (Assessmentype == "Test" || Assessmentype == "Trivia")
            {
                if (Assessmentype == "Test")
                {
                    AssessmentAdminpage.TitleTest.SendKeys("Test");
                    AssessmentAdminpage.DescriptionTest.SendKeys("Test Realizado con prueba automatizada");
                }
                else if (Assessmentype == "Trivia")
                {
                    AssessmentAdminpage.TitleTest.SendKeys("Trivia");
                    AssessmentAdminpage.DescriptionTest.SendKeys("Trivia Realizada con prueba automatizada");
                }

                AssessmentAdminpage.SelectDropdown(AssessmentAdminpage.DropdownLanguageTest, AssessmentAdminpage.SelectLanguageTest);
                //------ Add Locations ------
                AssessmentAdminpage.SelectDropdown(AssessmentAdminpage.SearchLocation,AssessmentAdminpage.opcLocation);
                AssessmentAdminpage.ButtonLocations(1);
                AssessmentAdminpage.SelectDropdown(AssessmentAdminpage.SelectLocation, AssessmentAdminpage.opcAtlantic);
                AssessmentAdminpage.ButtonLocations(1);
                AssessmentAdminpage.SelectDropdown(AssessmentAdminpage.SearchLocation, AssessmentAdminpage.opcLocation);
                AssessmentAdminpage.ButtonLocations(1);
                AssessmentAdminpage.SelectDropdown(AssessmentAdminpage.SelectLocation, AssessmentAdminpage.opcFordCanada);
                AssessmentAdminpage.ButtonLocations(1);
                AssessmentAdminpage.SelectDropdown(AssessmentAdminpage.SearchLocation, AssessmentAdminpage.opcRegion);
                AssessmentAdminpage.ButtonLocations(1);
                AssessmentAdminpage.SelectDropdown(AssessmentAdminpage.SelectLocation, AssessmentAdminpage.opcWestern);
                AssessmentAdminpage.ButtonLocations(1);
                AssessmentAdminpage.SelectDropdown(AssessmentAdminpage.SearchLocation, AssessmentAdminpage.opcRegion);
                AssessmentAdminpage.ButtonLocations(1);
                AssessmentAdminpage.SelectDropdown(AssessmentAdminpage.SelectLocation, AssessmentAdminpage.opcPacific);
                AssessmentAdminpage.ButtonLocations(1);

                AssessmentAdminpage.addQuestions.Clear();
                AssessmentAdminpage.addQuestions.SendKeys("1");
                AssessmentAdminpage.btnAddCompetencies.Click();
                AssessmentAdminpage.selectCompetencies.Click();
                AssessmentAdminpage.addCompetencies.Click();
                Thread.Sleep(1000);
                AssessmentAdminpage.btnAddSkills.Click();
                Thread.Sleep(1000);
                AssessmentAdminpage.SelectFeedBackAfter(3);
                AssessmentAdminpage.addSkills.Click();
                AssessmentAdminpage.addNumberSkills.Click();
                AssessmentAdminpage.btnSelectQuestions.Click();
                Thread.Sleep(5000);
                AssessmentAdminpage.SelectFeedBackAfter(5);
                Thread.Sleep(2000);
                AssessmentAdminpage.btnSaveQuestions.Click();

                if (Assessmentype == "Test")
                {
                    AssessmentAdminpage.btnSelectCertificate.Click();
                    AssessmentAdminpage.SelectCertificate.Click();
                    AssessmentAdminpage.btnSaveCertificate.Click();
                    AssessmentAdminpage.btnSaveTest.Click();
                    Thread.Sleep(1000);
                    AssessmentAdminpage.btnSaveAssessment.Click();
                    AssessmentAdminpage.AcceptSaveAssessment(38);
                    AssessmentAdminpage.btnPublishAssessment.Click();
                }
                else if (Assessmentype == "Trivia")
                {
                    AssessmentAdminpage.btnSaveTrivia.Click();
                    Thread.Sleep(2000);
                    AssessmentAdminpage.AcceptSaveAssessment(6);
                    AssessmentAdminpage.AcceptSaveAssessment(38);
                    AssessmentAdminpage.btnSaveAssessmentTrivia.Click();

                }
                
            }
            else if (Assessmentype == "Survey")
            {
                AssessmentAdminpage.TitleTest.SendKeys("Survey Title");
                AssessmentAdminpage.DescriptionTest.SendKeys("Survey realizado con prueba automatizada");

                AssessmentAdminpage.SelectDropdown(AssessmentAdminpage.DropdownLanguageSurvey, AssessmentAdminpage.SelectLanguageSurvey);
                //------ Add Locations ------
                AssessmentAdminpage.SelectDropdown(AssessmentAdminpage.SearchLocationSurvey, AssessmentAdminpage.opcLocationSurvey);
                AssessmentAdminpage.ButtonLocations(2);
                AssessmentAdminpage.SelectDropdown(AssessmentAdminpage.SelectLocationSurvey, AssessmentAdminpage.opcAtlanticSurvey);
                AssessmentAdminpage.ButtonLocations(2);
                AssessmentAdminpage.SelectDropdown(AssessmentAdminpage.SearchLocationSurvey, AssessmentAdminpage.opcLocationSurvey);
                AssessmentAdminpage.ButtonLocations(2);
                AssessmentAdminpage.SelectDropdown(AssessmentAdminpage.SelectLocationSurvey, AssessmentAdminpage.opcFordCanadaSurvey);
                AssessmentAdminpage.ButtonLocations(2);
                AssessmentAdminpage.SelectDropdown(AssessmentAdminpage.SearchLocationSurvey, AssessmentAdminpage.opcRegionSurvey);
                AssessmentAdminpage.ButtonLocations(2);
                AssessmentAdminpage.SelectDropdown(AssessmentAdminpage.SelectLocationSurvey, AssessmentAdminpage.opcWesternSurvey);
                AssessmentAdminpage.ButtonLocations(2);
                AssessmentAdminpage.SelectDropdown(AssessmentAdminpage.SearchLocationSurvey, AssessmentAdminpage.opcRegionSurvey);
                AssessmentAdminpage.ButtonLocations(2);
                AssessmentAdminpage.SelectDropdown(AssessmentAdminpage.SelectLocationSurvey, AssessmentAdminpage.opcPacificSurvey);
                AssessmentAdminpage.ButtonLocations(2);

                Thread.Sleep(1000);
                AssessmentAdminpage.btnSelectQuestionsSurvey.Click();
                Thread.Sleep(5000);
                AssessmentAdminpage.SelectFeedBackAfter(1);
                Thread.Sleep(1000);
                AssessmentAdminpage.btnSaveQuestions.Click();
                AssessmentAdminpage.btnSaveSurvey.Click();
                Thread.Sleep(1000);
                AssessmentAdminpage.btnSaveAssessmentSurvey.Click();
                AssessmentAdminpage.btnAcceptSaveAssessment.Click();
                Thread.Sleep(1000);
                AssessmentAdminpage.btnPublishAssessmentSurvey.Click();

            }
        }
        [Then(@"Shows the Assessment")]
        public void ThenShowsTheAssessment()
        {
            AssessmentAdminpage.SearchAssessment.SendKeys(NameAssesment);
            AssessmentAdminpage.btnSearchAssessment.Click();
            Assert.AreEqual(AssessmentAdminpage.CheckAssessment.Text,NameAssesment, "Strings are not matching");

        }


    }
}
