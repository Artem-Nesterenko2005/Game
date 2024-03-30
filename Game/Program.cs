var eventLoop = new EventLoop();
var game = new Game();
game.SetMap();

eventLoop.LeftHandler += game.OnLeft;
eventLoop.RightHandler += game.OnRight;
eventLoop.UpHandler += game.OnUp;
eventLoop.DownHandler += game.OnDown;
eventLoop.DrawMap += game.DrawMap;
eventLoop.UpdateMap += game.UpdateMap;

eventLoop.Run();