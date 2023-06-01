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
    public class ProductPage : CommonPage
    {
        public ProductPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        { 
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();

        private IWebElement btnBuy
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Add to cart']"); }
        }
        private IWebElement btnCart
        {
            get { return WebDriver.FindElementById("cartur"); }
        }

        private IWebElement btnHome
        {
            get { return WebDriver.FindElementById("nava"); }
        }


        public void addToCart()
        {
            btnBuy.Click();
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());
            alert.Accept();
            btnCart.Click();
        }

        public void addToCartAndBuyAgain()
        {
            btnBuy.Click();
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());
            alert.Accept();
            btnHome.Click();
        }

    }

}
