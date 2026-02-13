Feature: Youtube search feature

Search for Might and Magic on Youtube

Background: 
	Given I open the Youtube

@web
Scenario: Search for Might and Magic 8
	When I search for "Might and Magic 8"
	Then Search result page is opened

@web
Scenario: Search for Might and Magic 7
	When I search for "Might and Magic 7"
	Then Search result page is opened
	And Scenario is failed for testing purpose
	When I search for "Might and Magic 7"
