using Albert.Auto.Template.SetUp;
using Albert.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System;
using Albert.Auto.Template.Common;
using NUnit.Framework;

namespace Albert.WebPages
{
    public class HomePageVueling : CommonPage
    {
        public HomePageVueling(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();


        private IWebElement inputOrigin
        {
            get { return WebDriver.FindElementById("AvailabilitySearchInputSearchView_TextBoxMarketOrigin1"); }
        }
        private IWebElement originCity(string originCity)
        {
           return WebDriver.FindElementByXPath("//div[@id='stationsList']//li/a[@data-id-code='" + originCity + "']");
        }
        private IWebElement inputABaby
        {
            get { return WebDriver.FindElementById("AvailabilitySearchInputSearchView_DropDownListPassengerType_INFANT"); }
        }
        private IWebElement destinationCity(string destinationCity)
        {
            return WebDriver.FindElementByXPath("//div[@id='stationsList']//li/a[@data-id-code='" + destinationCity + "']");
        }
        private IWebElement btnNext
        {
            get { return WebDriver.FindElementByXPath("//a[@data-handler = 'next']"); }
        }
        private By acceptCookies
        {
            get { return By.Id("onetrust-accept-btn-handler"); }
        }
        private IWebElement btnAcceptCookies
        {
            get { return WebDriver.FindElementById("onetrust-accept-btn-handler"); }
        }
        private IWebElement btnRegister
        {
            get { return WebDriver.FindElementByXPath("//a[@class='optionRegister login-menu']"); }
        }
        
        private IWebElement btnConfirmRegister
        {
            get { return WebDriver.FindElementByXPath("//a[@class='mv_button icon icon-right']"); }
        }
        private IWebElement btnOneWay
        {
            get { return WebDriver.FindElementByXPath("//label[@for = 'AvailabilitySearchInputSearchView_OneWay']"); }
        }
        private IWebElement btnSelectDay
        {
            get { return WebDriver.FindElementByXPath("//div[@class = 'ui-datepicker-group ui-datepicker-group-first']//a[text() = '11']"); }
        }
        private IWebElement btnSearchFlight
        {
            get { return WebDriver.FindElementById("AvailabilitySearchInputSearchView_btnClickToSearchNormal"); }
        }
        

        public void addInfoFlight()
        {
            inputOrigin.Click();
            originCity("BCN").Click();
            destinationCity("MAD").Click();
        }
        public void oneWayButtonclick()
        {
            btnOneWay.Click();
        }
        public void selectDayAndAddABaby()
        {
            btnSelectDay.Click();
            inputABaby.SendKeys("1");
            btnSearchFlight.Click();
        }
        public void manageCookiesAlert()
        {

            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10))
            .Until(ExpectedConditions.ElementIsVisible(acceptCookies));

            btnAcceptCookies.Click();
        }
        public void selectFirstOfAugust()
        {

            var textMonth = WebDriver.FindElementByXPath("//div[@class = 'ui-datepicker-group ui-datepicker-group-first']//a[text() = '28']");
            while (textMonth.GetAttribute("data-month")!="7")
            {
                btnNext.Click();
                textMonth = WebDriver.FindElementByXPath("//div[@class = 'ui-datepicker-group ui-datepicker-group-first']//a[text() = '28']");
                
            }
            textMonth.Click();
        }

        public void clickRegister()
        {
            btnRegister.Click();
            btnConfirmRegister.Click();
        }
        

    }
}
