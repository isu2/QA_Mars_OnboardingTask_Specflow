using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QA_Mars_OnboardingTaskSpecflow.Pages;
using TechTalk.SpecFlow;
using Xunit;

namespace QA_Mars_OnboardingTaskSpecflow.Steps
{
    [Binding]
    public class SignInPageStepDefinitions
    {
        private readonly IWebDriver driver;
        private readonly SignInPage signInPage;

        public SignInPageStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            signInPage = new SignInPage(driver);
        }

        [Given(@"I am on the login page by clicking Sign In button")]
        public void GivenIAmOnTheLoginPageByClickingSignInButton()
        {
            signInPage.NavigateToSignInPage();
            signInPage.ClickOnTheSignInButton();
        }

        [When(@"I enter username ""(.*)"" and password ""(.*)""")]
        public void WhenIEnterUsernameAndPassword(string username, string password)
        {
            signInPage.EnterCredentials(username, password);
        }

        [When(@"I click on the Login button")]
        public void WhenIClickOnTheLoginButton()
        {
            signInPage.ClickLoginButton();
        }

        [Then(@"I am able to sign in to the profile page")]
        public void ThenIAmAbleToSignInToTheProfilePage()
        {
            // Wait for the profile page to load
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.Url.Contains("/Account/Profile"));

            Assert.Contains("/Account/Profile", driver.Url);
        }

        [Then(@"I should see a pop-up to verify email")]

        public void ThenIShouldSeeAPop_UpToVerifyEmail()
        {
            Assert.True(signInPage.IsPopUpDisplayed());
        }

        [Then(@"I should see an error message near the blank field")]

        public void ThenIShouldSeeAnErrorMessageNearTheBlankField()
        {
            Assert.True(signInPage.IsErrorMessageDisplayed());

        }
    }
}