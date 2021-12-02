using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;

namespace TestProject1.Pages
{
    class CreateModulesPage : DriverHelper
    {
        //Begin
        public IWebElement LearnComponent => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[2]/div[2]/div/div/ul/li[5]/a"));
        public IWebElement ModulesSubcomponent => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[2]/div[2]/div/div/ul/li[5]/ul/li[3]/a"));
        public IWebElement ModulesCard => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-modules/content-loader/div/div[2]/div"));
        //New Module
        public IWebElement CreateModuleBtn => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-modules/content-loader/div/div[1]/permission-block/button"));
        public IWebElement TxtTitle => Driver.FindElement(By.Id("editableTitle"));
        public string ModuleTitle => "AT. Mod.";
        public IWebElement TxtDescription => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[4]/div/synapze-cx-form-control/app-wysiwyg/div/ckeditor/div[2]/div[2]/div"));
        //public IWebElement DateEffectiveOnModule => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[5]/div[1]/synapze-cx-form-control/synapze-cx-calendar/form/p-calendar/span/input"));
        public By DurationMonthsDropdown => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[5]/div[2]/div/div[1]/synapze-cx-form-control/synapze-cx-simple-dropdown/form/p-dropdown/div/div[3]");
        public By DurationMonthsOp1 => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[5]/div[2]/div/div[1]/synapze-cx-form-control/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[1]/li");
        public By DurationDaysDropdown => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[5]/div[2]/div/div[2]/synapze-cx-form-control/synapze-cx-simple-dropdown/form/p-dropdown/div/div[3]");
        public By DurationDaysOp1 => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[5]/div[2]/div/div[2]/synapze-cx-form-control/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[1]/li");
        public By CategoryDropdown => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[6]/div/div[1]/synapze-cx-form-control/tenant-category-selector/div/form/div/div/div/div[1]/tenant-category-selector-dropdown/synapze-cx-simple-dropdown/form/p-dropdown/div/div[3]");
        public By CategoryOption1 => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[6]/div/div[1]/synapze-cx-form-control/tenant-category-selector/div/form/div/div/div/div[1]/tenant-category-selector-dropdown/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[1]/li");
        public By SubCategoryDropdown => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[6]/div/div[1]/synapze-cx-form-control/tenant-category-selector/div/form/div/div/div/div[2]/tenant-category-selector-dropdown/synapze-cx-simple-dropdown/form/ng-select/div/span");
        public By SubCategoryOption1 => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[6]/div/div[1]/synapze-cx-form-control/tenant-category-selector/div/form/div/div/div/div[2]/tenant-category-selector-dropdown/synapze-cx-simple-dropdown/form/ng-select/ng-dropdown-panel/div/div[2]/div/div");
        public IWebElement AddCategoriesBtn => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[6]/div/div[1]/synapze-cx-form-control/tenant-category-selector/div/form/div/div/div/div[3]/button"));
        public By RoleDropdown =>By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[7]/div/synapze-cx-form-control/jobrole-tenantrole-selector/form/div/div/div[1]/div/div/ng-select");
        public IWebElement RoleOption => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[7]/div/synapze-cx-form-control/jobrole-tenantrole-selector/form/div/div/div[1]/div/div/ng-select/ng-dropdown-panel/div/div[2]/div[62]/div"));
        public IWebElement RoleOption1 => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[7]/div/synapze-cx-form-control/jobrole-tenantrole-selector/form/div/div/div[1]/div/div/ng-select/div/span[2]"));
        public By SearchLocationDropdown => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[9]/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[1]/synapze-cx-simple-dropdown/form/p-dropdown/div/div[3]");
        public By SearchLocationOption1 => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[9]/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[1]/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[1]/li");

        public By SelectLocationDropdown => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[9]/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[2]/synapze-cx-simple-dropdown/form/p-dropdown/div/div[3]");
        public By SelectLocationOption1 => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[9]/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[2]/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[1]/li");
        public By SelectLocationOption2 => By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[9]/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[2]/synapze-cx-simple-dropdown/form/p-dropdown/div/div[4]/div/ul/p-dropdownitem[2]/li");
        public IWebElement AddLocationsButton => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[9]/synapze-cx-form-control/tenant-location-selector/content-loader/div/form/div[1]/div/div[3]/button"));
        public IWebElement TxtTag => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[10]/div/synapze-cx-form-control/custom-tags/form/div/div/div/input"));
        public IWebElement AddTagBtn => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[10]/div/synapze-cx-form-control/custom-tags/form/div/div/div/div/button"));
        public IWebElement ImageInput => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[11]/div/div[1]/upload-image-withpreview/div/label/input"));
        //Test out
        public IWebElement CheckTestOut => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[12]/div[1]/div[2]/div"));
        public IWebElement AddTestOut => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[14]/div/button"));
        public IWebElement SelectTestOutOption1 => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/app-select-testout/actions-search-grid/content-loader/div/div[2]/p-tabview/div/div/p-tabpanel/div/synapze-cx-grid/div/div/div[1]/label/div/span/action-display-grid/learning-path-admin-resource-action-display-widget/div"));
        public IWebElement ConfirmTestOut => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/app-select-testout/div/div[2]/button[2]"));
        //Section
        public IWebElement SectionInputText => Driver.FindElement(By.Id("Section"));
        public IWebElement AddSectionBtn => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/edit-module/content-loader/div/div/form/div[16]/div/form/div/div/div/div/button"));
        public IWebElement AddActionBtn => Driver.FindElement(By.CssSelector("body > app-root > app-admin-layout > div > section.mdk-drawer-layout__content.page > div > app-edit-module-view > content-loader > div > div > div > edit-module > content-loader > div > div > form > div:nth-child(19) > div > div > div.card-body.ng-star-inserted > div > draggable-list > div.add-button-area.mb-3 > button"));
        public IWebElement AddActionModal => Driver.FindElement(By.XPath("/html/body/modal-container/div/div"));
        public IWebElement SelectAssessment => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/app-select-actions/actions-search-grid/content-loader/div/div[2]/p-tabview/div/div/p-tabpanel[1]/div/synapze-cx-grid/div/div/div[1]/label/div/span/action-display-grid/learning-path-admin-resource-action-display-widget/div/div[1]"));
        public IWebElement SelectResourcesTab => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/app-select-actions/actions-search-grid/content-loader/div/div[2]/p-tabview/div/ul/li[2]"));
        public IWebElement SelectResourceOp1 => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/app-select-actions/actions-search-grid/content-loader/div/div[2]/p-tabview/div/div/p-tabpanel[2]/div/synapze-cx-grid/div/div/div[1]/label/div/span/action-display-grid/learning-path-admin-resource-action-display-widget/div/div[1]"));
        public IWebElement AddActionModalBtn => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/app-select-actions/div/div[2]/button[2]"));
        //Save & publish
        public IWebElement SaveBtn => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/div[4]/div[2]/permission-block/button"));
        public IWebElement SaveBtnConfirm => Driver.FindElement(By.XPath("//span[text()='Yes']"));
        public ReadOnlyCollection<IWebElement> BtnJavascript => Driver.FindElements(By.ClassName("[type='checkbox']"));
        public IWebElement PublishBtn => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-edit-module-view/content-loader/div/div/div/div[4]/div[4]/permission-block[1]/button"));
        public IWebElement FirstElementTable => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-modules/content-loader/div/div[2]/div/div/synapze-cx-grid/div/table/tbody/tr[1]/td[1]/div/a"));
        
    }
}
