Feature: Test3

A short summary of the feature

@tag1
Scenario: User will empty the fields of Registerpage and click Register , it will show Errors
	Given User will navigate to Url
	When If user will leave the field empty and click register button it will show errors
	Then page closed
