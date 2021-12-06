using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Pages
{
    class CreateSubscriptionPage : DriverHelper
    {
        public IWebElement SubscriptionComponent => Driver.FindElement(By.XPath("//a[@aria-controls='collapseBasic' and contains(text(),'Subscription')]"));
        public IWebElement SubscriptionSubcomponent => Driver.FindElement(By.XPath("//a[@class='sidebar-menu-button ng-star-inserted' and @href='/admin/subscription/manager']"));
        public IWebElement NewSubscriptionBtn => Driver.FindElement(By.XPath("//button[contains(text(), '+ Subscription')]"));
        public IWebElement TxtTitle => Driver.FindElement(By.Id("editableTitle"));
        public string SubsTitle => "Suscription" + Actualdate;
        public IWebElement TxtName => Driver.FindElement(By.XPath("//input[@formcontrolname='Title']"));
        public IWebElement TxtDescription => Driver.FindElement(By.XPath("//div[@class='ui-editor-content ql-container ql-snow']//descendant::div[@contenteditable='true' and @data-gramm]"));
        
        public IWebElement EffectiveDateBtn => Driver.FindElement(By.XPath("//label[contains(text(),'Effective on')]//following-sibling::synapze-cx-form-control//button"));
        public IWebElement EffectiveDateTodayBtn => Driver.FindElement(By.XPath("//span[@class='ui-button-text ui-clickable' and (contains(text(),'Hoy') or contains(text(),'Today'))]"));
        public IWebElement FrecuencyInput => Driver.FindElement(By.XPath("//input[@formcontrolname='Frequency']"));
        public IWebElement TimeUnitFrecuencyDropdown => Driver.FindElement(By.XPath("//span[contains(text(),'Select unit')]"));
        public IWebElement TimeUnitOpYear => Driver.FindElement(By.XPath("//li[@class='ui-dropdown-item ui-corner-all' and @aria-label='Year' or @aria-label='Año']"));
        public IWebElement AmountInput => Driver.FindElement(By.XPath("//input[@formcontrolname='Amount']"));
        public IWebElement AddPathsBtn => Driver.FindElement(By.XPath("//button[@class='btn btn-primary' and contains(text(), ' + Add Paths ')]"));
        public IWebElement SelectOp1 => Driver.FindElement(By.XPath("//table[@class='table']//tr[1]//descendant::label"));
        public IWebElement ConfirmPath => Driver.FindElement(By.XPath("//button[contains(text(),'Add') and not(contains(text(),'s') )]"));
        public IWebElement AddModulesBtn => Driver.FindElement(By.XPath("//button[@class='btn btn-primary' and contains(text(), ' + Add Modules ')]"));
        
        public IWebElement AddResourcesBtn => Driver.FindElement(By.XPath("//button[@class='btn btn-primary' and contains(text(), ' + Add Resources ')]"));
        public IWebElement SelectOpRes => Driver.FindElement(By.XPath("/html/body/modal-container/div/div/div[2]/app-select-actions/actions-search-grid/content-loader/div/div[2]/p-tabview/div/div/p-tabpanel/div/synapze-cx-grid/div/div/div[1]/label/div/span/action-display-grid/learning-path-admin-resource-action-display-widget/div/div[1]"));
        public IWebElement SaveBtn => Driver.FindElement(By.XPath("//button[@class='btn btn-primary mb-3 md-md-0 btn-block ng-star-inserted']"));
        public IWebElement ConfirmModalBtn => Driver.FindElement(By.XPath("//span[text()='Yes' or text()='Si']"));
        public IWebElement PublishBtn => Driver.FindElement(By.XPath("//button[@class='btn btn-success mb-3 md-md-0 btn-block ng-star-inserted']"));
        public IWebElement FirstElementTable => Driver.FindElement(By.XPath("//table[@class='table']//tr[1]//td[1]//descendant::a"));

    }
}
