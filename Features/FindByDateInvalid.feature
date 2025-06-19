Feature: TestB7

A short summary of the feature

@tag1
Scenario: User will input invalid Date formate in the field of find date of the find transaction page
	Given user Will Navigate to url
	When If user will input invalid date formate in the find date field , it will give error
	Then the Page will closed
