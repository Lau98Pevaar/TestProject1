Feature: Login
	Login in QA

@login
Scenario: Login in QA

	Given QA enviroment login
	And  Find the text box to enter the Email, Password
	When Fill the fields
	| Email                          | Password      |
    | ruxigu@thecarinformation.com   |   Prueba1#    |
	And  Move the remember me switch
	And  Select Next button login
	And Switch to admin
	| UserType |
	| fghfgh    |
    Then Shows the Dashboard LH

	