Feature: TestC5

A short summary of the feature

@tag1
Scenario: user will left the find amount field empty of Find trasaction page
	Given User Navigate to url
	When If user will left the find amount field empty , it will give an error
	Then page willbe closed
