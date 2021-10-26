using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Pages
{
    public class LoginPage : DriverHelper
    {
        public IWebElement txtUserName => Driver.FindElement(By.Name("Username"));
        public IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        public IWebElement swRememberMe => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[2]/form/div/div[4]/div/label/span[1]"));
        public IWebElement btnLogin => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[2]/form/div/div[5]/button"));
        public IWebElement dashboardLH => Driver.FindElement(By.XPath("/html/body/app-root/app-home/app-synapze-app-menu/div/div[2]/nav/div/synapze-app-navbar-brand/a/div/span"));
        public IWebElement containerLogin => Driver.FindElement(By.ClassName("login-container"));
        public bool ElementExist(IWebElement e) => e.Displayed;
        public void EnterUserNameAndPassword(string Email, string Password)
        {
            txtUserName.SendKeys(Email);
            txtPassword.SendKeys(Password);
        }

    }
}
