Feature: Checkout
	In order to use all functionalities
	As a user
	I want to be able to search for a product and procced to checout

@Checkout
Scenario: User can search for a product and add it to the cart
    Given user enters a DRESS search term
    And user submits the search
    And opens first product from the list
    When user clicks on add to cart button
    And user proceeds to checkout
    Then cart page is opened
