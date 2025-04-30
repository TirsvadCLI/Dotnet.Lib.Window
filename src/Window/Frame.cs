namespace TirsvadCLI.Window;
using TirsvadCLI.Window.Base;
using TirsvadCLI.Window.Model;

/// <summary>
/// Represents a frame in the console window, inheriting from <see cref="FrameBase"/>.
/// </summary>
public class Frame : FrameBase
{
    /// <summary>
    /// Gets or sets the actual cursor position within the frame.
    /// </summary>
    public Position CursorPosition { get; set; }

    /// <summary>
    /// Gets or sets the start position of the cursor within the frame.
    /// </summary>
    public Position CursorStartPosition { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Frame"/> class with the specified width and height.
    /// </summary>
    /// <param name="width">The width of the frame.</param>
    /// <param name="height">The height of the frame.</param>
    public Frame(int width, int height) : base(width, height)
    {
        WindowBuffer = new FrameBuffer(width, height);
        CursorPosition = new Position(0, 0);
        CursorStartPosition = new Position(0, 0);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Frame"/> class with the specified dimensions, symbol, and colors.
    /// </summary>
    /// <param name="width">The width of the frame.</param>
    /// <param name="height">The height of the frame.</param>
    /// <param name="symbol">The default symbol to populate the frame buffer.</param>
    /// <param name="colorFG">The foreground color of the symbol.</param>
    /// <param name="colorBG">The background color of the symbol.</param>
    public Frame(int width, int height, char symbol, string? colorFG, string? colorBG)
        : base(width, height, symbol, colorFG, colorBG)
    {
        WindowBuffer = new FrameBuffer(width, height, symbol, colorFG, colorBG);
        CursorPosition = new Position(0, 0);
        CursorStartPosition = new Position(0, 0);
    }
}