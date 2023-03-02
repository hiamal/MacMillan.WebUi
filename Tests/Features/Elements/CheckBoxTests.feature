#@ignore
Feature: Checkbox Pages Tests

Scenario: Select Only Documents Checkbox and check results
    Given I'm on the Checkbox Pages
    When I check the Desktop Checkbox
    Then The results pane contains the text desktop

Scenario: Select Desktop And Documents Checkbox and check results
    Given I'm on the Checkbox Pages
    When I check the Desktop And Documents Checkbox
    Then The results pane contains the text desktop
    And The results pane contains the text documents

Scenario: Select Home Checkbox and check if folders under Home are selected as well
    Given I'm on the Checkbox Pages
    When I check the Home Checkbox
    Then The results pane contains the text home
    And The results pane contains the text documents