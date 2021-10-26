using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;


namespace TestProject1.Pages
{
    class LoginFailed : DriverHelper
    {
        //IWebDriver driver;
        String GetEmail;
        //String Element;
        public IWebElement containerLogin => Driver.FindElement(By.ClassName("login-container"));
        public IWebElement txtUserName => Driver.FindElement(By.Name("Username"));
        public IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        public IWebElement btnLogin => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[2]/form/div/div[5]/button"));
        public IWebElement LinkForgotPassword => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[2]/form/div/div[8]/a"));
        public IWebElement InvalidErrorMessage => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[2]/form/div/div[2]"));
        public IWebElement PageForgotPassword => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div"));
        public IWebElement txtEmail => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/form/div/div/div/input"));
        public IWebElement BtnSendEmail => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/form/div/button"));
        public IWebElement GetEmailText => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/form/div[2]/div"));
        public IWebElement txtSecurityQuestion => Driver.FindElement(By.Id("Answer"));
        public IWebElement ContainerReviewEmail => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div"));
        public IWebElement ContainerResetPassword => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div"));
        public IWebElement NextButton => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/form/div/button"));
        public IWebElement ClickResetPassword => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/form/div/button"));
        
        public IWebElement ClickQAButton = Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/a")); 

        public bool ElementExist(IWebElement e) => e.Displayed;
        public void EnterUserNameAndPassword(string Email, string Password)
        {
            txtUserName.SendKeys(Email);
            txtPassword.SendKeys(Password);
        }
        public void EmailText()
        {
            var element = GetEmailText.Text;
            GetEmail = element;        
        }
        public void GoToPage()
        {
            Driver.Url = GetEmail; //Hereda de DriverHelper
        }

    }
}
