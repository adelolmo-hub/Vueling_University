using AventStack.ExtentReports;
using NUnit.Framework;
using Albert.Auto.Template.Webpages;
using System.Threading;

namespace Albert.Auto.Template.Tests
{
    [TestFixture]
    class StoreTestPage : TestSetCleanBase
    {
        
        [TestCase(1)]
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

        [TestCase(1)]
        public void LogInTest(int scenario)
        {
            string email = "a123456@a.com";
            string password = "aaaa";

            homePage = new HomePage(setUpWebDriver);
            insecureConexionPage = new InsecureConexionPage(setUpWebDriver);
            logInPage = new LogInPage(setUpWebDriver);

            homePage.logInClick();
            insecureConexionPage.skipInsecureConexion();
            logInPage.completeLogIn(email, password);
            Thread.Sleep(10000);

        }

        [TestCase(1)]
        public void buyAProductTest(int scenario)
        {
            homePage = new HomePage(setUpWebDriver);

            homePage.addToCart();
        }
    }

}
