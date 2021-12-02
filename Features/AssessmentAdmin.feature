Feature: AssessmentAdmin
   Creation of Assessment

@mytag
Scenario: Creation of Assessment
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
	And Select Assessment Component
	And Select Assessment set
	And Select New Assesment
	And Fill the title and date fields
	And Choose the type of assessment
	| AssessmentType | TriviaType    |
	| Trivia         | RapidFire     |
	And Fill all text boxes
	And Complete the form
    Then Shows the Assessment
	