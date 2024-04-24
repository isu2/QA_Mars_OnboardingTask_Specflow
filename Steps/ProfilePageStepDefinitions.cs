using OpenQA.Selenium;
using QA_Mars_OnboardingTaskSpecflow.Pages;
using TechTalk.SpecFlow;
using Xunit;

namespace QA_Mars_OnboardingTaskSpecflow.Steps
{
    [Binding]
    public class ProfilePageStepDefinitions
    {
        private readonly IWebDriver driver;
        private readonly ProfilePage profilePage;

        public ProfilePageStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            profilePage = new ProfilePage(driver);
        }

        [Given(@"I click on the ""Add New Language"" button")]
        public void GivenIClickOnAddNew()
        {
            profilePage.ClickAddNewLanguageButton();
        }

        // Corrected to use parameters dynamically
        [When(@"I add a new language ""(.*)"" with level ""(.*)""")]
        public void WhenIAddANewLanguageWithLevel(string languageName, string languageLevel)
        {
            profilePage.AddLanguage(languageName, languageLevel);
        }

        [Given(@"I click on the ""Edit Language"" button")]
        public void GivenIClickOnEditLanguage()
        {
            profilePage.ClickEditLanguageButton();
        }

        // Corrected to use parameters dynamically
        [When(@"I edit the language ""(.*)"" to ""(.*)""")]
        public void WhenIEditTheLanguageTo(string fromLanguage, string toLanguage)
        {
            profilePage.EditLanguage(fromLanguage, toLanguage);
        }

        // Corrected method name and signature; assumes no parameter needed
        [Given(@"I click on the ""Delete Language"" button")]
        public void GivenIClickOnDeleteLanguage()
        {
            profilePage.ClickDeleteLanguageButton();
        }
    }
}
