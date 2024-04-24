using OpenQA.Selenium;
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

        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            signInPage.NavigateToSignInPage();
        }

        [When(@"I click on the sign-in button")]
        public void WhenIClickOnTheSign_InButton()
        {
            signInPage.ClickOnTheSignInButton();
        }

        [When(@"I enter the username ""(.*)"" and password ""(.*)""")]
        public void WhenIEnterTheUsernameAndPassword(string username, string password)
        {
            signInPage.EnterCredentials(username, password); // Make sure these fields exist and are interactable on the page
        }

        [Then(@"I click the login button")]
        public void ThenIClickTheLoginButton()
        {
            signInPage.ClickLoginButton(); // Ensure this clicks the actual button on the sign-in page
        }
    }
}