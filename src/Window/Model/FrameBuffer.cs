namespace TirsvadCLI.Window.Model;
using TirsvadCLI.AnsiCode;
/// <summary>
/// Represents a frame buffer for a console window.
/// </summary>
public class FrameBuffer
{
    public int ScrollWidth { get; set; } ///> If the buffer is larger than the window, this will be the scroll width position.
    public int ScrollHeight { get; set; } ///> If the buffer is larger than the window, this will be the scroll height position.
    public SymbolHolder[,] ConsoleBuffer { get; set; } ///> Buffer for the console window
    public FrameBuffer(int width, int height)
    {
        ConsoleBuffer = new SymbolHolder[width, height];
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                ConsoleBuffer[x, y] = new SymbolHolder(' ', AnsiCode.WHITE, AnsiCode.BLACK);
            }
        }
    }
}
