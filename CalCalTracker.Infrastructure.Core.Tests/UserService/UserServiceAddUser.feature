Feature: UserServiceAddUser
 	AIn order to use the system
	I want to add myself as a new user to the system

@addBasicUser
Scenario: AddBasicUser
	Given I have created a basic user
	When I use the AddUser function
	Then I should be added as a new user
