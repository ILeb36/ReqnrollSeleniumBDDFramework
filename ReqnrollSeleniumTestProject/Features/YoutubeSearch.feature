Feature: Youtube search feature

Search for Testers Talk on Youtube

Background: 
	Given I open the Youtube

@TestersTalk
Scenario: Search for Testers Talk
	When I search for the Testers Talk
	Then Search result page is opened

	@TestersTalk
Scenario: Search for Testers Talk 2
	When I search for the Testers Talk
	Then Search result page is opened
