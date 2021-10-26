Feature: LoginFailed
	Simple calculator for adding two numbers

@mytag
Scenario: Login failed QA
	Given QA enviroment LoginFailed 
	And  Find the text box to enter the Email and Password
	When Fill the fields Email and Password
	| Email                      | Password      |
    | mariae@gmail.com           |   Abc123      |         
	And Click on Enter Button
	And Click on Lost Your Password
	And Fill the Email
	And Click on Send Email
	And Get Email Link
	And Go to Email Link 
	And Fill the security question
	And Click on Next Button
	And Then Click on Reset Password
	Then Show again QA enviroment 