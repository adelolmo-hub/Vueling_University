using Albert.Auto.Template.SetUp;
using Albert.Auto.Template.WebPages.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Security.Cryptography;
using System.Threading;

namespace Albert.Auto.Template.Webpages
{
    public class InsecureConexionPage : CommonPage
    {
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();

        //Constructor
        public InsecureConexionPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
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

       
        //Define functions and actions
        public InsecureConexionPage skipInsecureConexion()
        {
            btnDetails.Click();
            btnProceed.Click();
            return this;
        }

    }
}
