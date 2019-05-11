Feature: ContactUs
In order to use all functionalities
	As a user
	I want to be able to contact customer service and sent a message

	@ContactUs
	Scenario: User can open page and send a message
	Given user opens Contact us page
	And user enter mandatory fields Subject Heading and email address
	And user enters 'Dusica Mrksic' message in message box 
	When user clicks on Send button
	Then Message 'Your message has been successfully sent to our team' is present to the user
	