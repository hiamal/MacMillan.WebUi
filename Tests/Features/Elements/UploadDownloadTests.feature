
Feature: Upload Download Page Tests

Scenario: Upload a file
    Given I'm on the Upload Download Page
    When I click on the Download button
    Then A 'sampleFile.jpeg' file is downloaded to downloads folder

Scenario: Download a file
    Given I'm on the Upload Download Page
    When I upload the 'sampleFile.jpeg' file
    Then I see the 'SampleFile' path after the upload