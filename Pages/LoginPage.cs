using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Pages
{
    public class LoginPage : DriverHelper
    {

        public IWebElement containerLogin => Driver.FindElement(By.ClassName("login-container"));
        public IWebElement txtUserName => Driver.FindElement(By.Name("Username"));
        public IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        public IWebElement swRememberMe => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[2]/form/div/div[4]/div/label/span[1]"));
        public IWebElement btnLogin => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[2]/form/div/div[5]/button"));

        public IWebElement dashboardLH => Driver.FindElement(By.XPath("/html/body/app-root/app-home/app-synapze-app-menu/div/div[2]/nav/div/synapze-app-navbar-brand/a/div/span"));

        public IWebElement WelcomeToAdminPage => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-admin-home/div"));

        //-------------------------------Categories-----------------------------------------------
        public IWebElement AdministrativeProcesses => Driver.FindElement(By.XPath("/html/body/app-root/app-preferences/form/content-loader/div/div/div/div[1]/app-category-control/div/button"));
        public IWebElement Algebra => Driver.FindElement(By.XPath("/html/body/app-root/app-preferences/form/content-loader/div/div/div/div[2]/app-category-control/div/button"));
        public IWebElement Books => Driver.FindElement(By.XPath("/html/body/app-root/app-preferences/form/content-loader/div/div/div/div[3]/app-category-control/div/button"));
        public IWebElement Geometria => Driver.FindElement(By.XPath("/html/body/app-root/app-preferences/form/content-loader/div/div/div/div[4]/app-category-control/div/button"));
        public IWebElement Microsoft => Driver.FindElement(By.XPath("/html/body/app-root/app-preferences/form/content-loader/div/div/div/div[5]/app-category-control/div/button"));
        public IWebElement Music => Driver.FindElement(By.XPath("/html/body/app-root/app-preferences/form/content-loader/div/div/div/div[6]/app-category-control/div/button"));
        public IWebElement ContinueBtn => Driver.FindElement(By.XPath("/html/body/app-root/app-preferences/form/div[2]/button"));
        public IWebElement GotIt => Driver.FindElement(By.XPath("/html/body/p-dynamicdialog/div/div/div[2]/app-confirmation-modal/div/button"));
        //-----------------------------------------------------------------------------------------------------
        public bool ElementExist(IWebElement e) => e.Displayed;
        public void EnterUserNameAndPassword(string Email, string Password)
        {
            txtUserName.SendKeys(Email);
            txtPassword.SendKeys(Password);
        }





    }
}
