namespace TirsvadCLI.Window;
using TirsvadCLI.Window.Base;
using TirsvadCLI.Window.Model;

public class Frame : FrameBase
{
    public Frame(int width, int height) : base(width, height)
    {
        WindowBuffer = new FrameBuffer(width, height);
        CursorPosition = new Position(0, 0);
        CursorStartPosition = new Position(0, 0);
    }
    public Position CursorPosition { get; set; } ///> Actual cursor position
    public Position CursorStartPosition { get; set; } ///> Start position of the cursor
}
