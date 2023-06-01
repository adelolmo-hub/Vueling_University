using Vueling.Auto.Template.SetUp;
using Vueling.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using System.Threading;
using Vueling.Auto.Template.Webpages;
using OpenQA.Selenium.Support.UI;
using System;
using Vueling.Auto.Template.Common;

namespace ProductStore.WebPages
{
    public class LogInPage : CommonPage
    {
        public LogInPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        { 
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();

        private IWebElement inputUsername
        {
            get { return WebDriver.FindElementById("loginusername"); }
        }
        private IWebElement inputPassword
        {
            get { return WebDriver.FindElementById("loginpassword"); }
        }

        private IWebElement btnLogin
        {
            get { return WebDriver.FindElementByXPath("//*[@id=\"logInModal\"]/div/div/div[3]/button[2]"); }
        }
        private IWebElement btnClose
        {
            get { return WebDriver.FindElementByCssSelector("button.btn.btn-secondary"); }
        }


        public LogInPage addInfoLogIn(String name, String password)
        {
            inputUsername.SendKeys(name);
            inputPassword.SendKeys(password);
            btnLogin.Click();
            return this;
        }
       
    }

}
