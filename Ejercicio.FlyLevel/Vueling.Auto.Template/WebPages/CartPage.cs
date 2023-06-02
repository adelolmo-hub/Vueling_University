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
    public class CartPage : CommonPage
    {
        public CartPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        { 
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();

        private IWebElement btnPlaceOrder
        {
            get { return WebDriver.FindElementByXPath("//button[text() = 'Place Order']"); }
        }
        private IWebElement btnPurchase
        {
            get { return WebDriver.FindElementByXPath("//button[text() = 'Purchase']"); }
        }
        private IWebElement btnOK
        {
            get { return WebDriver.FindElementByXPath("//button[text() = 'OK']"); }
        }
        private IWebElement inputName
        {
            get { return WebDriver.FindElementById("name"); }
        }

        private IWebElement inputCountry
        {
            get { return WebDriver.FindElementById("country"); }
        }

        private IWebElement inputCity
        {
            get { return WebDriver.FindElementById("city"); }
        }

        private IWebElement inputCreditCard
        {
            get { return WebDriver.FindElementById("card"); }
        }

        private IWebElement inputMonth
        {
            get { return WebDriver.FindElementById("month"); }
        }

        private IWebElement inputYear
        {
            get { return WebDriver.FindElementById("year"); }
        }



        public void placeOrder()
        {
            btnPlaceOrder.Click();
            inputName.SendKeys("name");
            inputCountry.SendKeys("country");
            inputCity.SendKeys("city");
            inputCreditCard.SendKeys("1234");
            inputMonth.SendKeys("month");
            inputYear.SendKeys("year");
            btnPurchase.Click();
            Assert.IsTrue(btnOK.Displayed, "El mensaje de compra se muestra correctamente");
            btnOK.Click();
        }
    }

}
