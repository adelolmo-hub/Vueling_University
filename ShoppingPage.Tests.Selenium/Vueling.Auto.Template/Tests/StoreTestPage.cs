using AventStack.ExtentReports;
using NUnit.Framework;
using Albert.Auto.Template.Webpages;
using System.Threading;

namespace Albert.Auto.Template.Tests
{
    [TestFixture]
    class StoreTestPage : TestSetCleanBase
    {
        string logInemail = "a123456@a.com";
        string logInpassword = "aaaa";

        [TestCase(1), Order(1)]
        public void RegisterTest(int scenario)
        {
            string name = "A";
            string lastName = "O";
            string telephone = "123456789";
            string email = "tolamo20454@ozatvn.com";
            string password = "1234567";

            homePage = new HomePage(setUpWebDriver);
            insecureConexionPage = new InsecureConexionPage(setUpWebDriver);
            registerPage = new RegisterPage(setUpWebDriver);

            homePage.registerClick();
            insecureConexionPage.skipInsecureConexion();
            registerPage.completeRegisterForm(name,lastName,email,telephone,password);
        }

        [TestCase(1), Order(2)]
        public void LogInTest(int scenario)
        {
           

            homePage = new HomePage(setUpWebDriver);
            insecureConexionPage = new InsecureConexionPage(setUpWebDriver);
            logInPage = new LogInPage(setUpWebDriver);

            homePage.logInClick();
            insecureConexionPage.skipInsecureConexion();
            logInPage.completeLogIn(logInemail, logInpassword);

        }

        [TestCase(1), Order(3)]
        public void buyAProductTest(int scenario)
        {
            homePage = new HomePage(setUpWebDriver);
            insecureConexionPage = new InsecureConexionPage(setUpWebDriver);
            logInPage = new LogInPage(setUpWebDriver);
            checkOutPage = new CheckOutPage(setUpWebDriver);

            homePage.logInClick();
            insecureConexionPage.skipInsecureConexion();
            logInPage.completeLogIn(logInemail, logInpassword);

            homePage.addToCart();
            checkOutPage.addBillingDetails();
            checkOutPage.confirmButtons();
            Thread.Sleep(1000);
        }
    }

}
