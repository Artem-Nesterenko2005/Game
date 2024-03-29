public class Game
{
    public void OnLeft(object sender, EventArgs args)
    => Console.WriteLine("Going left");
    
    public void OnRight(object sender, EventArgs args)
    => Console.WriteLine("Going right");
}