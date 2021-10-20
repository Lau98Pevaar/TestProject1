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
        IWebElement txtUserName => Driver.FindElement(By.Name("Username"));
        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        IWebElement swRememberMe => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[2]/form/div/div[4]/div/label/span[1]"));
        IWebElement btnLogin => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[2]/form/div/div[5]/button"));

        IWebElement dashboardLH => Driver.FindElement(By.XPath("/html/body/app-root/app-home/app-synapze-app-menu/div/div[2]/nav/div/synapze-app-navbar-brand/a/div/span"));
        IWebElement containerLogin => Driver.FindElement(By.ClassName("login-container"));
        public bool txtUserNameAndPasswordExist() => txtUserName.Displayed && txtPassword.Displayed;

        
        public void EnterUserNameAndPassword(string Email, string Password)
        {
            txtUserName.SendKeys(Email);
            txtPassword.SendKeys(Password);
        }
        public void ClickLogin()
        {
            btnLogin.Click();
        }
       
        public void SwitchRememberMe()
        {
            swRememberMe.Click();
        }
        public bool dashboardLHExist() => dashboardLH.Displayed;
        public bool containerLoginExist() => containerLogin.Displayed;


    }
}
