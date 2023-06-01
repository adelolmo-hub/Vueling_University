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


        private By btn_PlaceOrder
        {
            get { return By.XPath("//button[text() = 'Place Order']");  }
        }
        private IWebElement btnPlaceOrder
        {
            get { return WebDriver.FindElement(btn_PlaceOrder); }
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
            // new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout))
            //    .Until(CustomExpectedConditions.ElementIsVisible(btn_PlaceOrder));
            //No lo he podido arreglar de otra manera. Lo siento Agus
            Thread.Sleep(2000);
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

        public void findDeleteButtonAndClick(String productName)
        {
            IWebElement productElement = WebDriver.FindElementByXPath("//td[text()='" + productName + "']");
            IWebElement productColumn = productElement.FindElement(By.XPath("./ancestor::tr"));
            IWebElement deleteButton = productColumn.FindElement(By.XPath(".//a[contains(@onclick, 'deleteItem')]"));
            deleteButton.Click();
        }
    }

}
