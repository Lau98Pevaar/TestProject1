Feature: Register
	Registration in QA

@mytag
Scenario: Login in QA
	Given QA enviroment login
	When Select Button Register
	Then Find the text box to enter the name, last name and email 
	When Fill this fields
		| Name     | LastName   | Email                     |
		| marain   | conde      | mariconde@gmail.com    |
	Then Find the Speciality dropdown 

	When  Select the Speciality 
    Then Find the Rol dropdown 
	When  Select the Rol
    And  Select Next button
	Then Find the location dropdown 
	When  Select the location
	Then Find the Market Areas dropdown
	When  Select the Market Areas
	Then Find the Region dropdown
	When  Select the Region
    And Select Next button location


	Then Find the text box Password 
	Then Find the text box confirm password
	Then Find the text box Security Answer A
	Then Find the text box Security Answer B
	Then Find the text box Security Answer C
	And  Select Next button Security
	And  Move the update switch
	And  Select the policy and privacy link
	And  Select close button policy and privacy link
	And  Select the terms and conditions link
	And  Select close button terms and conditions link
	And  Move the documents switch
	And  Select Next button comunication preferences
	Then Shows the successful title
	And  Select Next button redirect to login