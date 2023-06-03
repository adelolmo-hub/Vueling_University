using Albert.Auto.Template.SetUp;
using Albert.Auto.Template.WebPages.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Security.Cryptography;
using System.Threading;

namespace Albert.Auto.Template.Webpages
{
    public class RegisterPage : CommonPage
    {
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();

        //Constructor
        public RegisterPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {

        }

        //Define WebElements by: Id, CssSelector or XPath
        private IWebElement btnDetails
        {
            get { return WebDriver.FindElementById("details-button"); }
        }

        private IWebElement btnProceed
        {
            get { return WebDriver.FindElementById("proceed-link"); }
        }

        private IWebElement inputFirstName
        {
            get { return WebDriver.FindElementById("input-firstname"); }
        }
        private IWebElement inputLastName
        {
            get { return WebDriver.FindElementById("input-lastname"); }
        }
        private IWebElement inputEmail
        {
            get { return WebDriver.FindElementById("input-email"); }
        }
        private IWebElement inputTelephone
        {
            get { return WebDriver.FindElementById("input-telephone"); }
        }
        private IWebElement inputPassword
        {
            get { return WebDriver.FindElementById("input-password"); }
        }
        private IWebElement inputConfirmPassword
        {
            get { return WebDriver.FindElementById("input-confirm"); }
        }

        private IWebElement checkAgreeTerm
        {
            get { return WebDriver.FindElementByXPath("//input[@type='checkbox']"); }
        }
        private IWebElement btnContinue
        {
            get { return WebDriver.FindElementByCssSelector("input.btn.btn-primary"); }
        }

        private IWebElement textContent
        {
            get { return WebDriver.FindElementById("content"); }
        }

        //Define functions and actions

        public RegisterPage completeRegisterForm(string name, string lastname, string email, string telephone, string password)
        { 
            inputFirstName.SendKeys(name);
            inputLastName.SendKeys(lastname);
            inputEmail.SendKeys(email);
            inputTelephone.SendKeys(telephone);
            inputPassword.SendKeys(password);
            inputConfirmPassword.SendKeys(password);

            Assert.IsTrue(textContent.Displayed, "Text notifying your account has been created exists");
            return this;
        }
    }
}
