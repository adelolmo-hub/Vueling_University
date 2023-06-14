using AventStack.ExtentReports;
using NUnit.Framework;
using Albert.WebPages;
using System;
using Albert.Auto.Template.Common;
using System.Threading;

namespace Albert.Auto.Template.Tests
{
    [TestFixture]
    class TestVueling : TestSetCleanBase
    {
        [TestCase(1)]
        public void testFlightFirstAugust(int scenario)
        {
            homePageVueling = new HomePageVueling(setUpWebDriver);

            homePageVueling.manageCookiesAlert();
            homePageVueling.addInfoFlight();
            homePageVueling.selectFirstOfAugust();
            
        }
        [TestCase(1)]
        public void testRegisterVueling(int scenario)
        {
            homePageVueling = new HomePageVueling(setUpWebDriver);
            registerPageVueling = new RegisterPageVueling(setUpWebDriver);

            string name = Helpers.GetRandomString(6);
            string lastName = Helpers.GetRandomString(8);
            string email = Helpers.GetRandomString(6) + "@gmail.com";
            string password = "1234567aA!";
            string firstAnswer = Helpers.GetRandomString(15);
            string secondAsnwer = Helpers.GetRandomString(15);

            homePageVueling.manageCookiesAlert();
            homePageVueling.clickRegister();
            registerPageVueling.completeRegisterForm(name, lastName, email, password, firstAnswer, secondAsnwer);

        }

        [TestCase(1)]
        public void testOWCheapestFlight(int scenario)
        {
            homePageVueling = new HomePageVueling(setUpWebDriver);
            flightSearchPage = new FlightSearchPage(setUpWebDriver);

            homePageVueling.manageCookiesAlert();
            homePageVueling.oneWayButtonclick();
            homePageVueling.addInfoFlight();
            homePageVueling.selectDayAndAddABaby();
     
            flightSearchPage.getCheapestFlight();
            


        }

    }

}
