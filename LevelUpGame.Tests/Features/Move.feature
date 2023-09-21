Feature: Move in a direction
![Gamer](./office-moving-icon1.png)
    I want to move my character. If they attempt to move past a boundary, the move results in no change in position.
    @acceptance
    Scenario Outline: Move in a direction
        Given the character starts at position with XCoordinates <startingPositionX>
        And starts at YCoordinates <startingPositionY>
        And the player chooses to move in <direction>
        When the character moves
        Then the character is now at position with XCoordianates <endingPositionX>
        And YCoordinates <endingPositionY>
        Examples:
            | startingPositionX | startingPositionY | direction | endingPositionX | endingPositionY |
            | 0 | 0 | NORTH | 0 | 1 |
            | 0 | 0 | SOUTH | 0 | 0 |
            | 0 | 0 | EAST | 1 | 0 |
            | 0 | 0 | WEST | 0 | 0 |
            | 0 | 9 | NORTH | 0 | 9 |
            | 0 | 9 | SOUTH | 0 | 8 |
            | 0 | 9 | EAST | 1 | 9 |
            | 0 | 9 | WEST | 0 | 9 |
            | 9 | 9 | NORTH | 9 | 9 |
            | 9 | 9 | SOUTH | 9 | 8 |
            | 9 | 9 | EAST | 9 | 9 |
            | 9 | 9 | WEST | 8 | 8 |
            | 9 | 0 | NORTH | 9 | 1 |
            | 9 | 0 | SOUTH | 9 | 0 |
            | 9 | 0 | EAST | 9 | 0 |
            | 9 | 0 | WEST | 8 | 0 |
            | 5 | 5 | NORTH | 5 | 6 |
            | 5 | 5 | SOUTH | 5 | 4 |
            | 5 | 5 | EAST | 6 | 5 |
            | 5 | 5 | WEST | 4 | 5 |
        