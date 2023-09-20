using System.Drawing;
namespace levelup
{
    public class GameController
    {
        // TODO: Is this what you want your default character name to be?git c
        public readonly string DEFAULT_CHARACTER_NAME = "Character";
         public readonly string DEFAULT_PLAYER_NAME = "Player1";
        public readonly string myName= "Quincy";

        public record struct GameStatus(
            // TODO: Add other status data
            string characterName,
            string playerName,
            Point currentPosition
        );

        // TODO: Ensure this AND CLI commands match domain model
        public enum DIRECTION
        {
            NORTH, SOUTH, EAST, WEST
        }

        GameStatus status = new GameStatus();

        public GameController()
        {
            status.characterName=DEFAULT_CHARACTER_NAME;
            status.playerName = DEFAULT_PLAYER_NAME;
            //set current position to a nonsense place
            status.currentPosition = new Point(-1,-1);
        }

        // Pre-implemented to demonstrate ATDD
        public void CreateCharacter(String name)
        {
            if (name != null && !name.Equals(""))
            {
                this.status.characterName = name;
            }
            else
            {
                this.status.characterName = DEFAULT_CHARACTER_NAME;
            }
        }

        public void StartGame()
        {
            // TODO: Implement startGame - Should probably create positions and put the character
            // on them?
            // TODO: Should also update the game status?
        }

        public GameStatus GetStatus()
        {
            return this.status;
        }

        public void Move(DIRECTION directionToMove)
        {
            //TODO: Implement move - should call something on another class
            //TODO: Should probably also update the game status
        }
        public void SetCharacterPosition(Point coordinates)
        {
            //TODO
        }



    }
}
