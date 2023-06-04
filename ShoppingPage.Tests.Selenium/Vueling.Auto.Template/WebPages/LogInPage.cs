using Albert.Auto.Template.SetUp;
using Albert.Auto.Template.WebPages.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Security.Cryptography;
using System.Threading;

namespace Albert.Auto.Template.Webpages
{
    public class LogInPage : CommonPage
    {
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();

        //Constructor
        public LogInPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {

        }

        //Define WebElements by: Id, CssSelector or XPath
       
        private IWebElement inputEmail
        {
            get { return WebDriver.FindElementById("input-email"); }
        }
       
        private IWebElement inputPassword
        {
            get { return WebDriver.FindElementById("input-password"); }
        }
       
        private IWebElement btnLogin
        {
            get { return WebDriver.FindElementByCssSelector("input.btn"); }
        }
        private IWebElement textContent
        {
            get { return WebDriver.FindElementByXPath("//*[@id=\"content\"]/h2[1]"); }
        }
        private IWebElement btnHome
        {
            get { return WebDriver.FindElementByXPath("//div[@id='logo']/h1/a"); }
        }

        //Define functions and actions

        public LogInPage completeLogIn(string email, string password)
        {
            inputEmail.SendKeys(email);
            inputPassword.SendKeys(password);

            btnLogin.Click();

            Assert.AreEqual("My Account", textContent.Text);

            btnHome.Click();
            return this;
        }
    }
}
