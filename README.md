# CS410_Assgn2

## Linear Interpolation - Jacob Kolster

To integrate linear interpolation I added a compass, that points the character towards the end of the game. In doing so I added the `CompassDirection` script that appears in Assets/UnityTechnologies/3DBeginner/Scripts, which fluidly animates the rotation of the compass,
and manipulated the `GameEnding` script in same directory, such that the compass would fade away when the game ends. In creating the compass graphic I added a game object `Compass` located under the `Fader Canvas` UI, and added two compass PNGs located in Assets/UnityTechnologies/3DBeginner/Textures/UI.

When implementing linear interpolation within the `CompassDirection` script, I took the vector between the player and the finish line, and calculated its signed angle with the vector <0,1> (pointin up). The result of this is the direction that the compass should point, hence I use `Quaternion.Lerp()` with `Time.deltaTime` to slowly push the compass towards this dynamic direction. All of my calculations are done in FixedUpdate to limit unecessary computation.