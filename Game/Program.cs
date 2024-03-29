var eventLoop = new EventLoop();
var game = new Game();

eventLoop.LeftHandler += game.OnLeft;
eventLoop.RightHandler += game.OnRight;
eventLoop.UpHandler += game.OnUp;
eventLoop.DownHandler += game.OnDown;

int[,] map =  {{'o', 'o', 'o'}, {'o', 'x', '@'}, {'o', 'o', 'o'}};
var playerPosition = new int[2];
for (int i = 0; i < map.Length; ++i)
{
    for (int j = 0; j < map.Length; ++j)
    {
        if (map[i, j] == '@')
        {
            playerPosition = [i, j];
        }
    }
}

eventLoop.Run();