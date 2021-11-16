using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Pages.Register
{
    public class Register1Info : DriverHelper
    {
		public IWebElement LoginContainer => Driver.FindElement(By.ClassName("login-container"));
		public IWebElement BtnRegister => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[2]/form/div/div[6]/a"));
		

		IWebElement txtName => Driver.FindElement(By.Id("FirstName"));
		IWebElement txtLastName => Driver.FindElement(By.Id("LastName"));
		IWebElement txtEmail => Driver.FindElement(By.Id("UserName"));
		public bool PersonalInformationExist() => txtName.Displayed && txtLastName.Displayed && txtEmail.Displayed;

		public void EnterNameLastNameAndEmail(string Name, string LastName, string Email)
		{
			txtName.SendKeys(Name);
			txtLastName.SendKeys(LastName);
			txtEmail.SendKeys(Email);
		}
		//Speciality
		public IWebElement DropdownSpeciality => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div/form/div[2]/div[2]/div[1]/div/div/div/div/div[1]"));
		
	

		//public IWebElement DropdownSpecialityOptions => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div/form/div[2]/div[2]/div[1]/div/div/div/div/div[2]"));
		
		public IWebElement SelectSpeciality => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div/form/div[2]/div[2]/div[1]/div/div/div/div/div[2]/div/div[1]"));
		public IWebElement SelectSpeciality1 => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div/form/div[2]/div[2]/div[1]/div/div/div/div/div[2]/div/div[2]"));
		//-
		//Role
		public IWebElement DropdownRole => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div/form/div[2]/div[2]/div[2]/div/div/div/div/div[1]"));

		public IWebElement DropdownRoleOptions => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div/form/div[2]/div[2]/div[2]/div/div/div/div/div[2]"));
		
		public IWebElement SelectRole => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div/form/div[2]/div[2]/div[2]/div/div/div/div/div[2]/div/div"));
		public IWebElement SelectRole1 => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div/form/div[2]/div[2]/div[2]/div/div/div/div/div[2]/div/div[1]"));
		public IWebElement SelectRole2 => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div/form/div[2]/div[2]/div[2]/div/div/div/div/div[2]/div/div[2]"));
		
		
		//Next B
		public IWebElement NextButton => Driver.FindElement(By.Id("nextBtn1"));
		

	}
}
