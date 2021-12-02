Feature: ResourcesAdmin
	Creation of Resource

@mytag
Scenario: Creation of Resource
	Given QA enviroment login
	And  Find the text box to enter the Email, Password
	When Fill the fields
	| Email                          | Password      |
    | ruxigu@thecarinformation.com   |   Prueba1#    |
	And Move the remember me switch
	And Select Next button login
	And Switch to admin
	| UserType |
	| Admin    |
	And Select Resources Component
	And Select Resources
	And Select New Resource
	And Fill the title and date fields form Resource
	And Choose the resource and fill the fields
	| ResourceType |
	| Webinar      |
	Then Shows the Resource