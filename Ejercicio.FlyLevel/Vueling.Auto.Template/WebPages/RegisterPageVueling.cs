using Albert.Auto.Template.SetUp;
using Albert.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System;
using Albert.Auto.Template.Common;
using NUnit.Framework;
using AventStack.ExtentReports;

namespace Albert.WebPages
{
    public class RegisterPageVueling : CommonPage
    {
        public RegisterPageVueling(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new System.NotImplementedException();


        private IWebElement inputName
        {
            get { return WebDriver.FindElementById("CONTROLGROUPREGISTERVIEW_PersonInputRegisterView_TextBoxFirstName"); }
        }
        private IWebElement inputLastName
        {
            get { return WebDriver.FindElementById("CONTROLGROUPREGISTERVIEW_PersonInputRegisterView_TextBoxLastName"); }
        }
        private IWebElement inputEmail
        {
            get { return WebDriver.FindElementById("CONTROLGROUPREGISTERVIEW_PersonInputRegisterView_TextBoxEmail"); }
        }
        private IWebElement inputPassword
        {
            get { return WebDriver.FindElementById("CONTROLGROUPREGISTERVIEW_MemberInputRegisterView_PasswordFieldAgentPassword"); }
        }
        private IWebElement inputConfirmPassword
        {
            get { return WebDriver.FindElementById("CONTROLGROUPREGISTERVIEW_MemberInputRegisterView_PasswordFieldPasswordConfirm"); }
        }
        private IWebElement selectorFirstQuestion
        {
            get { return WebDriver.FindElementById("CONTROLGROUPREGISTERVIEW_SecurityQuestionsRegisterView_FirstQuestion"); }
        }
        private IWebElement inputFirstAnswer
        {
            get { return WebDriver.FindElementById("CONTROLGROUPREGISTERVIEW_SecurityQuestionsRegisterView_FirstAnswer"); }
        }
        private IWebElement selectorSecondQuestion
        {
            get { return WebDriver.FindElementById("CONTROLGROUPREGISTERVIEW_SecurityQuestionsRegisterView_SecondQuestion"); }
        }
        private IWebElement inputSecondAnswer
        {
            get { return WebDriver.FindElementById("CONTROLGROUPREGISTERVIEW_SecurityQuestionsRegisterView_SecondAnswer"); }
        }
        private IWebElement firstQuestionRandom(int randomNum)
        {
            return WebDriver.FindElementByXPath("//select[@id = 'CONTROLGROUPREGISTERVIEW_SecurityQuestionsRegisterView_FirstQuestion']//option[@value='" + randomNum + "']");
        }
        private IWebElement secondQuestionRandom(int randomNum)
        {
            return WebDriver.FindElementByXPath("//select[@id = 'CONTROLGROUPREGISTERVIEW_SecurityQuestionsRegisterView_SecondQuestion']//option[@value='" + randomNum + "']");
        }
        private By checkBox_Terms
        {
            get { return By.Id("CONTROLGROUPREGISTERVIEW_LegalConditionsCheckbox"); }
        }
        private IWebElement checkBoxTerms
        {
            get { return WebDriver.FindElement(checkBox_Terms); }
        }

        public void completeRegisterForm(string name, string lastName, string email, string password, string firstAnswer, string secondAnswer)
        {
            inputName.SendKeys(name);
            inputLastName.SendKeys(lastName);
            inputEmail.SendKeys(email);
            inputPassword.SendKeys(password);
            inputConfirmPassword.SendKeys(password);
            selectorFirstQuestion.Click();
            
            inputFirstAnswer.SendKeys(firstAnswer);
            selectorSecondQuestion.Click();
            firstQuestionRandom(randomNum()).Click();
            inputSecondAnswer.SendKeys(secondAnswer);
            secondQuestionRandom(randomNum()).Click();
            CheckboxClick();
            
        }

        public int randomNum()
        {
            Random random = new Random();
            int num = random.Next(2,  12);
            return num;
        }
        public void CheckboxClick()
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10)).Until(CustomExpectedConditions.ElementIsVisible(checkBox_Terms));

            Jse2.ExecuteScript("arguments[0].click();", checkBoxTerms);
        }
    }
}
