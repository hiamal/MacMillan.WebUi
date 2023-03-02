
Feature: Web Table Tests

Scenario: Edit email for Alden
    Given I'm on the Table Page
    When I click Edit button in row Alden
    And I enter email as 'alden@newEmail.com'
    Then The email is updated