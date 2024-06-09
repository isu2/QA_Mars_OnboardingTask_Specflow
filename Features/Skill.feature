Feature: Skill Management

Background:
    Given I am on the login page by clicking Sign In button
    When I enter username "isurikaperera100@gmail.com" and password "$h!xHnDypG"
    And I click on the Login button
    Then I am able to sign in to the profile page

Scenario Outline: Manage add Skill details in Profile page
    Given I am on the profile page
    When I add a skill "<skill>" and level "<level>"
    Then I am able to see the skill record adding success message
    And I sign out

 Examples: 
    | skill    | level        |
    | Java     | Expert       |
    | Selenium | Intermediate |  

Scenario Outline: Verify that the application is not allowed to enter duplicate skill records
    Given I am on the profile page
    When I add a skill "<skill>" and level "<level>"
    Then I am able to see an error message relevant to the duplicate skill records
    And I sign out  

  Examples: 
   | skill    | level        |
   | Java     | Beginner     |

Scenario Outline: Manage Edit Skill details in Profile page
Given I am on the profile page
When I edit the skill "<oldSkill>" to new name "<newSkill>" and new level "<newLevel>" 
Then I am able to see that the relevant skill record has been updated succesfully 
And I sign out 

 Examples: 
 |oldSkill    | newSkill    | newLevel       |
 | Java       | Java Coding | Intermediate   |

Scenario Outline: Manage delete Skill details in Profile page
 Given I am on the profile page
 When I delete the skill "<skill>" and level "<level>"
 Then I am able to see the relevant skill record has been deleted
 And I sign out

 Examples:
 | skill      | level       |
 | Selenium   | Intermediate|

 

