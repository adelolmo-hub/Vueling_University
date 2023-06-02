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
    public class LaptopPage : CommonPage
    {
        public LaptopPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
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


        public void addToCart()
        {
            btnBuy.Click();
            btnCart.Click();
        }
       
    }

}
