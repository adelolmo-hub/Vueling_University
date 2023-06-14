using Albert.Auto.Template.SetUp;
using Albert.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System;
using Albert.Auto.Template.Common;
using NUnit.Framework;
using AventStack.ExtentReports;
using System.Collections.Generic;

namespace Albert.WebPages
{
    public class FlightSearchPage : CommonPage
    {
        public FlightSearchPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();

        private IList<IWebElement> allPricesList { get { return WebDriver.FindElementsByXPath("//span[@id = 'justPrice']/span[@class = 'price-currency__amount']"); } }
        public void getCheapestFlight()
        {
            int cheaperFlightPrice = 0;
            IWebElement cheaperFlightButton = null;
            foreach (IWebElement element in allPricesList)
            {
                int currentPrice = int.Parse(element.Text);
                if (currentPrice > cheaperFlightPrice)
                {
                    cheaperFlightPrice = currentPrice;
                    cheaperFlightButton = element;
                }
            }
            //Opcional, no se si hace falta
            cheaperFlightButton = cheaperFlightButton.FindElement(By.XPath(".."));
            cheaperFlightButton.Click();
        }
    }
}
