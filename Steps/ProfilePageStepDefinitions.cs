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

        //         [Given(@"I click on the ""Add New Language"" button")]
        //         public void GivenIClickOnAddNew()
        //         {
        //             profilePage.ClickAddNewLanguageButton();
        //         }

        //         // Corrected to use parameters dynamically
        //         [When(@"I add a new language ""(.*)"" with level ""(.*)""")]
        //         public void WhenIAddANewLanguageWithLevel(string languageName, string languageLevel)
        //         {
        //             profilePage.AddLanguage(languageName, languageLevel);
        //         }

        //         [Given(@"I click on the ""Edit Language"" button")]
        //         public void GivenIClickOnEditLanguage()
        //         {
        //             profilePage.ClickEditLanguageButton();
        //         }

        //         // Corrected to use parameters dynamically
        //         [When(@"I edit the language ""(.*)"" to ""(.*)""")]
        //         public void WhenIEditTheLanguageTo(string fromLanguage, string toLanguage)
        //         {
        //             profilePage.EditLanguage(fromLanguage, toLanguage);
        //         }

        //         // Corrected method name and signature; assumes no parameter needed
        //         [Given(@"I click on the ""Delete Language"" button")]
        //         public void GivenIClickOnDeleteLanguage()
        //         {
        //             profilePage.ClickDeleteLanguageButton();
        //         }

        [Given(@"I am on the profile page")]
        public void GivenIAmOnTheProfilePage()
        {

            profilePage.GetGreetingText();

        }

        [When(@"I add a language ""(.*)"" and level ""(.*)""")]

        public void WhenIAddALanguageAndLevel(string language, string level)
        {

            profilePage.ClickAddNewLanguageButton();

            profilePage.AddLanguage(language, level);

        }

        [When(@"I edit the language ""(.*)"" to new name ""(.*)"" and new level ""(.*)""")]

        public void WhenIEditTheLanguageToNewNameAndNewLevel(string oldLanguage , string newLanguage , string newLevel){
            
             profilePage.EditLanguage(oldLanguage, newLanguage, newLevel);

        }

        [When(@"I delete the language ""(.*)"" and level ""(.*)""")]

        public void WhenIDeleteTheLanguageAndLevel(string language, string level){

            profilePage.ClickDeleteLanguageButton();
        }

        [When(@"I add a skill ""(.*)"" and level ""(.*)""")]

        public void WhenIAddASkillAndLevel(string skill, string level){

            profilePage.AddSkill(skill,level);

        }

        [When(@"I edit the skill ""(.*)"" to new name ""(.*)"" and new level ""(.*)""")]

        public void WhenIEditTheSkillToNewNameAndNewLevel(string oldSkill, string newSkill, string newLevel){

            profilePage.EditSkill(oldSkill, newSkill, newLevel);

        }

        
        [When(@"I delete the skill ""(.*)"" and level ""(.*)""")]

        public void WhenIDeleteTheSkillAndLevel(string skill, string level){

            profilePage.DeleteSkill();
        }

        [Then(@"I am able to see the added language record ""(.*)"" in the table")]

        public void ThenIAmAbleToSeeTheAddedLanguageRecordInTheTable(string language)
        {

            profilePage.GetAddedLanguageValueText();
        }

        [Then(@"I am able to see an error message")]

        public void ThenIAmAbleToSeeAnErrorMessage(){

            Assert.True(profilePage.IsDuplicateErrorMessageDisplayed());
        }

        [Then(@"I am able to see that the relevant record has been updated succesfully")]

        public void ThenIAmAbleToSeeThatTheRelevantRecordHasBeenUpdatedSuccessfully(){

            Assert.True(profilePage.IsLanguageEditMessageDisplayed());
        }

        [Then(@"I am able to see the relevant record has been deleted")]

        public void ThenIAmAbleToSeeTheRelevantRecordHasBeenDeleted(){

            Assert.True(profilePage.IsLanguageDeleteMessageDisplayed());
        }

        [Then(@"I am able to see the skill record adding success message")]

        public void ThenIAmAbleToSeeTheSkillRecordAddingSuccessMessage(){

            Assert.True(profilePage.IsSkillAddingMessageDisplayed());
        }

        [Then(@"I am able to see an error message relevant to the duplicate skill records")]

        public void ThenIAmAbleToSeeAnErrorMessageRelevantToTheDuplicateSkillRecords(){

            Assert.True(profilePage.IsDuplicateSkillErrorMessageDisplayed());
        }

        [Then(@"I am able to see that the relevant skill record has been updated succesfully")]

        public void ThenIAmAbleToSeeThatTheRelevantSkillRecordHasBeenUpdatedSuccessfully(){

            Assert.True(profilePage.IsEditSkillMessageDisplyed());
        }

        [Then(@"I am able to see the relevant skill record has been deleted")]

        public void ThenIAmAbleToSeeTheRelevantSkillRecordHasBeenDeleted(){

            Assert.True(profilePage.IsDeleteSkillMessageDisplayed());
        }

        [Then(@"I sign out")]
        public void ThenISignOut()
        {
            profilePage.ClickOnTheSignOutButton();
        }
    }
}
