namespace TirsvadCLI.Window;
using TirsvadCLI.Window.Interface;
using TirsvadCLI.Window.Model;

public class Window : Base.Frame, IRendable
{
    public Position CursorPosition { get; set; } ///> Actual cursor position
    public Position CursorStartPosition { get; set; } ///> Start position of the cursor
    public Window(int width, int height) : base(width, height)
    {
        WindowBuffer = new FrameBuffer(width, height);
        CursorPosition = new Position(0, 0);
        CursorStartPosition = new Position(0, 0);
    }
    public void Render()
    {
        for (int x = 0; x < WindowBuffer.ConsoleBuffer.GetLength(0); x++)
        {
            for (int y = 0; y < WindowBuffer.ConsoleBuffer.GetLength(1); y++)
            {
                Console.SetCursorPosition(x + CursorStartPosition.X, y + CursorStartPosition.Y);
                Console.Write(WindowBuffer.ConsoleBuffer[x, y].ToString());
            }
        }
    }
}
