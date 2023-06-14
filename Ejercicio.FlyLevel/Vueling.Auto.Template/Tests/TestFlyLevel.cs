using AventStack.ExtentReports;
using NUnit.Framework;
using Albert.WebPages;
using System;

namespace Albert.Auto.Template.Tests
{
    [TestFixture]
    class TestFlyLevel : TestSetCleanBase
    {
        [TestCase(1)]
        public void testSearchFlights(int scenario)
        {
            homeFly = new HomePageFlyLevel(setUpWebDriver);
            DateTime ida = new DateTime(2023, 6, 9);
            DateTime vuelta = new DateTime(2023, 6, 15);


            homeFly.acceptCookies();
            homeFly.addInfoFlight(ida, vuelta);
            
        }

        [TestCase(1)]
        public void testSchBcn(int scenario)
        {
            homeFly = new HomePageFlyLevel(setUpWebDriver);
            string origin = "Santiago de Chile";
            string destination = "Barcelona";
            string month = "Septiembre";
            DateTime vuelta = new DateTime(2023, 6, 15);

            homeFly.acceptCookies();
            homeFly.addOriginAndDestination(origin, destination);
            homeFly.selectValidDates(month);
            homeFly.selectPassengers();

        }

        


    }

}
