Feature: GetRandomCatFact
	In order to keep people happy
	As a common person
	I want to get a random cat fact

@cat
Scenario: Get random cat fact
	Given I have connected through the random endpoint
	And I haven't entered a specfic ID
	When I recieve the response
	Then the result should contain a random cat fact
