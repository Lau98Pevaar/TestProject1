Feature: Register
	Register in QA

@mytag
Scenario: Register in QA
	Given QA enviroment login
	And Register button exists
	When Click the register button
	And Fill all fields about personal information

	| Name     | LastName   | Email                   |
	| Test     | Autom      | detrimotri3@vusra.com   |

	And Click on the first Next button
	And Fill all fields about location
	And Click on the second Next button
	And Fill all fields about security
	| Password | AnswerA | AnswerB | AnswerC |
	| Abc123   | Answer  | Answer  | Answer  |
	And Click on the third Next button
	And Select language, read all and click on both switches for comunication
	And Click on the fourth Next button
	And Click login button at register successfull page 
	Then Shows Login page
	