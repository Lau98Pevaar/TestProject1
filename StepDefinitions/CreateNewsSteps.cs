using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestProject1.Pages;

namespace TestProject1.StepDefinitions
{
    [Binding]
    public class CreateNewsSteps : DriverHelper
    {
        CreateNewsPage Createnewspage = new CreateNewsPage();
        [When(@"Select News component")]
        public void WhenSelectNewsComponent()
        {
            Thread.Sleep(1000);
            Createnewspage.NewsComponent.Click();
        }
        
        [When(@"Create a new article")]
        public void WhenCreateANewArticle()
        {
            Createnewspage.AddArticleBtn.Click();
            Createnewspage.AddArticleFile.SendKeys(PathFiles + @"\Files\TestFile.pdf");
        }
        
        [When(@"Fill all fields about News")]
        public void WhenFillAllFieldsAboutNews()
        {
            Createnewspage.TxtTitle.SendKeys(Createnewspage.NewsTitle + Actualdate);
            Createnewspage.TxtDescription.SendKeys("Descripción");
            Thread.Sleep(4000);

            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            //wait.Until(ExpectedConditions.ElementToBeClickable(Createnewspage.TopicDropdown));

            SelectOpOfDropdown(Createnewspage.TopicDropdown, Createnewspage.TopicOption2);
            
            SelectOpOfDropdown(Createnewspage.LocationDropdown, Createnewspage.LocationDropdownOp1);
            SelectOpOfDropdown(Createnewspage.SelectDropdownLocation, Createnewspage.SelectLocationOp1);
            //Assert.That(Createnewspage.AddLocationBtn.Displayed, Is.True, "No yet");
            //Thread.Sleep(3000);                    
            Createnewspage.AddLocationBtn.Click();
            SelectOpOfDropdown(Createnewspage.LocationDropdown, Createnewspage.LocationDropdownOp1);
            SelectOpOfDropdown(Createnewspage.SelectDropdownLocation, Createnewspage.SelectLocationOp2);
            Createnewspage.AddLocationBtn.Click();
            Createnewspage.TxtTag.SendKeys("AutomatedTest");
            Createnewspage.AddTagBtn.Click();
            Createnewspage.CoverImageFile.SendKeys(PathFiles + @"\Files\News.png");
            Thread.Sleep(1000);
            Createnewspage.TxtDuration.SendKeys("1");
            SelectOpOfDropdown(Createnewspage.DurationTypeDropdown, Createnewspage.DurationTypeOption2);
        }
        
        [When(@"Save and Publish the article")]
        public void WhenSaveAndPublishTheArticle()
        {
            Thread.Sleep(2000);
            Createnewspage.SaveBtn.Click();
            Createnewspage.SaveBtnConfirm.Click();
            Createnewspage.PublishBtn.Click();
        }
        
        [Then(@"Display the article in the news table")]
        public void ThenDisplayTheArticleInTheNewsTable()
        {
            Assert.AreEqual(Createnewspage.FirstElementTable.Text, Createnewspage.NewsTitle + Actualdate, "Strings are not matching");
        }
    }
}
