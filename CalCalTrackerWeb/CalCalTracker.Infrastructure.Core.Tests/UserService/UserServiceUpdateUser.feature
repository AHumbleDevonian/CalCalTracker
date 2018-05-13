Feature: UserServiceUpdateUser
 	AIn order to use the system
	I want to add myself as a new user to the system

@addBasicUser
Scenario: SuccessfulUpdateUser
	Given I have a valid database connection
	Given I have an instance of UserService
	Given I have created a user for UpdateUser and added it
	When I use the UpdateUser function
	Then the returned user should match the UpdateUser original
