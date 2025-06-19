Feature: TestB9

A short summary of the feature

@tag1
Scenario: User will left the find by date range field black on the Find transactions page
	Given User will Navigate to urL
	When If user left the find by date range field blank , it will give error
	Then The Page Will Closed
