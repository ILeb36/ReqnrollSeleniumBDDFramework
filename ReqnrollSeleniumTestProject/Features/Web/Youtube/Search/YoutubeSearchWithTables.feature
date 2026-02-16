Feature: Youtube Search With Tables

Search for various games on Youtube

Background: 
	Given I open the Youtube

@web
Scenario Outline: Search for various games with Outline
	When I search for "<SearchValue>"
	Then Search results page is opened

	Examples: 
	| SearchValue               |
	| Heroes 2                  |
	| Fallout 2                 |
	| Might and Magic 6 -heroes |

@web
Scenario: Search for various games with DataTable
	Then Search results page is opened for every item in the list
	| SearchValue               | UrlQuery                  |
	| Heroes                    | Heroes                    |
	| Fallout 2                 | Fallout+2                 |
	| Might and Magic 6 -heroes | Might+and+Magic+6+-heroes |
