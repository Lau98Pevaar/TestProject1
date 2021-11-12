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
    public class CertificatesSteps: DriverHelper
    {
        CertificatesPage Certificatespage = new CertificatesPage();
        [When(@"Select Certificates Component")]
        public void WhenSelectCertificatesComponent()
        {
            Certificatespage.CertificatesComponent.Click();
            Thread.Sleep(1000);
            
            Certificatespage.CreateCertificateBtn.Click();
            Thread.Sleep(2000);

        }
        [When(@"Fill all text boxes about certificates")]
        public void WhenFillAllTextBoxesAboutCertificates()
        {
            Certificatespage.BigTitle.SendKeys(Certificatespage.Title);
            Certificatespage.TxtTitle.SendKeys(Certificatespage.Title);
            Certificatespage.TxtSignName.SendKeys("Clark Rent");
            Certificatespage.TxtSignRole.SendKeys("Director");
        }

        [When(@"Upload logo, background and sognature")]
        public void WhenUploadLogoBackgroundAndSignature()
        {
            Certificatespage.FileLogo.SendKeys(Certificatespage.PathFiles + @"\Files\logo.gif");
            Certificatespage.FileBackground.SendKeys(Certificatespage.PathFiles + @"\Files\background.png");
            Certificatespage.FileSignature.SendKeys(@Certificatespage.PathFiles + @"\Files\signature.png");
            Thread.Sleep(5000);
        }

        [When(@"Save and publish the certificate")]
        public void WhenSaveAndPublishTheCertificate()
        {
            
            Certificatespage.SaveBtn.Click();
            Thread.Sleep(3000);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[3]/button[1]")));
            Certificatespage.ConfirmSaveBtn.Click();
            wait.Until(ExpectedConditions.TextToBePresentInElementLocated(By.XPath("/html/body/modal-container/div/div/div[2]/div/div[2]"), "Success"));
            Certificatespage.CloseUploadFilesButton.Click();
            Certificatespage.PublishBtn.Click();
            Certificatespage.ConfirmPublishBtn.Click();
        }

        [Then(@"Shows the certificates table")]
        public void ThenShowsTheCertificatesTable()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
            
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("/html/body/app-root/app-dashboard/div/section[1]/div/app-approvals/app-users-approval/div[2]/div/content-loader")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(Certificatespage.FirstElementTable)));
            Assert.That(Certificatespage.FirstElementTitle.Equals(Certificatespage.Title), Is.True, "QWorker");


        }



    }
}
