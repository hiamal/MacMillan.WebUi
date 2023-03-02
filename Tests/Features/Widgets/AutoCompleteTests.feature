#@ignore
Feature: Auto-complete Page Tests

Scenario: Add multiple colour names to the multiple auto-complete box
    Given I'm on the Auto-Complete Page
    When I add colours Blue and Green to the multiple auto-complete box
    Then The colours are successfully entered in the multiple auto-complete box

Scenario: Add a colour name to the single auto-complete box
    Given I'm on the Auto-Complete Page
    When I add the colour 'Red' to the single auto-complete box
    Then The colour is successfully entered in the single auto-complete box