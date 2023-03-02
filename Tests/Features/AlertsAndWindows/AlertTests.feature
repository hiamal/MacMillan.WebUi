
Feature: Alert Page Tests

Scenario: Open an alert with a prompt box
    Given I'm on the Alerts Page
    When I click on the prompt box button
    Then I can enter text 'sample text' into the alert
    And I can accept the alert
    And I can see 'sample text' in the prompt result