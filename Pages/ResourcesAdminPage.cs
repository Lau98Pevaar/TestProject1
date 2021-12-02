﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.ObjectModel;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProject1.Pages;

namespace TestProject1.Pages
{
    class ResourcesAdminPage : DriverHelper
    {
        public IWebElement ResourcesComponent => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[2]/div[2]/div/div/ul/li[2]/a"));
        public IWebElement Resources => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[2]/div[2]/div/div/ul/li[2]/ul/li[1]/a"));
        public IWebElement NewResource => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-resources/content-loader/div/div[1]/permission-block/button"));

        // New Resource

        public IWebElement rTitle => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-resource-view/content-loader/div/div/div/edit-resource/content-loader/div/form/div[1]/div[1]/div[1]/div[2]/synapze-cx-form-control/div/span[1]"));
        public IWebElement rEffectiveDate => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-resource-view/content-loader/div/div/div/edit-resource/content-loader/div/form/div[1]/div[1]/div[2]/div[1]/synapze-cx-form-control/synapze-cx-calendar/form/p-calendar/span/button"));
        public IWebElement rSelectEffectiveDate => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-resource-view/content-loader/div/div/div/edit-resource/content-loader/div/form/div[1]/div[1]/div[2]/div[1]/synapze-cx-form-control/synapze-cx-calendar/form/p-calendar/span/div/div[2]/button[1]"));
        public IWebElement dropCompetency => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-resource-view/content-loader/div/div/div/edit-resource/content-loader/div/form/div[1]/div[2]/div/div/div[1]/synapze-cx-form-control/competency-selector/form/div/synapze-cx-simple-dropdown/form/p-dropdown/div/div[3]"));
        public By opcCompetency => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-resource-view/content-loader/div/div/div/edit-resource/content-loader/div/form/div[1]/div[2]/div/div/div[1]/synapze-cx-form-control/competency-selector/form/div/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[1]/li");
        public IWebElement dropSkill => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-resource-view/content-loader/div/div/div/edit-resource/content-loader/div/form/div[1]/div[2]/div/div/div[2]/synapze-cx-form-control/skill-selector/form/div/synapze-cx-simple-dropdown/form/ng-select/div"));
        public By opcSkill => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-resource-view/content-loader/div/div/div/edit-resource/content-loader/div/form/div[1]/div[2]/div/div/div[2]/synapze-cx-form-control/skill-selector/form/div/synapze-cx-simple-dropdown/form/ng-select/ng-dropdown-panel/div/div[2]/div[1]/div");
        public IWebElement btnAddSkill => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-resource-view/content-loader/div/div/div/edit-resource/content-loader/div/form/div[1]/div[2]/div/div/div[3]/button"));
        public IWebElement dropCategory => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-resource-view/content-loader/div/div/div/edit-resource/content-loader/div/form/div[1]/div[3]/div/synapze-cx-form-control/tenant-category-selector/div/form/div/div/div/div[1]/tenant-category-selector-dropdown/synapze-cx-simple-dropdown/form/p-dropdown/div/div[3]"));
        public By opcCategory => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-resource-view/content-loader/div/div/div/edit-resource/content-loader/div/form/div[1]/div[3]/div/synapze-cx-form-control/tenant-category-selector/div/form/div/div/div/div[1]/tenant-category-selector-dropdown/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[1]/li");
        public IWebElement dropSubCategory => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-resource-view/content-loader/div/div/div/edit-resource/content-loader/div/form/div[1]/div[3]/div/synapze-cx-form-control/tenant-category-selector/div/form/div/div/div/div[2]/tenant-category-selector-dropdown/synapze-cx-simple-dropdown/form/ng-select/div"));
        public By opcSubCategory => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-resource-view/content-loader/div/div/div/edit-resource/content-loader/div/form/div[1]/div[3]/div/synapze-cx-form-control/tenant-category-selector/div/form/div/div/div/div[2]/tenant-category-selector-dropdown/synapze-cx-simple-dropdown/form/ng-select/ng-dropdown-panel/div/div[2]/div/div");
        public IWebElement btnAddCategory => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-resource-view/content-loader/div/div/div/edit-resource/content-loader/div/form/div[1]/div[3]/div/synapze-cx-form-control/tenant-category-selector/div/form/div/div/div/div[3]/button"));
        public IWebElement btnAddMore => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-resource-view/content-loader/div/div/div/edit-resource/content-loader/div/form/div[3]/permission-block/button"));
        // Complete Information 
        public IWebElement btnAddAttachment => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[1]/div/synapze-cx-form-control/div/upload-media/div/label/input"));
        public IWebElement addImage => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[3]/div[1]/div[1]/upload-image-withpreview/div/label/input"));
        public IWebElement dropLanguage => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[2]/div/div/div[1]/synapze-cx-form-control/tenant-locale-selector/form/synapze-cx-simple-dropdown/form/p-dropdown/div/div[3]"));
        public By opcLanguage => By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[2]/div/div/div[1]/synapze-cx-form-control/tenant-locale-selector/form/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[2]/li");
        public IWebElement dropDurationtype => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[2]/div/div/div[2]/div/div[2]/synapze-cx-form-control/synapze-cx-simple-dropdown/form/p-dropdown/div/div[3]"));
        public By opcDurationtype => By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[2]/div/div/div[2]/div/div[2]/synapze-cx-form-control/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[3]/li");
        public IWebElement rDuration => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[2]/div/div/div[2]/div/div[1]/synapze-cx-form-control/input"));
        public IWebElement rDescriptionImage => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[3]/div[2]/div/synapze-cx-form-control/input"));
        public IWebElement rTitleForm => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[4]/div/div/synapze-cx-form-control[1]/input"));
        public IWebElement rDescriptionForm => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[4]/div/div/synapze-cx-form-control[2]/textarea"));
        public IWebElement AddTag => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[4]/div/div/custom-tags/form/div/div/div/input"));
        public IWebElement btnAddTag => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[4]/div/div/custom-tags/form/div/div/div/div/button"));
        // public IWebElement rDuration => Driver.FindElement(By.XPath(""));
        public IWebElement rDropSelectLocation => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[5]/div/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[1]/synapze-cx-simple-dropdown/form/p-dropdown/div/div[3]"));
        public By rOpcLocation => By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[5]/div/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[1]/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[1]/li");
        public By rOpcRegion=> By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[5]/div/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[1]/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[3]/li");
        public IWebElement rDropSearchLocation => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[5]/div/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[2]/synapze-cx-simple-dropdown/form/p-dropdown/div/div[3]"));
        public By rOpcAtlantic => By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[5]/div/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[2]/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[1]/li");
        public By rOpcFordCanada => By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[5]/div/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[2]/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[2]/li");
        public By rOpcWestern => By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[5]/div/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[2]/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[1]/li");
        public By rOpcPacific => By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[5]/div/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[2]/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[2]/li");
        public IWebElement rAddLocations => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[5]/div/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[3]/button"));
        public IWebElement rGoodtoGo => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[3]/div/div/div[3]/permission-block/button"));
        public IWebElement rSave => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-resource-view/content-loader/div/div/div/edit-resource/content-loader/div/div/div[3]/permission-block/button"));
        public IWebElement rConfirmSave => Driver.FindElement(By.XPath("/html/body/div[3]/div/div[3]/button[1]"));
        public IWebElement rClose => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[3]/div/button"));
        public IWebElement rPublish => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-resource-view/content-loader/div/div/div/edit-resource/content-loader/div/div/div[4]/permission-block[1]/button"));
        
        // Search Resource
        public IWebElement SearchResource => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-resources/content-loader/div/div[2]/div/div/resources-search/form[1]/div/div[2]/input"));
        public IWebElement btnSearchResource => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-resources/content-loader/div/div[2]/div/div/resources-search/form[1]/div/div[2]/button[1]"));
        public IWebElement CheckResource => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-resources/content-loader/div/div[2]/div/div/synapze-cx-grid/div/table/tbody/tr/td[1]/div/permission-block/a"));
        public IWebElement btnLink => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[1]/div/synapze-cx-form-control/div/permission-block/button"));
        public IWebElement btnAddLink => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/div/add-edit-asset/form/div[1]/div/synapze-cx-form-control/input"));
        public ReadOnlyCollection<IWebElement> JsCheckbox => Driver.FindElements(By.CssSelector("[type='checkbox']"));
        public void SelectDropdown(IWebElement Dropdown, By Option)
        {
            Dropdown.Click();
            IWebElement OptionLocation = Driver.FindElement(Option);
            OptionLocation.Click();
        }
        public void CheckboxFunction(int a)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();",JsCheckbox[a]);
        }

    }
}
