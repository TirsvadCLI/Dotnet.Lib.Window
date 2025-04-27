namespace TirsvadCLI.Window.Interface;
using TirsvadCLI.Window.Model;
interface IFrame
{
    Position CursorPosition { get; set; } ///> Actual cursor position
    Position CursorStartPosition { get; set; }
    int FrameWidth { get; } ///> IFrame width
    int FrameHeight { get; } ///> IFrame height
    FrameBuffer WindowBuffer { get; set; } ///> IFrame buffer object
}
