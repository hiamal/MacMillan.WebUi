
Feature: Window Page Tests

Scenario: Open a new Tab
    Given I'm on the Window Page
    When I click on the 'New Tab' button
    Then I see 'This is a sample page' in a new window

Scenario: Open a new Window
    Given I'm on the Window Page
    When I click on the 'New Window' button
    Then I see 'This is a sample page' in a new window

@ignore
Scenario: Open a new Window message
    Given I'm on the Window Page
    When I click on the 'New Window Message' button
    Then I see 'Knowledge increases by sharing but not by saving.' in a new window