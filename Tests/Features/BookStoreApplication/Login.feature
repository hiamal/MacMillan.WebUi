
Feature: Login Page Tests

Scenario: When I use the correct credentials I can login successfully
    Given I'm on the Login Page
    When I login using the correct username and password
    Then I'm logged in successfully

Scenario: When I use the incorrect credentials I am unable to login
    Given I'm on the Login Page
    When I login using the incorrect username and password
    Then I get an 'Invalid username or password!' error

Scenario: When I use the incorrect username I am unable to login
    Given I'm on the Login Page
    When I login using the incorrect username
    Then I get an 'Invalid username or password!' error

Scenario: When I use the incorrect password I am unable to login
    Given I'm on the Login Page
    When I login using the incorrect password
    Then I get an 'Invalid username or password!' error

Scenario: When I use empty username and password I am unable to login
    Given I'm on the Login Page
    When I login using empty username and password
    Then I'm not logged in

Scenario: When I use empty username I am unable to login
    Given I'm on the Login Page
    When I login using empty username and correct password
    Then I'm not logged in

Scenario: When I use empty password I am unable to login
    Given I'm on the Login Page
    When I login using correct username and empty password
    Then I'm not logged in
