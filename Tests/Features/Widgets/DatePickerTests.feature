#@ignore
Feature: Date Picker Page Tests

Scenario: Verify if user can select a date on the date field
    Given I'm on the DatePicker Page
    When I select the date '28-11-1999' in the date field
    Then I see the date set to '11/28/1999'

Scenario: Verify if user can select a date and time on the date and time field
    Given I'm on the DatePicker Page
    When I select the date '10-10-2021' and time '09:00' in the date and time field
    Then I see the date and time set to 'October 10, 2021 9:00 AM'