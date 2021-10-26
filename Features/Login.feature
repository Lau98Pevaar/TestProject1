Feature: Login
	Login in QA

@login
Scenario: Login in QA

	Given QA enviroment login
	And  Find the text box to enter the Email, Password
	When Fill the fields
	| Email             | Password      |
  | admin@admin.com   |   Abc123*     |

	And  Move the remember me switch
	And  Select Next button login
  Then Shows the Dashboard LH

	