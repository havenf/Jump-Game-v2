CHANGELOG - 02/24/24:

- Second version created to better suit the effort at hand
- Previous version had scripts used to get the project started dealing with camera settings

- New v2 contains the follwing changes and updates
    - Individual movement scripts for player one and player two
        - use of keycode recognition
        - Player one can jump
        - player two is unable to jump
        - player one is too tall to hide under terrain
        - player two is short enough to hide under terrain
        - player one moves faster by ratio of 5:3
        - player two moves slower by ratio of 3:5
        - player two's raycast detects if hiding under terrain for too long 
            - player is then placed back out form under terrain

        * This is to create two separate efforts in winning the game, two roles that require different strategy.


    - Scoring Manager added to reflect previous version's scoring system
        - player one loses points over time in 1:5 ratio
        - Player two gains points over time in 5:1 ratio
            - for every .001 point player one loses over time, player two gains .005
        - player one only gains points by jumping over player two
        - player two only gains points by enduring time


    - UI updates 
        - Player one and two score in blue and red are displayed and updated on screen
        - winning player displays respectively upon reaching 1000

    - Scene Manager script added to introduce end-of-game logic and scene changes

CHANGELOG - 03/01/24

- Added PlayerManager script
    - maintains player state 

- Added Key script

- Added InventoryManager script
    - Manages inventory items

- Added MainManager script
    - Manages all scripts dealign with inventory and items

- Added Collectible Item script
    - Script that destroys gameObject upon collision

- Added ManagerStatus script
    - Desplays status of the manager script

- Added IGameManager script
    - Enumerator status script
    
- Added Basic UI script
    - Creates and updates UI related to inventory system

- Script debugging and hierarchy organization in current project in progress 

CHANGELOG - 03/08/24

- Removed current scoring system.

- Terrain and objects rearranged to represent a course.

- Both players now have the same movement speed and jump height.

- Player one is heavier than player two by 5:1.

- New map features a course that requires two players to get to the end.

- Control panels are placed throughout the new map that players must help each other get to.
        -     Using the control panels (currently in theory, not in practice) for player one extends a bridge to a collectible.
        -     Player two control panel raises and lowers an elevator (in theory).
        -     The collectible (a coin), upon being collected (in theory, not practice) ends the game.

- New jointed objects as a part of the map contribute to the course experience.
        -     Players must balance their character and work with each other.

- Script added to rotate and destroy collectible upon collision.
        -     Rotation added to indicate where the collectible object is.

- Control panel script added to detect proximity of players within distance and features an isPlayerOne boolean
        -     Control panel button script added for player one to control bridge (currently debugging)
