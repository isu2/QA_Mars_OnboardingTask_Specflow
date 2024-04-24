Feature: Profile Management

Background:
    Given I am on the home page
    When I click on the sign-in button
    And I enter the username "user@example.com" and password "password123"
    Then I click the login button

Scenario: Manage Profile
    Given I click on the "Add New Language" button
    When I add a new language "Spanish" with level "Fluent"
    Given I click on the "Edit Language" button
    When I edit the language "Spanish" to "French"
    Given I click on the "Delete Language" button