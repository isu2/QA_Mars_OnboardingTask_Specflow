Feature: Sign In Process

  As a user
  I want to navigate to the sign-in page from the home page and log into the application.

  Scenario: Successful Navigation and Login
    Given I am on the home page
    When I click on the sign-in button
    And I enter the username "user@example.com" and password "password123"
    Then I click the login button