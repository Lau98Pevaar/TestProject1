using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestProject1.Pages
{
    class CertificatesPage : DriverHelper
    {
        public IWebElement CertificatesComponent => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[2]/div[2]/div/div/ul/li[8]/a"));
        public IWebElement CertificatesCard => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-certificate/div[2]/div"));
        public IWebElement CreateCertificateBtn => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-certificate/div[1]/permission-block/button"));
        public IWebElement BigTitle => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-edit-certificate/content-loader/div/div/form/div[1]/div/synapze-cx-form-control/span"));
        public IWebElement TxtTitle => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-edit-certificate/content-loader/div/div/form/div[2]/div/div/synapze-cx-form-control/input"));
        public string Title= "Title Certificate Demo";
        public IWebElement FileLogo => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-edit-certificate/content-loader/div/div/form/div[4]/div/div[2]/upload-image-withpreview/div/label/input"));
        

        public IWebElement FileBackground => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-edit-certificate/content-loader/div/div/form/div[5]/div/div[2]/upload-image-withpreview/div/label/input"));
        public IWebElement FileSignature => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-edit-certificate/content-loader/div/div/form/div[7]/div/div[2]/upload-image-withpreview/div/label/input"));
        public IWebElement TxtSignName => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-edit-certificate/content-loader/div/div/form/div[6]/div[1]/div/synapze-cx-form-control/input"));
        public IWebElement TxtSignRole => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-edit-certificate/content-loader/div/div/form/div[6]/div[2]/div/synapze-cx-form-control/input"));
        public IWebElement SaveBtn => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-edit-certificate/content-loader/div/div/div/div[2]/permission-block/button"));
        public IWebElement ConfirmSaveBtn => Driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[1]"));
        public IWebElement CloseUploadFilesButton => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[3]/div/button"));
        
        public IWebElement PublishBtn => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-edit-certificate/content-loader/div/div/div/div[4]/permission-block[2]/button"));
        public IWebElement ConfirmPublishBtn => Driver.FindElement(By.XPath("/html/body/div[3]/div/div[3]/button[1]"));
        public string FirstElementTable => "/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-certificate/div[2]/div/div/app-certificate-search-grid/synapze-block-ui/div/synapze-cx-grid/div/table/tbody/tr[1]";
        public string FirstElementTitle => "/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-certificate/div[2]/div/div/app-certificate-search-grid/synapze-block-ui/div/synapze-cx-grid/div/table/tbody/tr[1]/td[1]";

    }
}
