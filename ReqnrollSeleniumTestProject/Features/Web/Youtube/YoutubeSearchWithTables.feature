Feature: Youtube Search With Tables

Search for various games on Youtube

Background: 
	Given I open the Youtube

@web
Scenario Outline: Search for various games with Outline
	When I search for "<SearchValue>"
	Then Search result page is opened

	Examples: 
	| SearchValue               |
	| Heroes 2                  |
	| Fallout 2                 |
	| Might and Magic 6 -heroes |

@web
Scenario: Search for various games with DataTable
	Then Search result page is opened for every item in the list
	| SearchValue               |
	| Heroes 2                  |
	| Fallout 2                 |
	| Might and Magic 6 -heroes |
