@ignore
Feature: Drag And Drop Page Tests

Scenario: Drag And Drop source element to target element
    Given I'm on the Droppable Page
    When I drag the source element onto the target element
    Then The source element is present inside the target element