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
    public class CertificatesSteps : DriverHelper
    {
        CertificatesPage Certificatespage = new CertificatesPage();
        [When(@"Select Certificates Component")]
        public void WhenSelectCertificatesComponent()
        {
            Certificatespage.CertificatesComponent.Click();
            Thread.Sleep(1000);
            Certificatespage.CreateCertificateBtn.Click();
            Thread.Sleep(3000);
        }
        [When(@"Fill all text boxes about certificates")]
        public void WhenFillAllTextBoxesAboutCertificates()
        {
            Certificatespage.BigTitle.SendKeys(Certificatespage.Title + Actualdate);
            Certificatespage.TxtTitle.SendKeys(Certificatespage.Title);
            Certificatespage.TxtSignName.SendKeys("Clark Rent");
            Certificatespage.TxtSignRole.SendKeys("Director");
            Thread.Sleep(2000);
        }

        [When(@"Upload logo, background and signature")]
        public void WhenUploadLogoBackgroundAndSignature()
        {
            Certificatespage.FileLogo.SendKeys(PathFiles + @"\Files\logo.gif");
            Certificatespage.FileBackground.SendKeys(PathFiles + @"\Files\background.png");
            Certificatespage.FileSignature.SendKeys(PathFiles + @"\Files\signature.png");
            Thread.Sleep(5000);
        }

        [When(@"Save and publish the certificate")]
        public void WhenSaveAndPublishTheCertificate()
        {
            //while (Certificatespage.SaveBtn.Enabled == false)
            Certificatespage.SaveBtn.Click();

            Thread.Sleep(3000);

            //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[3]/button[1]")));
            Certificatespage.ConfirmBtn.Click();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.TextToBePresentInElementLocated(By.XPath("/html/body/modal-container/div/div/div[2]/div/div[2]"), "Success"));
            Certificatespage.CloseUploadFilesButton.Click();
            Certificatespage.PublishBtn.Click();
            Certificatespage.ConfirmBtn.Click();
        }

        [Then(@"Shows the certificates table")]
        public void ThenShowsTheCertificatesTable()
        {

            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            //wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("/html/body/app-root/app-dashboard/div/section[1]/div/app-approvals/app-users-approval/div[2]/div/content-loader")));
            Thread.Sleep(5000);
            Assert.AreEqual(Certificatespage.FirstElementTable.Text, Certificatespage.Title + Actualdate, "Strings are not matching");

        }



    }
}
