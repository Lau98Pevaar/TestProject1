Feature: ImportUsers
	ImportUsers in QA

@ImportUser
Scenario: ImportUsers in QA
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
	And Select Admin Component 
	And Select User Manager
	And Select Import Users Button
	And Select Upload Button
	And Select Ok Button
    Then Shows page User Manager
