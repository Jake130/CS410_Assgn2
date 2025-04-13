# CS410_Assgn2

CS 410: Nick Johnson, Jake Kolster, Jason Webster, Nathan Cook



# Dot Product - Nick Johnson

The feature implemented to utilize the dot product is the visibility bar that is shown at the bottom of the screen while the game is 
running. Generally, the code calculates the vector defining where an enemy is facing and relates that to the vector from the enemy to the player, finding the relation between the two. The smaller the angle between the two vectors, the more filled the visibility bar is. Alongside this, the visibility bar also takes into account the distance the player is from the ghost/gargoyle in order to make a more accurate depiction of their danger level. 

More specifically, this is programmed mainly within the two scripts EnemyVisibility.cs and VisibilityUI.cs. EnemyVisibility is where the vectors are gathered and the dot product is created, as well as the actual visibility value. VisibilityUI translates these values into how filled the bar should be.

# Particle Effects - Nathan Cook

For this project, I added a simple smoke particle effect that activates when the player enters the dining room in John Lemon’s Haunted Jaunt. I began by creating a custom Particle System in Unity and adjusted its settings to resemble light gray smoke—fading out over time and gently rising. I disabled “Play on Awake” so the smoke wouldn’t appear immediately at the start of the game, then positioned the effect in a key location to create atmospheric tension when entering the space.

To trigger the smoke effect, I created an empty GameObject named RoomTrigger and added a Box Collider set as a trigger. I wrote a custom C# script that listens for the player entering the collider, and when triggered, calls the .Play() method on the Particle System. I assigned the smoke effect through the Unity Inspector and ensured the player had the correct tag and collider setup for detection. After debugging, I confirmed the smoke effect plays seamlessly as the player crosses into the room.

## Linear Interpolation - Jacob Kolster

To integrate linear interpolation I added a compass, that points the character towards the end of the game. In doing so I added the `CompassDirection` script that appears in Assets/UnityTechnologies/3DBeginner/Scripts, which fluidly animates the rotation of the compass,
and manipulated the `GameEnding` script in same directory, such that the compass would fade away when the game ends. In creating the compass graphic I added a game object `Compass` located under the `Fader Canvas` UI, and added two compass PNGs located in Assets/UnityTechnologies/3DBeginner/Textures/UI.

When implementing linear interpolation within the `CompassDirection` script, I took the vector between the player and the finish line, and calculated its signed angle with the vector <0,1> (pointin up). The result of this is the direction that the compass should point, hence I use `Quaternion.Lerp()` with `Time.deltaTime` to slowly push the compass towards this dynamic direction. All of my calculations are done in FixedUpdate to limit unecessary computation.


# Sound / Audio Effect on trigger - Jason Webster

This feature adds an audio feedback mechanic where the player character, John Lemon, plays a grunt sound upon colliding with environmental objects. The sound effect was sourced from freesound.org and imported into the Unity project under the 3DBeginnerComplete/Audio directory. A dedicated child GameObject named GruntSound was created under the main John Lemon object to hold an AudioSource component, which was assigned the downloaded grunt audio clip. The Play On Awake option was disabled to prevent the sound from playing at scene start. A custom script was attached to John Lemon that detects physical collisions and plays the grunt sound when appropriate. To avoid false triggers, the script includes a list of known floor object names (such as “FloorPlane,” and “Floor_Bathroom”) and ignores collisions with those specific objects. This solution avoids the use of Unity tags or layers to ensure compatibility with the rest of the team’s work and keeps all logic self-contained within the script. The result is a responsive, context-aware audio cue that enhances gameplay without interfering with other systems or assets.
