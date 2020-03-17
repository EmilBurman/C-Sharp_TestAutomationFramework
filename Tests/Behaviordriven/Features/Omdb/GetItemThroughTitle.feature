Feature: GetItemThroughTitle
	In order to find the item I want
	As a user of the API
	I want to search by title

@omdb
Scenario: Search movie by title
	Given I have entered the title of the item
	And I have entered that the type is a movie
	When I connect to the API
	Then the response should contain the movie title I searched for

Scenario: Search series by title
	Given I have entered the title of the item
	And I have entered that the type is a series
	When I connect to the API
	Then the response should contain the series title I searched for