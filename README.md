# CS410_Assgn2

CS 410: Nick Johnson, Jake Kolster, Jason Webster, Nathan Cook



# Dot Product - Nick Johnson

The feature implemented to utilize the dot product is the visibility bar that is shown at the bottom of the screen while the game is 
running. Generally, the code calculates the vector defining where an enemy is facing and relates that to the vector from the enemy to the player, finding the relation between the two. The smaller the angle between the two vectors, the more filled the visibility bar is. Alongside this, the visibility bar also takes into account the distance the player is from the ghost/gargoyle in order to make a more accurate depiction of their danger level. 

More specifically, this is programmed mainly within the two scripts EnemyVisibility.cs and VisibilityUI.cs. EnemyVisibility is where the vectors are gathered and the dot product is created, as well as the actual visibility value. VisibilityUI translates these values into how filled the bar should be.
