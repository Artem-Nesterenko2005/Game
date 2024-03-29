public class Player(int posX, int posY)
{
    public int PosX { get; private set; } = posX;

    public int PosY { get; private set; } = posY;

    public void MoveUp()
    {
        PosY++;
    }

    public void MoveDown()
    {
        PosY--;
    }

    public void MoveLeft()
    {
        PosX--;
    }

    public void MoveRight()
    {
        PosX++;
    }
}