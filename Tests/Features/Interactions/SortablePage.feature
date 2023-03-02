@ignore
Feature: Sortable Page Tests

Scenario: Sort the list items in descending order
    Given I'm on the Sortable Page
    When I arrange the items in descending order
    Then The list is sorted in descending order