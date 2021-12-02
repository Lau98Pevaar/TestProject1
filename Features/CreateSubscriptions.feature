Feature: CreateSubscriptions
	Create subscription in LH

@CreateSubs
Scenario: Create subscriptions
	Given QA enviroment login
	And  Find the text box to enter the Email, Password
	When Fill the fields
	|        Email                    | Password      |
    |	mortohakku@vusra.com          |   Abc123      |
	And  Move the remember me switch
	And  Select Next button login
	And Switch to admin
	| UserType |
	| Admin    |
	And Select Subscriptions Component
	And Create a new Subscription
	And Fill all fields about Subscriptions
	And Save and Publish the Subscription
	Then Display the Subscription in the Subscriptions table
   