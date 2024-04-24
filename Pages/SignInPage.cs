using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace QA_Mars_OnboardingTaskSpecflow.Pages
{
    public class SignInPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); // Initialize WebDriverWait with a timeout

        }

        private readonly By btnSigninlocator = By.XPath("//*[@id='home']/div/div/div[1]/div/a");
        private readonly By txaEmailaddresslocator = By.Name("email");
        private readonly By txaPasswordlocator = By.Name("password");
        private readonly By btnLoginlocator = By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button");


        public void NavigateToSignInPage()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:8080");
        }

        public void ClickOnTheSignInButton()
        {
            IWebElement btnSignin = driver.FindElement(btnSigninlocator);
            btnSignin.Click();
        }

        public void EnterCredentials(string username, string password)
        {
            IWebElement txaEmailaddress = wait.Until(ExpectedConditions.ElementIsVisible(txaEmailaddresslocator));
            txaEmailaddress.Clear();
            txaEmailaddress.SendKeys("isurikaperera100@gmail.com");

            IWebElement txaPassword = wait.Until(ExpectedConditions.ElementIsVisible(txaPasswordlocator));
            txaPassword.Clear();
            txaPassword.SendKeys("$h!xHnDypG");
        }

        public void ClickLoginButton()
        {
            // Identify Login button and click on it
            IWebElement btnLogin = driver.FindElement(btnLoginlocator);
            btnLogin.Click();
        }
    }
}