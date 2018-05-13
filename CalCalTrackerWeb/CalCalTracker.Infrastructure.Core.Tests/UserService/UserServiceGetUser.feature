Feature: UserServiceGetUser
 	AIn order to use the system
	I want to add myself as a new user to the system

@addBasicUser
Scenario: SuccessfulGetUser
	Given I have a valid database connection
	Given I have an instance of UserService
	Given I have created a user for GetUser and added it
	When I use the GetUser function
	Then the returned user should match the GetUser original
