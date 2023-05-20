using OpenQA.Selenium;
using System;

namespace AuthorizationTests
{
    public class CianTests
    {
        private IWebDriver driver;

        private readonly By _singInButton = By.XPath("//*[@id=\"header-frontend\"]/div[2]/div/div/a/span");
        private readonly By _AuthInput = By.XPath("//input[@name='username']");
        private const string _login = "vladimir-andreev-2013@yandex.ru";
        private const string _pass = "Test_Cian_2022";
        private readonly By _AnotherButton = By.XPath("//span[text()='Другим способом']");
        private readonly By _NextButton = By.XPath("//span[text()='Продолжить']");
        private readonly By _PassInput = By.XPath("//input[@name='password']");
        private readonly By _loginButton = By.XPath("//span[text()='Войти']");
  

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Edge.EdgeDriver();
            driver.Navigate().GoToUrl("https://spb.cian.ru/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void LoginCheck()
        {
            var singIn = driver.FindElement(_singInButton);
            singIn.Click();
        }

        [Test]
        public void AnotherCheck()
        {
            var singIn = driver.FindElement(_singInButton);
            singIn.Click();
            var anothersingIn = driver.FindElement(_AnotherButton);
            anothersingIn.Click();
        }

        [Test]
        public void AuthCheck()
        {
            var singIn = driver.FindElement(_singInButton);
            singIn.Click();
            var anothersingIn = driver.FindElement(_AnotherButton);
            anothersingIn.Click();
            var login = driver.FindElement(_AuthInput);
            login.SendKeys(_login);
            var nextsingIn = driver.FindElement(_NextButton);
            nextsingIn.Click();
            var pass = driver.FindElement(_PassInput);
            pass.SendKeys(_pass);
            var loggIn = driver.FindElement(_loginButton);
            loggIn.Click();
            
        }

        [TearDown] 
        public void TearDown() 
        { 

        }

    }
}