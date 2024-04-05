using Game;
using Loop;

var eventLoop = new EventLoop();
var game = new Game.Game();
eventLoop.LeftHandler += game.GoingLeft;
eventLoop.RightHandler += game.GoingRight;
eventLoop.DownHandler += game.GoingDown;
eventLoop.UpHandler += game.GoingUp;

eventLoop.Run();
