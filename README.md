# Games-Assignment-3

## Green

1. In your flight simulator game you made in assignment 2, you must make the following improvements:
    - Use a coroutine to make the powerups sometimes move, and sometimes stand still for a while. The movement of the powerup should not be physics(Rigidbody/force) based.
    - Use a a tweening library to animate the score counter in the UI every time a point is scored. The animation could be a rapid expansion and deflation of size, or a shake, or both. This shows the user that something has happened in the UI.
2. In your racing car game from assignment 2, make a timer, so that the player can run out of time. The player gains more time by driving over the ramps and hitting invisible triggers on the ramps. The countdown timer must be visible on the screen.
3. Make the enemies in your third person shooter rotate around themselves.
4. Prep your project for GIT and upload to Github. paste URL here: https://docs.google.com/spreadsheets/d/1rekEFkgqSKu9matm9qia9eLW68W9Ph06gJIoglDCJ68/edit#gid=0

## Yellow

1. Make your code safer and more durable and less error prone, by checking if required components are
available or using RequiredComponent tag, and by checking for null if you search for GameObjects.
2. Try to use the Unity Animator instead of tweening other ways

## Red

1. Don’t tween using a library, make your own static class which can take any GameObject as a parameter for
one of its many methods, and tween it. Use Lerp and MoveTowards and other relevant methods to make
multiple tween types available. 
