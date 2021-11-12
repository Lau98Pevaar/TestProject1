using OpenQA.Selenium;
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
        public IWebElement WelcomeToAdminPage => Driver.FindElement(By.XPath("/html/body/app-root/app-admin-layout/div/section[1]/div/app-admin-home/div"));

        // Dashboard Header
        public IWebElement dashboardLH => Driver.FindElement(By.XPath("/html/body/app-root/app-home/app-synapze-app-menu/div/div[2]/nav/div/synapze-app-navbar-brand/a/div/span"));
        public IWebElement navExplore => Driver.FindElement(By.XPath("/html/body/app-root/app-home/app-synapze-app-menu/div/div[2]/nav/div/app-navigation/div/ul/li[1]"));
        public IWebElement navLearn => Driver.FindElement(By.XPath("/html/body/app-root/app-home/app-synapze-app-menu/div/div[2]/nav/div/app-navigation/div/ul/li[2]"));
        public IWebElement navNews => Driver.FindElement(By.XPath("/html/body/app-root/app-home/app-synapze-app-menu/div/div[2]/nav/div/app-navigation/div/ul/li[3]"));
        public IWebElement navEvents => Driver.FindElement(By.XPath("/html/body/app-root/app-home/app-synapze-app-menu/div/div[2]/nav/div/app-navigation/div/ul/li[4]"));
        public IWebElement navTrivia => Driver.FindElement(By.XPath("/html/body/app-root/app-home/app-synapze-app-menu/div/div[2]/nav/div/app-navigation/div/ul/li[5]"));
        public IWebElement ImageHeader => Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/app-news-feed/div[1]"));
        // Dashboard Filters
        public IWebElement btnFilter => Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/app-news-feed/synapze-cx-article-search/div/div/form/div/div[1]/button"));
        public IWebElement filterFrom => Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/app-news-feed/synapze-cx-article-search/div/div/div/div/div/div/div/div/div[1]/synapze-cx-calendar/form/p-calendar/span/input"));
        public IWebElement filterTo => Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/app-news-feed/synapze-cx-article-search/div/div/div/div/div/div/div/div/div[2]/synapze-cx-calendar/form/p-calendar/span/input"));
        public IWebElement filterTopics => Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/app-news-feed/synapze-cx-article-search/div/div/div/div/div/div/div/div/div[3]/synapze-cx-simple-dropdown/form/ng-select/div/div"));
        public IWebElement filterBtnClear => Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/app-news-feed/synapze-cx-article-search/div/div/div/div/div/div/div/div/div[4]/div/div/button[1]"));
        public IWebElement filterBtnApply => Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/app-news-feed/synapze-cx-article-search/div/div/div/div/div/div/div/div/div[4]/div/div/button[2]"));
        public IWebElement searchBar => Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/app-news-feed/synapze-cx-article-search/div/div/form/div/div[2]/input"));
        public IWebElement btnSearch => Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/app-news-feed/synapze-cx-article-search/div/div/form/div/div[2]/button[1]"));
        public IWebElement btnClear => Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/app-news-feed/synapze-cx-article-search/div/div/form/div/div[2]/button[2]"));
        // Dashboard Body
        public IWebElement topic1 => Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/app-news-feed/div[2]/div[1]/synapze-cx-newsfeed-carousel/div/div[1]/div"));
        public IWebElement topic2 => Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/app-news-feed/div[2]/div[2]/synapze-cx-newsfeed-carousel/div/div[1]/div"));
        public IWebElement topic3=> Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/app-news-feed/div[2]/div[3]/synapze-cx-newsfeed-carousel/div/div[1]/div"));
        public IWebElement containerTopics => Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/app-news-feed/div[2]"));
        //Dashboard Footer
        public IWebElement progressCorePath => Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/progress-widget/div/div[1]/div"));
        public IWebElement resources => Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/favorite-and-trending-widget/div/div/div[1]/div[1]"));
        public IWebElement rFavorites => Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/favorite-and-trending-widget/div/div/div[1]/div[2]/div[1]"));
        public IWebElement rTrending => Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/favorite-and-trending-widget/div/div/div[1]/div[2]/div[2]"));
        public IWebElement containerResources => Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/favorite-and-trending-widget/div/div"));
        public IWebElement containerTimeResources => Driver.FindElement(By.XPath("/html/body/app-root/app-home/div/app-dashboard/favorite-and-trending-widget/div/div/div[2]/div"));
        public bool ElementExist(IWebElement e) => e.Displayed;
        public void EnterUserNameAndPassword(string Email, string Password)
        {
            txtUserName.SendKeys(Email);
            txtPassword.SendKeys(Password);
        }

        //public bool UserTypeisAdmin(string Usertype) =>Usertyp




    }
}
