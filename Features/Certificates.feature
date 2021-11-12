Feature: Certificates
	Create a certificate

@mytag
Scenario: Create certificates
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
	And Select Certificates Component
	And Fill all text boxes about certificates
	And Upload logo, background and sognature
	And Save and publish the certificate
	Then Shows the certificates table