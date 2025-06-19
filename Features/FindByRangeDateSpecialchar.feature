Feature: TestC1

A short summary of the feature

@tag1
Scenario: User will input special character on the find date range Field on the transaction find page
	Given user Will Navigate url
	When If user will input special character on the fied of find date range , it will give error
	Then page will be closed
