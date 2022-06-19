# Tic-Tac-Toe
##Tic Tac Toe Kata documentation (game development using C#)

Assumptions/detail procedure:
The entire development is based upon modular coding (function) which are as follow:

•	Board Initialization function:
This function is based on the initialization of board (grid) of the game which is a 3x3 two-D array with default empty values.


•	Printboard():
This function is used to show the content of the matrix fill with value(s).


•	ChangeTurn():
In order to change the turn as by default start is player “X” and for 2nd turn the user should be change which is “O”, such function is used to change the player turn after every step.


•	WinningCondition():
There are total 8 wining possibilities to check whether the Player has won the game or no by mean of 3-horezontol consecutive matching condition for the single player, 3-vertical consecutive matching condition for a single player and similarly the same for both “left-right” and “right-left” diagonal condition.

•	CheckMarked():
In order to block the player from the entry over the place where there already has an entry by either of player, this function checks that location before entry.

•	GamePlay():
Is a type of callback function which call all the above function in a proper manner to accomplish the tic-tac-toe game. 
