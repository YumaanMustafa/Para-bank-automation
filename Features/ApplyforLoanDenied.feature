Feature: TestA3

A short summary of the feature

@tag1
Scenario: User Apply for loan if have no funds
	Given user naviagate to URL
	When If user apply for loan if have no funds and input downpayment less it show denied loan
	Then closed the Page
	