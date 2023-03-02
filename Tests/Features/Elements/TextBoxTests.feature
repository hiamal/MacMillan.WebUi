#@ignore
Feature: Textbox Page Tests

Scenario: Empty Outbox Box Shown On Empty Submission
    Given I'm on the Textbox Pages
    When I submit the form
    Then The output box is empty

Scenario: TextBox Entries Are Displayed After Submission
   Given I'm on the Textbox Pages
    When I enter the details in the form
    And I submit the form
    Then The output box contains the details

Scenario: Empty Output Box Shown When Textbox Details Are Cleared
    Given I'm on the Textbox Pages
    When I enter the details in the form
    And I submit the form
    And I clear all the details in the form
    And I submit the form   
    Then The output box is empty
