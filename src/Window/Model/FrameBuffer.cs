namespace TirsvadCLI.Window.Model;
using TirsvadCLI.AnsiCode;

/// <summary>
/// Represents a frame buffer for a console window.
/// </summary>
public class FrameBuffer
{
    /// <summary>
    /// Gets or sets the scroll width position. If the buffer is larger than the window, this determines the horizontal scroll position.
    /// </summary>
    public int ScrollWidth { get; set; }

    /// <summary>
    /// Gets or sets the scroll height position. If the buffer is larger than the window, this determines the vertical scroll position.
    /// </summary>
    public int ScrollHeight { get; set; }

    /// <summary>
    /// Gets or sets the console buffer, which holds the symbols and their associated colors for the frame.
    /// </summary>
    public SymbolHolder[,] Console { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FrameBuffer"/> class with the specified width and height.
    /// </summary>
    /// <param name="width">The width of the frame buffer.</param>
    /// <param name="height">The height of the frame buffer.</param>
    public FrameBuffer(int width, int height)
    {
        Console = new SymbolHolder[width, height];
        Populate(width, height, ' ', AnsiCode.WHITE, AnsiCode.BLACK);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FrameBuffer"/> class with the specified dimensions, symbol, and colors.
    /// </summary>
    /// <param name="width">The width of the frame buffer.</param>
    /// <param name="height">The height of the frame buffer.</param>
    /// <param name="symbol">The default symbol to populate the frame buffer.</param>
    /// <param name="colorFG">The foreground color of the symbol. Defaults to white if null.</param>
    /// <param name="colorBG">The background color of the symbol. Defaults to black if null.</param>
    public FrameBuffer(int width, int height, char symbol, string? colorFG, string? colorBG)
    {
        colorFG ??= AnsiCode.WHITE;
        colorBG ??= AnsiCode.BLACK;
        Console = new SymbolHolder[width, height];
        Populate(width, height, symbol, colorFG, colorBG);
    }

    /// <summary>
    /// Populates the frame buffer with the specified symbol and colors.
    /// </summary>
    /// <param name="width">The width of the frame buffer.</param>
    /// <param name="height">The height of the frame buffer.</param>
    /// <param name="symbol">The symbol to populate the buffer with.</param>
    /// <param name="colorFG">The foreground color of the symbol.</param>
    /// <param name="colorBG">The background color of the symbol.</param>
    public void Populate(int width, int height, char symbol, string colorFG, string colorBG)
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Console[x, y] = new SymbolHolder(symbol, colorFG, colorBG);
            }
        }
    }
}
