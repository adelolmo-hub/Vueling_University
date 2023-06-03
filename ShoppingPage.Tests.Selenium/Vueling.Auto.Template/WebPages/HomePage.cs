using Albert.Auto.Template.SetUp;
using Albert.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using System.Threading;

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
        private IWebElement btnAddCart
        {
            get { return WebDriver.FindElementByXPath("//i[@class = 'fa fa-caret-down']");  }
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
            Thread.Sleep(2000);
            return this;
        }
    }
}
