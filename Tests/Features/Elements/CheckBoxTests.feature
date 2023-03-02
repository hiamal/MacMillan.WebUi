#@ignore
Feature: Checkbox Pages Tests

Scenario: Select Only Documents Checkbox and check results
    Given I'm on the Checkbox Pages
    When I check the Desktop Checkbox
    Then The results pane contains the text desktop