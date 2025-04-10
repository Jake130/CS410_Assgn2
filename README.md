# CS410_Assgn2

CS 410: Nick Johnson, Jake Kolster, Jason Webster, Nathan Cook



# Dot Product - Nick Johnson

The feature implemented to utilize the dot product is the visibility bar that is shown at the bottom of the screen while the game is 
running. Generally, the code calculates the vector defining where an enemy is facing and relates that to the vector from the enemy to the player, finding the relation between the two. The smaller the angle between the two vectors, the more filled the visibility bar is. Alongside this, the visibility bar also takes into account the distance the player is from the ghost/gargoyle in order to make a more accurate depiction of their danger level. 

More specifically, this is programmed mainly within the two scripts EnemyVisibility.cs and VisibilityUI.cs. EnemyVisibility is where the vectors are gathered and the dot product is created, as well as the actual visibility value. VisibilityUI translates these values into how filled the bar should be.

# Particle Effects - Nathan Cook

For this project, I added a simple smoke particle effect that activates when the player enters the dining room in John Lemon’s Haunted Jaunt. I began by creating a custom Particle System in Unity and adjusted its settings to resemble light gray smoke—fading out over time and gently rising. I disabled “Play on Awake” so the smoke wouldn’t appear immediately at the start of the game, then positioned the effect in a key location to create atmospheric tension when entering the space.

To trigger the smoke effect, I created an empty GameObject named RoomTrigger and added a Box Collider set as a trigger. I wrote a custom C# script that listens for the player entering the collider, and when triggered, calls the .Play() method on the Particle System. I assigned the smoke effect through the Unity Inspector and ensured the player had the correct tag and collider setup for detection. After debugging, I confirmed the smoke effect plays seamlessly as the player crosses into the room.
