using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Pages
{
    class CreateNewsPage : DriverHelper
    {
        public By Loader = By.XPath("//div[@class='message']");
        public IWebElement NewsComponent => Driver.FindElement(By.XPath("//a[@href='/admin/news']"));
        public IWebElement AddArticleBtn => Driver.FindElement(By.XPath("//button[@class='btn btn-primary ng-star-inserted']"));
        public IWebElement AddArticleFile => Driver.FindElement(By.XPath("//upload-media//input[@type='file' ]"));
        public string NewsTitle => "AT. News" + Actualdate;
        public IWebElement TxtTitle => Driver.FindElement(By.Id("editableTitle"));
        public IWebElement TxtDescription => Driver.FindElement(By.XPath("//div[@class='ui-editor-content ql-container ql-snow']//descendant::div[@contenteditable='true' and @data-gramm]"));

        public By TopicDropdown => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-news-edit/div/div/content-loader/div/edit-article/content-loader/div/form/div[4]/div/synapze-cx-form-control/synapze-cx-simple-dropdown/form/p-dropdown/div/div[3]");
        public By TopicOption => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-news-edit/div/div/content-loader/div/edit-article/content-loader/div/form/div[4]/div/synapze-cx-form-control/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[3]/li");
        public By TopicOption2 => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-news-edit/div/div/content-loader/div/edit-article/content-loader/div/form/div[4]/div/synapze-cx-form-control/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[3]/li/span");
        public By LocationDropdown => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-news-edit/div/div/content-loader/div/edit-article/content-loader/div/form/div[8]/div/div/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[1]/synapze-cx-simple-dropdown/form/p-dropdown/div/div[3]");
        public By LocationDropdownOp1 => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-news-edit/div/div/content-loader/div/edit-article/content-loader/div/form/div[8]/div/div/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[1]/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[1]/li");
        public By SelectDropdownLocation => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-news-edit/div/div/content-loader/div/edit-article/content-loader/div/form/div[8]/div/div/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[2]/synapze-cx-simple-dropdown/form/p-dropdown/div/div[3]");
        public By SelectLocationOp1 => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-news-edit/div/div/content-loader/div/edit-article/content-loader/div/form/div[8]/div/div/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[2]/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[1]/li");
        public By SelectLocationOp2 => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-news-edit/div/div/content-loader/div/edit-article/content-loader/div/form/div[8]/div/div/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[2]/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[2]/li");
        public IWebElement AddLocationBtn => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-news-edit/div/div/content-loader/div/edit-article/content-loader/div/form/div[8]/div/div/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[3]/button"));
        public IWebElement TxtTag => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-news-edit/div/div/content-loader/div/edit-article/content-loader/div/form/div[9]/div/synapze-cx-form-control/custom-tags/form/div/div/div/input"));
        public IWebElement AddTagBtn => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-news-edit/div/div/content-loader/div/edit-article/content-loader/div/form/div[9]/div/synapze-cx-form-control/custom-tags/form/div/div/div/div/button"));
        public IWebElement CoverImageFile => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-news-edit/div/div/content-loader/div/edit-article/content-loader/div/form/div[12]/div/div/div/div/upload-image-withpreview/div/label/input"));
        public IWebElement TxtDuration => Driver.FindElement(By.Id("duration"));
        public By DurationTypeDropdown => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-news-edit/div/div/content-loader/div/edit-article/content-loader/div/form/div[13]/div/div/div/div[2]/synapze-cx-form-control/synapze-cx-simple-dropdown/form/p-dropdown/div/div[3]");
        public By DurationTypeOption2 => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-news-edit/div/div/content-loader/div/edit-article/content-loader/div/form/div[13]/div/div/div/div[2]/synapze-cx-form-control/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[3]/li");
        public IWebElement SaveBtn => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-news-edit/div/div/content-loader/div/div/div/div[2]/permission-block/button"));
        public IWebElement SaveBtnConfirm => Driver.FindElement(By.XPath("//span[text()='Yes']"));
        public IWebElement PublishBtn => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-news-edit/div/div/content-loader/div/div/div/div[4]/permission-block[1]/button"));
        public IWebElement FirstElementTable => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/synapze-cx-news/div[2]/div/div/synapze-block-ui/div/synapze-cx-grid/div/table/tbody/tr[1]/td[1]/a"));
    }                             
}
