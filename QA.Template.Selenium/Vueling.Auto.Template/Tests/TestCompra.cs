using AventStack.ExtentReports;
using NUnit.Framework;
using ProductStore.WebPages;
using Vueling.Auto.Template.Webpages;

namespace Vueling.Auto.Template.Tests
{
    [TestFixture]
    class TestCompra : TestSetCleanBase
    {
        string username = "a.o";
        [TestCase(1)]
        public void testBuyLaptop(int scenario)
        {
            

            homePage = new HomePage(setUpWebDriver);
            logInPage = new LogInPage(setUpWebDriver);
            laptopPage = new LaptopPage(setUpWebDriver);
            cartPage = new CartPage(setUpWebDriver);

            homePage.logIn();
            logInPage.addInfoLogIn(username, "a");
            homePage.searchLaptops("Sony vaio i5", username);
            laptopPage.addToCart();
            cartPage.placeOrder();
        }

        [TestCase(1)]
        public void testBuyPhone(int scenario)
        {
           
            homePage = new HomePage(setUpWebDriver);
            logInPage = new LogInPage(setUpWebDriver);
            laptopPage = new LaptopPage(setUpWebDriver);
            cartPage = new CartPage(setUpWebDriver);

            homePage.logIn();
            logInPage.addInfoLogIn(username, "a");
            homePage.searchLaptops("Sony vaio i5", username);
            laptopPage.addToCart();
            cartPage.placeOrder();
        }

        [TestCase(1)]
        public void testBuyMonitor(int scenario)
        {

            homePage = new HomePage(setUpWebDriver);
            logInPage = new LogInPage(setUpWebDriver);
            laptopPage = new LaptopPage(setUpWebDriver);
            cartPage = new CartPage(setUpWebDriver);

            homePage.logIn();
            logInPage.addInfoLogIn(username, "a");
            homePage.searchLaptops("Sony vaio i5", username);
            laptopPage.addToCart();
            cartPage.placeOrder();
        }
    }

}
