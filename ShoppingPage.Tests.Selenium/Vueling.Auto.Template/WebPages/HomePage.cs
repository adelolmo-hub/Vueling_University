using Albert.Auto.Template.Common;
using Albert.Auto.Template.SetUp;
using Albert.Auto.Template.WebPages.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Xml.Linq;

namespace Albert.Auto.Template.Webpages
{
    public class HomePage : CommonPage
    {

        //Define WebElements by: Id, CssSelector or XPath
        private IWebElement btnUser
        {
            get { return WebDriver.FindElementByXPath("//a[@title='My Account']"); }
        }

        
        private IWebElement btnRegister
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Register']"); }
        }

        private IWebElement btnLogin
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Login']"); }
        }

        private IWebElement btnDesktops
        {
            get { return WebDriver.FindElementByXPath("//a[@class = 'dropdown-toggle' and text() = 'Desktops']");  }
        }

        private IWebElement btnMac
        {
            get { return WebDriver.FindElementByXPath("//a[text() = 'Mac (1)']"); }
        }

        private IWebElement btnAddCart
        {
            get { return WebDriver.FindElementByXPath("//*[@id=\"content\"]/div[2]/div/div/div[2]/div[2]/button[1]");  }
        }
        
        private IWebElement alertSucces
        {
            get { return WebDriver.FindElementByXPath("//div[@class='alert alert-success alert-dismissible']"); }
        }

        private By btn_checkOut
        {
            get { return By.XPath("//a[@title = 'Checkout']"); }
        }
        private IWebElement btnCheckOut
        {
            get { return WebDriver.FindElement(btn_checkOut); }
        }

        private By btn_cart
        {
            get { return By.XPath("//a[@title = 'Shopping Cart']"); }
        }
        private IWebElement btnCart
        {
            get { return WebDriver.FindElement(btn_cart); }
        }




        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();

        //Constructor
        public HomePage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {

        }

        //Define functions and actions 

        public HomePage registerClick()
        {
            btnUser.Click();
            btnRegister.Click();
            return this;
        }

        public HomePage logInClick()
        {
            btnUser.Click();
            btnLogin.Click();
            return this;
        }

        public HomePage addToCart()
        {
            btnDesktops.Click();
            btnMac.Click();
            btnAddCart.Click();
           
            Assert.IsTrue(alertSucces.Displayed, "El elemento está visible");
            
            return this;
        }

        public HomePage goToCheckOut()
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10))
                .Until(CustomExpectedConditions.ElementIsClickable(btn_checkOut));
            btnCheckOut.Click();
            return this;
        }
        public HomePage goToCart()
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10))
                .Until(CustomExpectedConditions.ElementIsClickable(btn_cart));
            btnCart.Click();
            return this;

        }



    }
}
