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
      //private readonly By txaEditLanguageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input");
      private readonly By txaEditLanguageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input");
      private readonly By btnUpdateLanaguageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]");
      private readonly By btnDeleteLanguageLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[2]");
      private readonly By greetingLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span");
      private readonly By languageValueLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]");
      private readonly By btnSignOutlocator = By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button");
      
      private readonly By duplicateErrorMessagelocator = By.XPath("/html/body/div[1]");
      private readonly By ddlEditLanguageLevelLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select");
      private readonly By languageEditMessageLocator = By.XPath("/html/body/div[1]");
      private readonly By LanguageDeleteMessageLocator = By.XPath("/html/body/div[1]");
      //private readonly By languageValueLocator1 = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[1]");
      private readonly By tabSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]");
      private readonly By btnAddNewSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div");
      private readonly By txaSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input");
      private readonly By ddlChooseSkillLevelLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select");
      private readonly By btnAddSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]");
      private readonly By btnEditSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]");
      private readonly By txaEditSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input");
      private readonly By btnUpdateSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]");
      private readonly By btnDeleteSkillLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[2]");

      private readonly By SkillAddingMessageLocator = By.XPath("/html/body/div[1]");
      private readonly By ddlEditSkillLevelLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select");

      private readonly By DuplicateSkillErrorMessageLocator = By.XPath("/html/body/div[1]");
      private readonly By EditSkillMessageLocator = By.XPath("/html/body/div[1]");
      private readonly By DeleteSkillMessageLocator = By.XPath("/html/body/div[1]");

      public ProfilePage(IWebDriver driver)
      {
         this.driver = driver;
         wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

      }

      public string GetGreetingText()
      {
         IWebElement greetingElement = wait.Until(ExpectedConditions.ElementIsVisible(greetingLocator));
         return greetingElement.Text;
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
         txaLanguage.SendKeys(language); // Send the new text

         IWebElement ddlChooseLanguageLevel = wait.Until(ExpectedConditions.ElementIsVisible(ddlChooseLanguageLevelLocator));
         SelectElement select = new SelectElement(ddlChooseLanguageLevel);
         select.SelectByText(level);

         //Identify Add button and click on it

         wait.Until(ExpectedConditions.ElementToBeClickable(btnAddLanguageLocator)).Click();
      }

      public string GetAddedLanguageValueText()
      {
         IWebElement languageValueElement = wait.Until(ExpectedConditions.ElementIsVisible(languageValueLocator));
         return languageValueElement.Text;
      }

      public bool IsDuplicateErrorMessageDisplayed(){

         //IWebElement duplicateErrorMessage = driver.FindElement(duplicateErrorMessagelocator);   
         //return duplicateErrorMessage.Displayed;
         
         try{
            wait.Until(ExpectedConditions.ElementIsVisible(duplicateErrorMessagelocator));
            return true;
         }

         catch(WebDriverTimeoutException){
            return false;
         }

      }

      //public void ClickOnTheSignOutButton()
      //{
         //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); // Increase the wait time if needed
         //wait.Until(ExpectedConditions.ElementIsVisible(btnSignOutlocator));

         //IWebElement btnSignin = driver.FindElement(btnSignOutlocator);
         //btnSignin.Click();
      //}

      public void ClickEditLanguageButton()
      {
      wait.Until(ExpectedConditions.ElementToBeClickable(btnEditLanguageLocator)).Click();
      }

      public void EditLanguage(string oldLanguage,string newLanguage, string newLevel)
      {

       WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
       try{
         wait.Until(ExpectedConditions.ElementIsVisible(txaEditLanguageLocator)); 
       IWebElement txaEditLanguage = driver.FindElement(txaEditLanguageLocator);
       txaEditLanguage.Clear();
       txaEditLanguage.SendKeys(newLanguage);

       wait.Until(ExpectedConditions.ElementIsVisible(ddlEditLanguageLevelLocator));
       IWebElement ddlEditLanguageLevel = wait.Until(ExpectedConditions.ElementIsVisible(ddlEditLanguageLevelLocator));
       SelectElement select = new SelectElement(ddlEditLanguageLevel);
       select.SelectByText(newLevel); 

       wait.Until(ExpectedConditions.ElementIsVisible(btnUpdateLanaguageLocator));
       IWebElement btnUpdateLanaguage = driver.FindElement(btnUpdateLanaguageLocator);
      btnUpdateLanaguage.Click();

       }

       catch(WebDriverTimeoutException ex){
            Console.WriteLine("Timeout waiting for element: " + ex.Message);
       }
       //wait.Until(ExpectedConditions.ElementIsVisible(txaEditLanguageLocator)); 

       //IWebElement txaEditLanguage = driver.FindElement(txaEditLanguageLocator);
       //txaEditLanguage.Clear();
       //txaEditLanguage.SendKeys(newLanguage);

       //IWebElement ddlEditLanguageLevel = wait.Until(ExpectedConditions.ElementIsVisible(ddlEditLanguageLevelLocator));
       //SelectElement select = new SelectElement(ddlEditLanguageLevel);
       //select.SelectByText(newLevel); 


      //IWebElement btnUpdateLanaguage = driver.FindElement(btnUpdateLanaguageLocator);
      //btnUpdateLanaguage.Click();

       }

       public bool IsLanguageEditMessageDisplayed(){
         try{
            wait.Until(ExpectedConditions.ElementIsVisible(languageEditMessageLocator));
             return true;
         }

         catch(WebDriverTimeoutException){
            return false;
         }
       }

       public void ClickOnTheSignOutButton()
      {
         WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); // Increase the wait time if needed
         wait.Until(ExpectedConditions.ElementIsVisible(btnSignOutlocator));

         IWebElement btnSignin = driver.FindElement(btnSignOutlocator);
         btnSignin.Click();
      }

      public void ClickDeleteLanguageButton()
       {
       wait.Until(ExpectedConditions.ElementToBeClickable(btnDeleteLanguageLocator)).Click();
      IWebElement button = wait.Until(ExpectedConditions.ElementIsVisible(btnDeleteLanguageLocator));
      wait.Until(ExpectedConditions.ElementToBeClickable(btnDeleteLanguageLocator)).Click();
       }

       public bool IsLanguageDeleteMessageDisplayed(){
         try{
         wait.Until(ExpectedConditions.ElementIsVisible(LanguageDeleteMessageLocator));
           return true;
         }

         catch(WebDriverTimeoutException){
            return false;
         }
       }



              public void AddSkill(string skill, string level)
              {
                  IWebElement tabSkill = driver.FindElement(tabSkillLocator);
                  tabSkill.Click();

                  //Identify Add new button under skill tab and click on it
                   IWebElement btnAddNewSkill = driver.FindElement(btnAddNewSkillLocator);
                  btnAddNewSkill.Click();

                  //Identify add skill field and enter a skill
                  IWebElement txaSkill = driver.FindElement(txaSkillLocator);
                   txaSkill.SendKeys(skill);

                   //Identify Choose skill level field and select a skill level
                  IWebElement ddlChooseSkillLevel = driver.FindElement(ddlChooseSkillLevelLocator);
                  SelectElement select = new SelectElement(ddlChooseSkillLevel);
                   select.SelectByText(level);

                  //Identify add button and click on it
                   IWebElement btnAddSkill = driver.FindElement(btnAddSkillLocator);
                  btnAddSkill.Click();

               }

               public bool IsSkillAddingMessageDisplayed(){
                  try{
                     wait.Until(ExpectedConditions.ElementIsVisible(SkillAddingMessageLocator));
                     return true;
                  }

                  catch(WebDriverTimeoutException){
                     return false;
                  }
               }

               public bool IsDuplicateSkillErrorMessageDisplayed(){

                  try{
                     wait.Until(ExpectedConditions.ElementIsVisible(DuplicateSkillErrorMessageLocator));
                     return true;
                  }

                  catch(WebDriverTimeoutException){
                     return false;
                  }
               }

              public void EditSkill(string oldSkill, string newSkill, string newLevel)
             {

               IWebElement tabSkill = driver.FindElement(tabSkillLocator);
               tabSkill.Click();
              wait.Until(ExpectedConditions.ElementToBeClickable(btnEditSkillLocator)).Click();

               //IWebElement btnEditSkill = driver.FindElement(btnEditSkillLocator);
               //btnEditSkill.Click();

                   //Identify skill field and edit it
                  IWebElement txaEditSkill = driver.FindElement(txaEditSkillLocator);
                   txaEditSkill.Clear();
                   txaEditSkill.SendKeys(newSkill);

                   //Identify skill level field and edit
                   IWebElement ddlEditSkillLevel = driver.FindElement(ddlEditSkillLevelLocator);
                   SelectElement select = new SelectElement(ddlEditSkillLevel);
                   select.SelectByText(newLevel);

                   //Identify update button and cick on it
                   IWebElement btnUpdateSkill = driver.FindElement(btnUpdateSkillLocator);
                  btnUpdateSkill.Click();
               }

               public bool IsEditSkillMessageDisplyed(){
                  try{
                     wait.Until(ExpectedConditions.ElementIsVisible(EditSkillMessageLocator));
                     return true;
                  }

                  catch(WebDriverTimeoutException){
                     return false;
                  }
               }

              public void DeleteSkill()
              {
                  IWebElement tabSkill = driver.FindElement(tabSkillLocator);
                  tabSkill.Click();
                   //IWebElement btnDeleteSkill = driver.FindElement(btnDeleteSkillLocator);
                   //btnDeleteSkill.Click();
                    wait.Until(ExpectedConditions.ElementToBeClickable(btnDeleteSkillLocator)).Click();
                    IWebElement btnDeleteSkill = wait.Until(ExpectedConditions.ElementIsVisible(btnDeleteSkillLocator));
                    wait.Until(ExpectedConditions.ElementToBeClickable(btnDeleteSkillLocator)).Click();

              }

              public bool IsDeleteSkillMessageDisplayed(){
               try{
                  wait.Until(ExpectedConditions.ElementIsVisible(DeleteSkillMessageLocator));
                  return true;
               }

               catch(WebDriverTimeoutException){
                  return false;
               }
              }
   }
}