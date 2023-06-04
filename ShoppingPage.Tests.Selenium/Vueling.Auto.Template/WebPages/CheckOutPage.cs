using Albert.Auto.Template.Common;
using Albert.Auto.Template.SetUp;
using Albert.Auto.Template.WebPages.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Security.Cryptography;
using System.Threading;
using System.Xml.Linq;

namespace Albert.Auto.Template.Webpages
{
    public class CheckOutPage : CommonPage
    {
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();

        //Constructor
        public CheckOutPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {

        }

        //Define WebElements by: Id, CssSelector or XPath
        private IWebElement radioNew
        {
            get { return WebDriver.FindElementByXPath("//input[@type='radio' and @value='new']"); }
        }
        private IWebElement inputFirstName
        {
            get { return WebDriver.FindElementById("input-payment-firstname"); }
        }

        private IWebElement inputLastName
        {
            get { return WebDriver.FindElementById("input-payment-lastname"); }
        }
        private IWebElement inputCompany
        {
            get { return WebDriver.FindElementById("input-payment-company"); }
        }
        private IWebElement inputAddress1
        {
            get { return WebDriver.FindElementById("input-payment-address-1"); }
        }
        private IWebElement inputAddress2
        {
            get { return WebDriver.FindElementById("input-payment-address-2"); }
        }
        private IWebElement inputCity
        {
            get { return WebDriver.FindElementById("input-payment-city"); }
        }
        private IWebElement inputPostcode
        {
            get { return WebDriver.FindElementById("input-payment-postcode"); }
        }
        
        private IWebElement selectorCountry
        {
            get { return WebDriver.FindElementById("input-payment-country"); }
        }
        private IWebElement selectorZone
        {
            get { return WebDriver.FindElementById("input-payment-zone"); }
        }
        private IWebElement btnContinue
        {
            get { return WebDriver.FindElementById("button-payment-address"); }
        }
        private IWebElement closeBanner
        {
            get { return WebDriver.FindElementById("bitnami-close-banner-button"); }
        }
         private IWebElement banner
        {
            get { return WebDriver.FindElementById("bitnami-banner"); }
        }

        private By btn_ContinueDelivery
        {
            get { return By.Id("button-shipping-address"); }
        }
        private IWebElement btnContinueDelivery
        {
            get { return WebDriver.FindElement(btn_ContinueDelivery); }
        }
        private By btn_ContinueMethod
        {
            get { return By.Id("button-shipping-method"); }
        }
        private IWebElement btnContinueMethod
        {
            get { return WebDriver.FindElement(btn_ContinueMethod); }
        }
        private By btn_ContinuePayment
        {
            get { return By.Id("button-payment-method"); }
        }
        private IWebElement btnContinuePayment
        {
            get { return WebDriver.FindElement(btn_ContinuePayment); }
        }
        private IWebElement checkBoxTerms
        {
            get { return WebDriver.FindElementByXPath("//input[@type='checkbox']"); }
        }
        private By btn_Confirm
        {
            get { return By.Id("button-confirm"); }
        }
        private IWebElement btnConfirm
        {
            get { return WebDriver.FindElement(btn_Confirm); }
        }
        private IWebElement h1TextOrderConfirmed
        {
            get { return WebDriver.FindElementByXPath("//div[@id='content']/h1"); }
        }


        //Define functions and actions
        public CheckOutPage addBillingDetails()
        {
            radioNew.Click();
            inputFirstName.SendKeys("First Name");
            inputLastName.SendKeys("Last Name");
            inputCompany.SendKeys("Company");
            inputAddress1.SendKeys("Address1");
            inputAddress2.SendKeys("Address2");
            inputCity.SendKeys("City");
            inputPostcode.SendKeys("11111");

            SelectElement selectCountry = new SelectElement(selectorCountry);
            selectCountry.SelectByText("Italy");
            SelectElement selectZone = new SelectElement(selectorZone);
            selectZone.SelectByText("Pisa");

           
            Actions actions = new Actions(WebDriver);
            // Mover el ratón sobre el elemento
            actions.MoveToElement(banner).Perform();
            closeBanner.Click();

            btnContinue.Click();
            return this;
        }

        public CheckOutPage confirmButtons()
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout))
                .Until(CustomExpectedConditions.ElementIsVisible(btn_ContinueDelivery));
            btnContinueDelivery.Click();
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout))
                .Until(CustomExpectedConditions.ElementIsVisible(btn_ContinueMethod));
            btnContinueMethod.Click();
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout))
                .Until(CustomExpectedConditions.ElementIsVisible(btn_ContinuePayment));
            checkBoxTerms.Click();
            btnContinuePayment.Click();
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout))
                .Until(CustomExpectedConditions.ElementIsVisible(btn_Confirm));
            btnConfirm.Click();
            return this;
        }

        public CheckOutPage checkThePurchaseWorked()
        {
            Assert.AreEqual(h1TextOrderConfirmed.Text, "Your order has been placed!", "Check Your order has been placed");
            return this;
        }

    }
}
