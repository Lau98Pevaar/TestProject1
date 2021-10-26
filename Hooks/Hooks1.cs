﻿using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TestProject1.Hooks
{
    [Binding]
    public sealed class Hooks1 : DriverHelper
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions option = new ChromeOptions();

            option.AddArgument("no-sandbox");
            option.AddArguments("start-maximized");
            option.AddArguments("--incognito");
            //option.AddArguments("--disable-gpu");
            //option.AddArguments("--headless");

            Console.WriteLine("setup");
           
            Driver = new ChromeDriver(option);
            Driver.Navigate().GoToUrl("https://lhqa.pevaar.com:446/");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();//TODO: implement logic that has to run after executing each scenario
        }
    }
}
