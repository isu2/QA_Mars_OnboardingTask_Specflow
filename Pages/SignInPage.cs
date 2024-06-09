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

        private readonly By popUpMessagelocator = By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input");

        private readonly By errorMessagelocator = By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/div");

        private readonly By btnSignOutlocator = By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/a[2]/button");

        public void NavigateToSignInPage()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:8080");
        }

        public void ClickOnTheSignInButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); // Increase the wait time if needed
            wait.Until(ExpectedConditions.ElementIsVisible(btnSigninlocator));

            IWebElement btnSignin = driver.FindElement(btnSigninlocator);
            btnSignin.Click();
        }

        public void EnterCredentials(string username, string password)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); // Increase the wait time if needed
            wait.Until(ExpectedConditions.ElementIsVisible(txaEmailaddresslocator));

            IWebElement txaEmailAddress = driver.FindElement(txaEmailaddresslocator);
            txaEmailAddress.Clear();
            txaEmailAddress.SendKeys(username);

            IWebElement txaPassword = driver.FindElement(txaPasswordlocator);
            txaPassword.Clear();
            txaPassword.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            // Identify Login button and click on it
            IWebElement btnLogin = driver.FindElement(btnLoginlocator);
            btnLogin.Click();
        }

        public bool IsPopUpDisplayed()
        {
            // Wait until the pop-up is visible or the timeout occurs
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(popUpMessagelocator));
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }

        public bool IsErrorMessageDisplayed()
        {

            IWebElement errorMessage = driver.FindElement(errorMessagelocator);

            return errorMessage.Displayed;

        }

        public void ClickOnTheSignOutButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); // Increase the wait time if needed
            wait.Until(ExpectedConditions.ElementIsVisible(btnSignOutlocator));

            IWebElement btnSignin = driver.FindElement(btnSignOutlocator);
            btnSignin.Click();
        }
    }
}