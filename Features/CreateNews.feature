Feature: CreateNews
	Create news for Learning Hub

@mytag
Scenario: Create news in QA
	Given QA enviroment login
	And  Find the text box to enter the Email, Password
	When Fill the fields
	|         Email            |       Password       |
    | laura.moreno@pevaar.com  |   Stephany091098     |
	And  Move the remember me switch
	And  Select Next button login
	And Switch to admin
	| UserType |
	|  Admin   |
	And Select News component
	And Create a new article
	And Fill all fields about News
	And Save and Publish the article
	Then Display the article in the news table