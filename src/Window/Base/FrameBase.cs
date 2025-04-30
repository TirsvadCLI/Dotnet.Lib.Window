namespace TirsvadCLI.Window.Base;
using TirsvadCLI.AnsiCode;
using TirsvadCLI.Window.Model;

/// <summary>
/// Represents the base class for frames, providing common properties and functionality for derived frame types.
/// </summary>
public abstract class FrameBase
{
    /// <summary>
    /// Gets the width of the frame.
    /// </summary>
    public int FrameWidth { get; }

    /// <summary>
    /// Gets the height of the frame.
    /// </summary>
    public int FrameHeight { get; }

    /// <summary>
    /// Gets or sets the frame buffer associated with the frame.
    /// </summary>
    public FrameBuffer WindowBuffer { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FrameBase"/> class with the specified width and height.
    /// </summary>
    /// <param name="width">The width of the frame.</param>
    /// <param name="height">The height of the frame.</param>
    protected FrameBase(int width, int height)
        : this(width, height, ' ', AnsiCode.WHITE, AnsiCode.BLACK)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FrameBase"/> class with the specified dimensions, symbol, and colors.
    /// </summary>
    /// <param name="width">The width of the frame.</param>
    /// <param name="height">The height of the frame.</param>
    /// <param name="symbol">The default symbol to populate the frame buffer.</param>
    /// <param name="colorFG">The foreground color of the symbol. Defaults to white if null.</param>
    /// <param name="colorBG">The background color of the symbol. Defaults to black if null.</param>
    protected FrameBase(int width, int height, char symbol, string? colorFG, string? colorBG)
    {
        FrameWidth = width;
        FrameHeight = height;
        WindowBuffer = new FrameBuffer(width, height, symbol, colorFG ?? AnsiCode.WHITE, colorBG ?? AnsiCode.BLACK);
    }
}