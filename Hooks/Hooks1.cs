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
            option.AddArguments("start-maximized");
            //option.AddArguments("--disable-gpu");
            //option.AddArguments("--headless");

            Console.WriteLine("setup");
            //new DriverManager().SetUpDriver(new ChromeConfig());
            //Driver = new ChromeDriver(option);
            //TODO: implement logic that has to run before executing each scenario//TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();//TODO: implement logic that has to run after executing each scenario
        }
    }
}
