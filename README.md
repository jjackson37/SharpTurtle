# SharpTurtle

[![Build Status](https://travis-ci.org/jjackson37/SharpTurtle.svg?branch=master)](https://travis-ci.org/jjackson37/SharpTurtle)

*Windows forms line based drawing program, written in C#*
## Features
* Manual drawing with forward and backward buttons with editable distance and angle to travel, togglable drawing, and changable color.
* Command line drawing that causes the program to draw depending on entered commands.
* Supports dragging and droping text files into the command line to execute commands written inside it also.

## Commands

### Syntax
The syntax of commands for the program are to give the command then the value for the command in brackets, commands are seperated by a semicolon. Examples are as follows:
```
Command1(value);Command2(value);Command3(value)
Pen(true);Forward(10);Right(10):Forward(10);Pen(False)
pen(true);forward(50);pen(false);forward(50);pen(true);forward(50)
```
*Commands are not case sensitive*
### Command list
|Command|Syntax|Function|
|---|---|---|
|Forward/Backward|Forward(distance)/Backward(distance)|Moves the pointer forward/backward by a specified amount|
|Right/Left|Right(angle)/Left(angle)|Turns the pointers direction to draw the next line at by a specified angle|
|Pen|Pen(true/false)|Sets if the program is drawing or not|

## UI Screenshot
![SharpTurtle UI Screenshot](http://i.imgur.com/BHyPZoK.png "SharpTurtle UI")
