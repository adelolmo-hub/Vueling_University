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
            productPage = new ProductPage(setUpWebDriver);
            cartPage = new CartPage(setUpWebDriver);

            homePage.logIn();
            logInPage.addInfoLogIn(username, "a");
            homePage.searchLaptops("Sony vaio i5", username);
            productPage.addToCart();
            cartPage.placeOrder();
        }

        [TestCase(1)]
        public void testBuyPhone(int scenario)
        {
           
            homePage = new HomePage(setUpWebDriver);
            logInPage = new LogInPage(setUpWebDriver);
            productPage = new ProductPage(setUpWebDriver);
            cartPage = new CartPage(setUpWebDriver);

            homePage.logIn();
            logInPage.addInfoLogIn(username, "a");
            homePage.searchPhones("Nokia lumia 1520", username);
            productPage.addToCart();
            cartPage.placeOrder();
        }

        [TestCase(1)]
        public void testBuyMonitor(int scenario)
        {

            homePage = new HomePage(setUpWebDriver);
            logInPage = new LogInPage(setUpWebDriver);
            productPage = new ProductPage(setUpWebDriver);
            cartPage = new CartPage(setUpWebDriver);

            homePage.logIn();
            logInPage.addInfoLogIn(username, "a");
            homePage.searchMonitor("Apple monitor 24", username);
            productPage.addToCart();
            cartPage.placeOrder();
        }

        [TestCase(1)]
        public void testBuyProductsAndDelete(int scenario)
        {
            homePage = new HomePage(setUpWebDriver);
            logInPage = new LogInPage(setUpWebDriver);
            productPage = new ProductPage(setUpWebDriver);
            cartPage = new CartPage(setUpWebDriver);

            homePage.logIn();
            logInPage.addInfoLogIn(username, "a");
            homePage.searchPhones("Nokia lumia 1520", username);
            productPage.addToCartAndBuyAgain();
            homePage.searchLaptops("Sony vaio i5", username);
            productPage.addToCart();
            cartPage.findDeleteButtonAndClick("Sony vaio i5");
            cartPage.placeOrder();
        }
    }

}
