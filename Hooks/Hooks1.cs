using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace TestProject1.Hooks
{
    [Binding]
    public sealed class Hooks1 : DriverHelper
    {
        public String saveFile;
        public String Loader;
        //private ITakesScreenshot webDriver;

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("start-maximized");
            option.AddArguments("--disable-notifications");
            option.AddArgument("no-sandbox");
            option.AddArguments("--lang=en");
            //option.AddArgument("--disable-setuid-sandbox");
            option.AddArgument("--incognito");
            //option.AddArguments("--disable-gpu");
            //option.AddArguments("--headless");

            Console.WriteLine("setup");
            //new DriverManager().SetUpDriver(new ChromeConfig());
            //Driver = new ChromeDriver(option);
            //TODO: implement logic that has to run before executing each scenario//TODO: implement logic that has to run before executing each scenario
            Driver = new ChromeDriver(option);
            Driver.Navigate().GoToUrl("https://lhqa.pevaar.com:446/");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            Directory.CreateDirectory("../../../Files"); //Crear carpeta (si no existe)
            saveFile = "../../../Files/"; //Ubicación para guardar los archivos
            Loader = "//div[@class='message' and contains(text(),Loading)]";
        }

        [AfterScenario]
        public void AfterScenario()
        {

            Thread.Sleep(3000);
            Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();
            ss.SaveAsFile(saveFile +"Screen.png", ScreenshotImageFormat.Png);
            Thread.Sleep(5000);

            Driver.Quit();//TODO: implement logic that has to run after executing each scenario
        }
    }
}
