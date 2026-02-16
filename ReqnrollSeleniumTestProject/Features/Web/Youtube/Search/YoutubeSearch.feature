Feature: Youtube search feature

Search for Might and Magic on Youtube

Background: 
	Given I open the Youtube

@web
Scenario: Search for Might and Magic 8
	When I search for "Might and Magic 8"
	Then Search results page is opened

@web
Scenario: Search for Might and Magic 7
	When I search for "Might and Magic 7"
	Then Search results page is opened
	When I click Youtube logo
	Then Search results page is absent