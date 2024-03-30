using System.Data;
using System.Security.Cryptography.X509Certificates;

public class Game
{
    private List<List<char>> map = ["@oo".ToList(), "ooo".ToList(), "ooo".ToList()];
    private Player player = new Player();

    public void SetMap()
    {
        for (int row = 0; row < map.Count; ++row)
        {
            for (int col = 0; col < map[row].Count; ++col)
            {
                if (map[row][col] == '@')
                {
                    player.PosX = col;
                    player.PosY = row;
                    map[row][col] = 'o';
                }
            }
        }
        (int leftCorner, int topCorner) = Console.GetCursorPosition();
    }

    public void DrawMap(object sender, EventArgs args)
    {
        Console.Clear();
        for (int row = 0; row < map.Count; ++row)
        {
            for (int col = 0; col < map.Count; ++col)
            {
                Console.Write(map[row][col]);
            }
            Console.WriteLine();
        }
        
        UpdateMap(sender, args);
    }

    public void UpdateMap(object sender, EventArgs args)
    {
        Console.SetCursorPosition(player.OldX, player.OldY);
        Console.Write('o');
        Console.SetCursorPosition(player.PosX, player.PosY);
        Console.Write('@');
    }

    public void OnLeft(object sender, EventArgs args)
    {
        if (player.PosX > 0 && map[player.PosY][player.PosX - 1] != 'x')
        {
            player.MoveLeft();
        }
    }

    public void OnRight(object sender, EventArgs args)
    {
        if (player.PosX < map.Count - 1 && map[player.PosY][player.PosX + 1] != 'x')
        {
            player.MoveRight();
        }
    }

    public void OnUp(object sender, EventArgs args)
    {
        if (player.PosY > 0 && map[player.PosY - 1][player.PosX] != 'x')
        {
            player.MoveUp();
        }
    }

    public void OnDown(object sender, EventArgs args)
    {
        if (player.PosY < map.Count - 1 && map[player.PosY + 1][player.PosX] != 'x')
        {
            player.MoveDown();
        }
    }
}