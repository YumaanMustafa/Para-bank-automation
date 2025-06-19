Feature: TestB6

A short summary of the feature

@tag1
Scenario: User will input Specail char on the find date field of Find Transaction page
	Given user Will navigate to url
	When If user will input special char on the field of find date , it will give error
	Then the page will closed
