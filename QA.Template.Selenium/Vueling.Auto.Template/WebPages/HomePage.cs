using Vueling.Auto.Template.SetUp;
using Vueling.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using System.Threading;
using Vueling.Auto.Template.Webpages;
using OpenQA.Selenium.Support.UI;
using System;
using Vueling.Auto.Template.Common;
using NUnit.Framework;
using System.Xml.Linq;

namespace ProductStore.WebPages
{
    public class HomePage : CommonPage
    {
        public HomePage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        { 
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();

        private IWebElement btnHome
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Home ']"); }
        }
        private IWebElement btnContact
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Contact']"); }
        }
        private IWebElement btnAboutUs
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'About Us']"); }
        }

        private IWebElement btnCart
        {
            get { return WebDriver.FindElementById("cartur"); }
        }
        private IWebElement btnLogIn
        {
            get { return WebDriver.FindElementById("login2"); }
        }
        private IWebElement btnSignUp
        {
            get { return WebDriver.FindElementById("signin2"); }
        }

        private By btnLogOut
        {
            get { return By.Id("logout2"); }
        }

        private IWebElement btn_LogOut
        {
            get { return WebDriver.FindElement(btnLogOut); }
        }

        private IWebElement btnLaptop
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Laptops']"); }
        }
        private IWebElement btnPhone
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Phones']"); }
        }
        private IWebElement btnMonitor
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Monitors']"); }
        }

        private IWebElement btnWelcome
        {
            get { return WebDriver.FindElementById("nameofuser"); }
        }

        private IWebElement findProduct(String productName)
        {
            return WebDriver.FindElementByXPath("//a[text()='" + productName + "']");
        }

        public HomePage logIn()
        {
            btnLogIn.Click();   
            return this;
        }

        public void searchLaptops(String laptopName, String username)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout))
                .Until(CustomExpectedConditions.ElementIsVisible(btnLogOut));
            Assert.AreEqual(btnWelcome.Text, "Welcome " + username, "El nombre de usuario no coincide");
            btnLaptop.Click();
            findProduct(laptopName).Click(); 
        }
        public void searchPhones(String phoneName, String username)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout))
                .Until(CustomExpectedConditions.ElementIsVisible(btnLogOut));
            Assert.AreEqual(btnWelcome.Text, "Welcome " + username, "El nombre de usuario no coincide");
            btnPhone.Click();
            findProduct(phoneName).Click();
        }

        public void searchMonitor(String monitorName, String username)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout))
                .Until(CustomExpectedConditions.ElementIsVisible(btnLogOut));
            Assert.AreEqual(btnWelcome.Text, "Welcome " + username, "El nombre de usuario no coincide");
            btnMonitor.Click();
            findProduct(monitorName).Click();
        }

    }

}
