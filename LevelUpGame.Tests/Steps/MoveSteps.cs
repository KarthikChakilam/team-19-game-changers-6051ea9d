GameController testObj = new GameController();
    int startX, startY, endX, endY;
    GameController.DIRECTION direction;
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
    [Given(@"the character starts at position with XCoordinates (.*)")]
    [Given(@"the player chooses to move in (.*)")]
    public void givenPlayerChoosesDirection(String direction)
    {
        this.direction = (GameController.DIRECTION)
    Enum.Parse(typeof(GameController.DIRECTION) , direction);
    }
    public void whenTheCharacterMoves()
    {
        testObj.SetCharacterPosition(new Point(this.startX, this.StartY));
        testObj.Move(this.direction);
        GameController.GameStatus status = testObj.GetStatus();
        this.currentPosition = status.currentPosition;
    }