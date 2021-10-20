Feature: LoginFailed
	Simple calculator for adding two numbers

@mytag
Scenario: Login failed QA
	Given QA enviroment login G
	Then Find the text box to enter the Email and Password
	| Email                      | Password      |
    | marianaconde@gmail.com     |   Abc123      |         
	Then Click on Enter Button
	And Show Error Message
	Then Click on Lost Your Password
	Given Lost Your Password Page
	Then Fill the Email
	And Click on Send Email
	And Get Email Link
	Then Go to Email Link 
	And Fill the security question
	Then Click on Next Button
	Then Reset Password 
	And Then Click on Reset Password
	Then Go to QA enviroment