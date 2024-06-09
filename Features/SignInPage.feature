Feature: Sign In Process

  As a user
  I want to navigate to the sign-in page from the home page and log into the application.

  Scenario Outline: Successful Login using Valid credentials
    Given I am on the login page by clicking Sign In button
    When I enter username "<username>" and password "<password>"
    And I click on the Login button
    Then I am able to sign in to the profile page

    Examples:
    | username                   | password     |
    | isurikaperera100@gmail.com | $h!xHnDypG   |

  Scenario Outline: Unsuccessful login using invalid credentials
    Given I am on the login page by clicking Sign In button
    When I enter username "<username>" and password "<password>"
    And I click on the Login button
    Then I should see a pop-up to verify email

  Examples:
    | username                   | password     |
    | isurikaperera100@gmail.com | @&amp;$dfsac     |
    | username@gmail.com         | $h!xHnDypG   |
    | username123@gmail.com      | @&amp;$dscazxnmk |

  Scenario Outline: Verify the login function with blank credentails 
  Given I am on the login page by clicking Sign In button
  When I enter username "<username>" and password "<password>"
  And I click on the Login button
  Then I should see an error message near the blank field

  Examples:
   | username                    | password     |
   |                             |              |
