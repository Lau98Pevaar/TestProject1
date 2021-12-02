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
    public class CreateModules : DriverHelper
    {
        CreateModulesPage Createmodulespage = new CreateModulesPage();
        [When(@"Select Learn Component")]
        public void WhenSelectLearnComponent()
        {
            Createmodulespage.LearnComponent.Click();
        }

        [When(@"Select modules and create new")]
        public void WhenSelectModulesAndCreateNew()
        {
            Createmodulespage.ModulesSubcomponent.Click();
            //Thread.Sleep(5000);
            Createmodulespage.CreateModuleBtn.Click();
        }

        [When(@"Fill all text boxes about this module")]
        public void WhenFillAllTextBoxesAboutThisModule()
        {
            Createmodulespage.TxtTitle.SendKeys(Createmodulespage.ModuleTitle + Actualdate);
            Createmodulespage.TxtDescription.SendKeys("txtDescription of module" + Actualdate);
            Thread.Sleep(8000);
             //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            //wait.Until(ExpectedConditions.InvisibilityOfElementWithText(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[9]/synapze-cx-form-control/tenant-location-selector/content-loader/div/div/div[2]"),"Loading"));
            //Createmodulespage.DateEffectiveOnModule.SendKeys(DateTime.Now.ToString("yyyy-MM-dd"));
            //Thread.Sleep(5000);}
            
            SelectOpOfDropdown(Createmodulespage.DurationMonthsDropdown,
                                                 Createmodulespage.DurationMonthsOp1);
            Createmodulespage.SelectOpOfDropdown(Createmodulespage.DurationDaysDropdown,
                                                 Createmodulespage.DurationDaysOp1);

            Createmodulespage.SelectOpOfDropdown(Createmodulespage.CategoryDropdown, Createmodulespage.CategoryOption1);
            Createmodulespage.SelectOpOfDropdown(Createmodulespage.SubCategoryDropdown,
                                                 Createmodulespage.SubCategoryOption1);
            Createmodulespage.AddCategoriesBtn.Click();
            Createmodulespage.SelectOpOfDropdown(Createmodulespage.SearchLocationDropdown,
                                                 Createmodulespage.SearchLocationOption1);
            Createmodulespage.SelectOpOfDropdown(Createmodulespage.SelectLocationDropdown,
                                                 Createmodulespage.SelectLocationOption1);
            Thread.Sleep(1000);
            Createmodulespage.AddLocationsButton.Click();
            Createmodulespage.SelectOpOfDropdown(Createmodulespage.SearchLocationDropdown,
                                                 Createmodulespage.SearchLocationOption1);
            Createmodulespage.SelectOpOfDropdown(Createmodulespage.SelectLocationDropdown,
                                                 Createmodulespage.SelectLocationOption2);
            Thread.Sleep(1000);
            Createmodulespage.AddLocationsButton.Click();
            Createmodulespage.TxtTag.SendKeys("AutomatedTest");
            Createmodulespage.AddTagBtn.Click();
        }

        [When(@"Add test out")]
        public void WhenAddTestOut()
        {
            Thread.Sleep(2000);
            Createmodulespage.CheckTestOut.Click();
            Thread.Sleep(1000);
            Createmodulespage.AddTestOut.Click();
            Thread.Sleep(1000);
            Createmodulespage.SelectTestOutOption1.Click();
            Thread.Sleep(1000);
            Createmodulespage.ConfirmTestOut.Click();
            Thread.Sleep(3000);
        }

        [When(@"Create sections and Add actions")]
        public void WhenCreateSectionsAndAddActions()
        {
            Createmodulespage.SectionInputText.SendKeys("Section");
            Createmodulespage.AddSectionBtn.Click();
            Createmodulespage.AddActionBtn.Click();
            Createmodulespage.SelectAssessment.Click();
            Createmodulespage.SelectResourcesTab.Click();
            Createmodulespage.SelectResourceOp1.Click();
            Createmodulespage.AddActionModalBtn.Click();
        }

        [When(@"Upload a cover image")]
        public void WhenUploadACoverImage()
        {
            Createmodulespage.ImageInput.SendKeys(PathFiles + @"\Files\CoverImage.jpg");
        }

        [When(@"Save and Publish the module")]
        public void WhenSaveAndPublishTheModule()
        {
            Createmodulespage.SaveBtn.Click();
            Createmodulespage.SaveBtnConfirm.Click();
            Createmodulespage.PublishBtn.Click();
        }

        [Then(@"Shows the module's table\.")]
        public void ThenShowsTheModuleSTable_()
        {
            Assert.AreEqual(Createmodulespage.FirstElementTable.Text, Createmodulespage.ModuleTitle + Actualdate, "Strings are not matching");
        }
    }
}
