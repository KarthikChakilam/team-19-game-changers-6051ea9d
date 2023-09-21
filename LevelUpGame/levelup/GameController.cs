using System.Drawing;
//using System.Console;
//using Enums;
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
       

        GameStatus status = new GameStatus();
        Player player= new Player();
        Position playerPosition= new Position();
        
        public GameController()
        {
            status.characterName=DEFAULT_CHARACTER_NAME;
            status.playerName = DEFAULT_PLAYER_NAME;
            //set current position to a nonsense place
            status.currentPosition = new Point(-1,-1);
             playerPosition = new Position { X = 0, Y = 0 };
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
            SetInitialPosition();
            Console.WriteLine("Game Started"); //TODO Customize 
        }

        public void SetInitialPosition()
        {
            //var position = new Position { X = 0, Y = 0 };
            status.currentPosition=new Point(0,0);
        }

// TODO : Move this to Show Summary instead of struct status 
        public GameStatus GetStatus()
        {
            return this.status;
        }

        public void Move(Enums.DIRECTION directionToMove)
        {

            //TODO: Implement move - should call something on another class
            //TODO: Should probably also update the game status
            //var position=new Position();
            if(directionToMove==Enums.DIRECTION.NORTH)
            {
                //position.Y++;
                 if (playerPosition.Y > 0)
                    {
                        playerPosition.Y++;
                        player.MoveCount++;
                    }
                else
                {
                    playerPosition.Y=playerPosition.Y++;
                    player.MoveCount++;
                }
                status.currentPosition=new Point(playerPosition.X,playerPosition.Y);
                Console.WriteLine(status.currentPosition.X + "is for X and" + status.currentPosition.Y+ "is for Y");
                Console.WriteLine("I have moved North");
                SetCharacterPosition(playerPosition);
            }
            if(directionToMove==Enums.DIRECTION.SOUTH)
            {
                 if (playerPosition.Y < 10 && playerPosition.Y>0)
                    {
                        playerPosition.Y--;
                        player.MoveCount++;
                    }
                else
                {
                    playerPosition.Y=playerPosition.Y;
                    player.MoveCount++;
                }
                status.currentPosition=new Point(playerPosition.X,playerPosition.Y);
                 Console.WriteLine(status.currentPosition.X + "is for X and" + status.currentPosition.Y+ "is for Y");
            }
             if(directionToMove==Enums.DIRECTION.WEST)
            {
                 if (playerPosition.X>0)
                    {
                        playerPosition.X--;
                        player.MoveCount++;
                    }
                else
                {
                    playerPosition.X=playerPosition.X;
                    player.MoveCount++;
                }
                status.currentPosition=new Point(playerPosition.X,playerPosition.Y);
                 Console.WriteLine(status.currentPosition.X + "is for X and" + status.currentPosition.Y+ "is for Y");
            }
            if(directionToMove==Enums.DIRECTION.EAST)
            {
                 if (playerPosition.X<10)
                    {
                        playerPosition.X++;
                        player.MoveCount++;
                    }
                else
                {
                    playerPosition.X=playerPosition.X;
                    player.MoveCount++;
                }
                status.currentPosition=new Point(playerPosition.X,playerPosition.Y);
                 Console.WriteLine(status.currentPosition.X + "is for X and" + status.currentPosition.Y+ "is for Y");
            }
        }
        public void SetCharacterPosition(Position coordinates)
        {
            //TODO
           //Console.SetCursorPosition(coordinates.X,coordinates.Y);
           //new Point(0,1);
            playerPosition.X=coordinates.X;
            playerPosition.Y=coordinates.Y;
           //var newPosition= new Position();
           //newPosition.X=coordinates.X;
           //newPosition.Y=coordinates.Y;
           Console.WriteLine("X" + coordinates.X +"And Y is" + coordinates.Y + "is my new position");
           //return newPosition;
        }



    }
}
