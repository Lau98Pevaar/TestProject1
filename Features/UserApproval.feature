Feature: UserApproval
	User Approval by admin

@mytag
Scenario: User Approval
	Given QA enviroment login
	And  Find the text box to enter the Email, Password
	When Fill the fields
	|         Email            |       Password       |
    | laura.moreno@pevaar.com  |   Stephany091098     |
	And  Move the remember me switch
	And  Select Next button login
	And Click on My Profile Menu
	And Switch to admin
	And Select Admin Component 
	And Select User Approvals
	And Search the user recently registered
