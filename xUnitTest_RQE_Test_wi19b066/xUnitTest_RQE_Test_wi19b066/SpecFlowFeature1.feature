Feature: Cal
	Um Fehler bei der Berechnung trigonometrischer Funktionen zu vermeiden
	Als Kunde
	I want to have a calculator

@mytag
Scenario: sine of a number
	Given the number is 50
	When we take the sine of the number
	Then the result should be 0.766044443
	
Scenario: cosine of a number
	Given the number is 50
	When we take the sine of the number
	Then the result should be 0.6427876

Scenario: tangens of a number
	Given the number is 50
	When we take the sine of the number
	Then the result should be 1.1917535
