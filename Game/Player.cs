public class Player()
{
    public int PosX { get; set; } = 0;

    public int PosY { get; set; } = 0;

    public int OldX { get; set; } = 0;

    public int OldY { get; set; } = 0;

    public void MoveUp()
    {
        OldY = PosY;
        OldX = PosX;    
        PosY--;
    }

    public void MoveDown()
    {
        OldY = PosY;
        OldX = PosX;  
        PosY++;
    }

    public void MoveLeft()
    {
        OldY = PosY;
        OldX = PosX;  
        PosX--;
    }

    public void MoveRight()
    {
        OldY = PosY;
        OldX = PosX;  
        PosX++;
    }
}