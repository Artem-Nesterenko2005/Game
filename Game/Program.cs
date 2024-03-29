var eventLoop = new EventLoop();
var game = new Game();

eventLoop.LeftHandler += game.OnLeft;
eventLoop.RightHandler += game.OnRight;

var log = new List<string>();

eventLoop.LeftHandler += (sender, eventArgs) => log.Add("left");
eventLoop.RightHandler += (sender, eventArgs) => log.Add("right");

eventLoop.Run();