
Feature: Button Page Tests

Scenario: Click on 'Click Me' button and verify the message
    Given I'm on the Button Page
    When I click on the Click Me button
    Then I see a text 'You have done a dynamic click'