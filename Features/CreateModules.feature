Feature: CreateModules
	Create a module

@mytag
Scenario: Create modules
	Given QA enviroment login
	And  Find the text box to enter the Email, Password
	When Fill the fields
	|         Email            |       Password       |
    | admin@admin.com  |   Abc123*     |
	And  Move the remember me switch
	And  Select Next button login
	
	And Switch to admin
	| UserType |
	|  Admin   |
	And Select Learn Component
	And Select modules and create new
	And Fill all text boxes about this module
	And Add test out
	And Create sections and Add actions
	And Upload a cover image 
	And Save and Publish the module
	Then Shows the module's table.