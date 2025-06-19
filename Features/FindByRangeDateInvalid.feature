Feature: TestC2

A short summary of the feature

@tag1
Scenario: User will input date format wrong on the field of Find date range on the find transactions page
	Given User will be navigate to url
	When If user will input wrong date format on the field of Find date range , it will give error
	Then Page will be closed
