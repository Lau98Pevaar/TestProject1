using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Pages.Register
{
    public class Register3Security:DriverHelper
    {
        IWebElement Password => Driver.FindElement(By.Id("Password"));
        IWebElement PasswordConfirm => Driver.FindElement(By.Id("Password_confirm"));
        IWebElement Answer1 => Driver.FindElement(By.Id("SecurityAnswers_0__Answer"));
        IWebElement Answer2 => Driver.FindElement(By.Id("SecurityAnswers_1__Answer"));
        IWebElement Answer3 => Driver.FindElement(By.Id("SecurityAnswers_2__Answer"));
        public bool SecurityBoxesExist() => Password.Displayed && PasswordConfirm.Displayed && Answer1.Displayed && Answer2.Displayed && Answer3.Displayed;
        public void EnterSecurityBoxes(string Psw, string Ans1, string Ans2, string Ans3)
        {
            Password.SendKeys(Psw);
            PasswordConfirm.SendKeys(Psw);
            Answer1.SendKeys(Ans1);
            Answer2.SendKeys(Ans2);
            Answer3.SendKeys(Ans3);
        }
        //Next B
        public IWebElement NextButton => Driver.FindElement(By.Id("nextBtn3"));
        
    }
}
