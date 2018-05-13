﻿Feature: UserServiceAddUser
 	AIn order to use the system
	I want to add myself as a new user to the system

@addBasicUser
Scenario: SuccessfulAddUser
	Given I have a valid database connection
	Given I have an instance of UserService
	Given I have created a user for AddUser
	When I use the AddUser function
	Then I should be added as a new user
