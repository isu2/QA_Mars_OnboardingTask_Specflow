using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace QA_Mars_OnboardingTaskSpecflow.Pages
{
    public class ProfilePage
    {
        private readonly IWebDriver driver;
        private WebDriverWait wait;
        private readonly By btnAddNewLangauageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div");
        private readonly By txaLanguageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input");
        private readonly By ddlChooseLanguageLevelLocator = By.XPath("//select[@class='ui dropdown' and @name = 'level']");
        private readonly By btnAddLanguageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]");
        private readonly By btnEditLanguageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]");
        private readonly By txaEditLanguageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input");
        private readonly By btnUpdateLanaguageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]");
        private readonly By btnDeleteLanguageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i");
        private readonly By tabSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]");
        private readonly By btnAddNewSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div");
        private readonly By txaSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input");
        private readonly By ddlChooseSkillLevelLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select");
        private readonly By btnAddSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]");
        private readonly By btnEditSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]");
        private readonly By txaEditSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input");
        private readonly By btnUpdateSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]");
        private readonly By btnDeleteSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]");

        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }

        // Method to click on "Add New" for languages
        public void ClickAddNewLanguageButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(btnAddNewLangauageLocator)).Click();
        }

        public void AddLanguage(string language, string level)
        {

            //Identify add language field and enter a language
            IWebElement txaLanguage = wait.Until(ExpectedConditions.ElementIsVisible(txaLanguageLocator));
            txaLanguage.Clear(); // Clear any pre-existing text
            txaLanguage.SendKeys("Spanish"); // Send the new text

            IWebElement ddlChooseLanguageLevel = wait.Until(ExpectedConditions.ElementIsVisible(ddlChooseLanguageLevelLocator));
            SelectElement select = new SelectElement(ddlChooseLanguageLevel);
            select.SelectByText("Fluent");

            //Identify Add button and click on it

            wait.Until(ExpectedConditions.ElementToBeClickable(btnAddLanguageLocator)).Click();
        }

        public void ClickEditLanguageButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(btnEditLanguageLocator)).Click();
        }

        public void EditLanguage(string language, string level)
        {

            IWebElement txaEditLanguage = driver.FindElement(txaEditLanguageLocator);
            txaEditLanguage.Clear();
            txaEditLanguage.SendKeys("French");

            IWebElement btnUpdateLanaguage = driver.FindElement(btnUpdateLanaguageLocator);
            btnUpdateLanaguage.Click();

        }

        public void ClickDeleteLanguageButton()
        {
            // wait.Until(ExpectedConditions.ElementToBeClickable(btnDeleteLanguageLocator)).Click();
            IWebElement button = wait.Until(ExpectedConditions.ElementIsVisible(btnDeleteLanguageLocator));
            wait.Until(ExpectedConditions.ElementToBeClickable(btnDeleteLanguageLocator)).Click();
        }

        public void AddSkill(IWebDriver driver)
        {
            IWebElement tabSkill = driver.FindElement(tabSkillLocator);
            tabSkill.Click();

            //Identify Add new button under skill tab and click on it
            IWebElement btnAddNewSkill = driver.FindElement(btnAddNewSkillLocator);
            btnAddNewSkill.Click();

            //Identify add skill field and enter a skill
            IWebElement txaSkill = driver.FindElement(txaSkillLocator);
            txaSkill.SendKeys("Coding");

            //Identify Choose skill level field and select a skill level
            IWebElement ddlChooseSkillLevel = driver.FindElement(ddlChooseSkillLevelLocator);
            SelectElement select = new SelectElement(ddlChooseSkillLevel);
            select.SelectByText("Expert");

            //Identify add button and click on it
            IWebElement btnAddSkill = driver.FindElement(btnAddSkillLocator);
            btnAddSkill.Click();

        }

        public void EditSkill(IWebDriver driver)
        {
            IWebElement btnEditSkill = driver.FindElement(btnEditSkillLocator);
            btnEditSkill.Click();

            //Identify skill field and edit it
            IWebElement txaEditSkill = driver.FindElement(txaEditSkillLocator);
            txaEditSkill.Clear();
            txaEditSkill.SendKeys("Collaboration");

            //Identify update button and cick on it
            IWebElement btnUpdateSkill = driver.FindElement(btnUpdateSkillLocator);
            btnUpdateSkill.Click();
        }

        public void DeleteSkill(IWebDriver driver)
        {
            IWebElement btnDeleteSkill = driver.FindElement(btnDeleteSkillLocator);
            btnDeleteSkill.Click();

        }
    }
}