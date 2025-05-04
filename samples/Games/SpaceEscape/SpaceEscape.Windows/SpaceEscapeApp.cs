using Silk.NET.SDL;
using Stride.Engine;
using Stride.Games;
using Stride.Graphics.SDL;
using Window = Silk.NET.SDL.Window;


using var game    = new Game();
var       context = new GameContextSDL(null);
game.Run(context);


//
//
// // 获取窗口句柄
// var sdlWindow = context.Control.SdlHandle;
// context.Control.FormBorderStyle = FormBorderStyle.None;
// context.Control.Text            = "Arcade Game";
//
// Stride.Graphics.SDL.Window.SDL.SetWindowOpacity((Window*)sdlWindow, 0.8f);
// Stride.Graphics.SDL.Window.SDL.SetWindowBordered((Window*)sdlWindow, SdlBool.False);
