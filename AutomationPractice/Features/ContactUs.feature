Feature: ContactUs
In order to use all functionalities
	As a user
	I want to be able to contact customer service and sent a message

	@ContactUs
	Scenario: User can open page and send a message
	Given user opens Contact us page
	And user enter all mandatory fields
	When user clicks on Send button
	Then Green message is dispayed