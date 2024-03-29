using System.Data;

public class Game
{
    // TODO карту сюда
    

    public void OnLeft(object sender, EventArgs args)
    {
        
    }

    public void OnRight(object sender, EventArgs args)
    => Console.WriteLine("Going right");

    public void OnUp(object sender, EventArgs args)
        => Console.WriteLine("Going up");
    
    public void OnDown(object sender, EventArgs args)
            => Console.WriteLine("Going down");
}