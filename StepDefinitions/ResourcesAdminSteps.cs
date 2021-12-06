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
    public class ResourcesAdminSteps : DriverHelper
    {
        string Resourcetype;
        ResourcesAdminPage Resourcesadmin = new ResourcesAdminPage();
        string NameResource = "Resource: " + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");

        [When(@"Select Resources Component")]
        public void WhenSelectResourcesComponent()
        {
            Thread.Sleep(1000);
            Resourcesadmin.ResourcesComponent.Click();
        }
        
        [When(@"Select Resources")]
        public void WhenSelectResources()
        {
            Resourcesadmin.Resources.Click();
            Thread.Sleep(3000);
        }
        
        [When(@"Select New Resource")]
        public void WhenSelectNewResource()
        {
            Resourcesadmin.NewResource.Click();
        }
        [When(@"Fill the title and date fields form Resource")]
        public void WhenFillTheTitleAndDateFieldsFormResource()
        {
            Resourcesadmin.RTitle.SendKeys(NameResource);
            Resourcesadmin.REffectiveDate.Click();
            Resourcesadmin.RSelectEffectiveDate.Click();
            Resourcesadmin.SelectDropdown(Resourcesadmin.DropCompetency, Resourcesadmin.OpcCompetency);
            Resourcesadmin.SelectDropdown(Resourcesadmin.DropSkill, Resourcesadmin.OpcSkill);
            Resourcesadmin.BtnAddSkill.Click();
            Resourcesadmin.SelectDropdown(Resourcesadmin.DropCategory, Resourcesadmin.OpcCategory);
            Resourcesadmin.SelectDropdown(Resourcesadmin.DropSubCategory, Resourcesadmin.OpcSubCategory);
            Resourcesadmin.BtnAddCategory.Click();
            Resourcesadmin.BtnAddMore.Click();

        }
        [When(@"Choose the resource and fill the fields")]
        public void WhenChooseTheResourceAndFillTheFields(Table table)
        {
            dynamic resource = table.CreateDynamicInstance();

            Resourcetype = resource.ResourceType;

            if (Resourcetype == "Podcast")
            {
                Resourcesadmin.BtnAddAttachment.SendKeys(PathFiles + @"\Files\Resources\Podcast.mp3");
                Resourcesadmin.addImage.SendKeys(PathFiles + @"\Files\Resources\ImagePodcast.png");
            }
            else if (Resourcetype == "Document")
            {
                Resourcesadmin.BtnAddAttachment.SendKeys(PathFiles + @"\Files\Resources\Document.docx");
                Resourcesadmin.addImage.SendKeys(PathFiles + @"\Files\Resources\ImageDocument.png");
            }
            else if (Resourcetype == "Video")
            {
                Resourcesadmin.BtnAddAttachment.SendKeys(PathFiles + @"\Files\Resources\Video.mp4");
                Resourcesadmin.addImage.SendKeys(PathFiles + @"\Files\Resources\ImageVideo.png");
            }
            else if (Resourcetype == "Webinar")
            {
                Resourcesadmin.btnLink.Click();
                Resourcesadmin.btnAddLink.SendKeys("https://www.bing.com/videos/search?view=detail&mid=E7FFB6A8DD8B6AC22DC8E7FFB6A8DD8B6AC22DC8&q=url webinar&shtp=GetUrl&shid=c90be0a4-f781-4183-8038-7e8e14d13f6c&shtk=wr9Dw7NtbyBhZ3JlZ2FyIHVuIGNhbGVuZGFyaW8gYSBudWVzdHJvIGdvb2dsZSBjYWxlbmRhciBtZWRpYW50ZSBVUkw%2F&shdk=RW4gZXN0ZSBwZXF1ZcOxbyB2aWRlb3R1dG9yaWFsIHRlIG1vc3RyYW1vcyBjw7NtbyBhZ3JlZ2FyIHVuIGNhbGVuZGFyaW8gYSBudWVzdHJvIGdvb2dsZSBjYWxlbmRhciBtZWRpYW50ZSBVUkwu&shhk=2s%2FGgUFwGm%2BnNSW7lSAWdj%2FuAsp6%2B6ooDemyGJ9rO8k%3D&form=VDSHOT&shth=OVP.XEyMKzDqNAhfcYAgOtkyRwEsDh");
                Resourcesadmin.addImage.SendKeys(PathFiles + @"\Files\Resources\ImageWebinar.jpg");
            }
            else if (Resourcetype == "Data")
            {
                Resourcesadmin.BtnAddAttachment.SendKeys(PathFiles + @"\Files\Resources\Data.zip");
                Resourcesadmin.addImage.SendKeys(PathFiles + @"\Files\Resources\ImageData.png");
            }
            Thread.Sleep(2000);
            Resourcesadmin.SelectDropdown(Resourcesadmin.dropLanguage, Resourcesadmin.opcLanguage);
            Resourcesadmin.rDuration.SendKeys("20");
            Resourcesadmin.SelectDropdown(Resourcesadmin.dropDurationtype, Resourcesadmin.opcDurationtype);
            Resourcesadmin.rDescriptionImage.SendKeys("Image Automated Test");
            Resourcesadmin.rTitleForm.SendKeys("Resource Automated Test");
            Resourcesadmin.rDescriptionForm.SendKeys("Description Resource Automated Test");
            Resourcesadmin.AddTag.SendKeys("Automated Test");
            Resourcesadmin.btnAddTag.Click();

            Resourcesadmin.SelectDropdown(Resourcesadmin.rDropSelectLocation, Resourcesadmin.rOpcLocation);
            Resourcesadmin.rAddLocations.Click();
            Resourcesadmin.SelectDropdown(Resourcesadmin.rDropSearchLocation, Resourcesadmin.rOpcAtlantic);
            Resourcesadmin.rAddLocations.Click();
            Resourcesadmin.SelectDropdown(Resourcesadmin.rDropSelectLocation, Resourcesadmin.rOpcLocation);
            Resourcesadmin.rAddLocations.Click();
            Resourcesadmin.SelectDropdown(Resourcesadmin.rDropSearchLocation, Resourcesadmin.rOpcFordCanada);
            Resourcesadmin.rAddLocations.Click();
            Resourcesadmin.SelectDropdown(Resourcesadmin.rDropSelectLocation, Resourcesadmin.rOpcRegion);
            Resourcesadmin.rAddLocations.Click();
            Resourcesadmin.SelectDropdown(Resourcesadmin.rDropSearchLocation, Resourcesadmin.rOpcWestern);
            Resourcesadmin.rAddLocations.Click();
            Resourcesadmin.SelectDropdown(Resourcesadmin.rDropSelectLocation, Resourcesadmin.rOpcRegion);
            Resourcesadmin.rAddLocations.Click();
            Resourcesadmin.SelectDropdown(Resourcesadmin.rDropSearchLocation, Resourcesadmin.rOpcPacific);
            Resourcesadmin.rAddLocations.Click();
            Resourcesadmin.rGoodtoGo.Click();
            Thread.Sleep(2000);
            Resourcesadmin.rSave.Click();
            Resourcesadmin.rConfirmSave.Click();
            Thread.Sleep(5000);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(120));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/modal-container/div/div/div[3]/div/button")));
            Resourcesadmin.rClose.Click();
            Resourcesadmin.rPublish.Click();
        }
        [Then(@"Shows the Resource")]
        public void ThenShowsTheResource()
        {
            Resourcesadmin.SearchResource.SendKeys(NameResource);
            Resourcesadmin.btnSearchResource.Click();
            Assert.AreEqual(Resourcesadmin.CheckResource.Text, NameResource, "Strings are not matching");
        }


    }
}
