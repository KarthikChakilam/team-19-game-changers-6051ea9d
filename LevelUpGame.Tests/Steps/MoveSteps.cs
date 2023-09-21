using TechTalk.SpecFlow;
using System;
using NUnit.Framework;
using FluentAssertions;
using levelup;
using System.Drawing;

namespace DotNetExample.Tests.Steps
{
    [Binding]
    public class MoveSteps
    {
         private GameController testObj = new GameController();

        private String characterName = "";

        //public GameSteps(ScenarioContext scenarioContext)
        //{
            //   _scenarioContext = scenarioContext;
        //}

    //GameController testObj = new GameController();
    int startX, startY, endX, endY;
    Enums.DIRECTION direction;
    Point currentPosition;

    [Given(@"the character starts at position with XCoordinates (.*)")]
    public void givenTheCharacterStartsAtX(int startX)
    {
        this.startX = startX;
    }
    [Given(@"starts at YCoordinates (.*)")]
    public void givenTheCharacterStartsAtY(int startY)
    {
        this.startY = startY;
    }

    [Given(@"the player chooses to move in")]
    public void givenPlayerChoosesDirection(string direction)
    {
        this.direction = (Enums.DIRECTION)
    Enum.Parse(typeof(Enums.DIRECTION) , direction);
    }

    [When(@"the character moves")]
    public void whenTheCharacterMoves()
    {
        var cursorPosition= new Position();
        cursorPosition.X=0;
        cursorPosition.Y=1;
        testObj.SetCharacterPosition(cursorPosition);
        //testObj.SetCharacterPosition(new Point(this.startX, this.startY));
        testObj.Move(this.direction);
        GameController.GameStatus status = testObj.GetStatus();
        this.currentPosition = status.currentPosition;
    }
     [Then(@"the character is now at position with XCoordinates (.*)")]
    public void checkXCoordinates(int endX)
    {
        Assert.NotNull(this.currentPosition, "Expected position not null" );
        //givenPlayerChoosesDirection("NORTH");
        Assert.AreEqual(endX, this.currentPosition.X);
    }
    [Then(@"YCoordinates (.*)")]
    public void checkYCoordinates(int endY)
    {
        Assert.NotNull(this.currentPosition, "Expected position not null");
        //givenPlayerChoosesDirection("NORTH");
        Assert.AreEqual(endY, this.currentPosition.Y);
    }
    }
}