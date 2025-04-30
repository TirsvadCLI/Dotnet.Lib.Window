namespace TirsvadCLI.Window.Interface;
using TirsvadCLI.Window.Model;

/// <summary>
/// Defines the interface for a frame in the console window.
/// </summary>
public interface IFrame
{
    /// <summary>
    /// Gets or sets the actual cursor position within the frame.
    /// </summary>
    Position CursorPosition { get; set; }

    /// <summary>
    /// Gets or sets the start position of the cursor within the frame.
    /// </summary>
    Position CursorStartPosition { get; set; }

    /// <summary>
    /// Gets the width of the frame.
    /// </summary>
    int FrameWidth { get; }

    /// <summary>
    /// Gets the height of the frame.
    /// </summary>
    int FrameHeight { get; }

    /// <summary>
    /// Gets or sets the frame buffer associated with the frame.
    /// </summary>
    FrameBuffer WindowBuffer { get; set; }
}
