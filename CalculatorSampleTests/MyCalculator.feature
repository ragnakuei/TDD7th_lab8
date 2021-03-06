﻿Feature: MyCalculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Add two numbers
	Given 在第一個輸入項輸入 50
	And 在第二個輸入項輸入 70
	When 按下 Add 按鈕
	Then 螢幕上的結果應為 120

Scenario: Add two numbers，有負數
	Given 在第一個輸入項輸入 50
	And 在第二個輸入項輸入 -70
	When 按下 Add 按鈕
	Then 螢幕上的結果應為 -20

Scenario: 兩個浮點數字相加，結果含小數點
	Given 在第一個輸入項輸入 50.1
	And 在第二個輸入項輸入 70.1
	When 按下 Add 按鈕
	Then 螢幕上的結果應為 120.2
