
Feature: Tool Tip Page Tests

Scenario: Open an alert with a prompt box
    Given I'm on the ToolTip Page
    When I hover over the Hover me button
    Then I see tooltip text 'You hovered over the Button'