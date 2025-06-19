Feature: Test2

A short summary of the feature

@tag1
Scenario: User will Input Duplicated username in Register Page
	Given User will navigate to the URl
	When If user will input duplicated username that is already exist , it will give an error
	Then The page will closed
