Feature:  Add an item to Wish List	

@mytag
Scenario: Add an item to Wish List
	Given I click on Search Bar and enter the keyword
	Given Select an Item from the Product List
	Given I enter Product details
	When I click on Add to Wish List
	Then The item should Successfully be added to My Wish List