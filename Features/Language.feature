Feature: Language Management 

Background:
    Given I am on the login page by clicking Sign In button
    When I enter username "isurikaperera100@gmail.com" and password "$h!xHnDypG"
    And I click on the Login button
    Then I am able to sign in to the profile page

Scenario Outline: Manage add Language details in Profile page
    Given I am on the profile page
    When I add a language "<language>" and level "<level>"
    Then I am able to see the added language record "<language>" in the table
    And I sign out

Examples: 
    | language | level  |
    | French   | Basic  |
    | English  | Fluent |

Scenario Outline: Verify that the application is not allowed to enter duplicate language records
    Given I am on the profile page
    When I add a language "<language>" and level "<level>"
    Then I am able to see an error message
    And I sign out

 Examples:
   | language | level   |
   | English  | Basic   |  

Scenario Outline: Manage Edit Language details in Profile page
Given I am on the profile page
When I edit the language "<oldLanguage>" to new name "<newLanguage>" and new level "<newLevel>" 
Then I am able to see that the relevant record has been updated succesfully 
And I sign out

 Examples:
   |oldLanguage | newLanguage | newLevel       |
   | French     | Spanish     | Conversational |

 Scenario Outline: Manage delete Language details in Profile page
 Given I am on the profile page
 When I delete the language "<language>" and level "<level>"
 Then I am able to see the relevant record has been deleted
 And I sign out

 Examples: 
  | language | level |
  | English  | Fluent|  


