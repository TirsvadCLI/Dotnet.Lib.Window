namespace TirsvadCLI.Window;
using TirsvadCLI.Window.Interface;
using TirsvadCLI.Window.Model;

/// <summary>
/// Window class for creating and managing console frames.
/// Responsible for rendering frames to the console and managing frame buffers.
/// </summary>
public class Window : Base.FrameBase, IRendAble
{
    private FrameBuffer _currentFB; // Current buffer for the window
    private FrameBuffer _pendingFB; // Pending buffer for the window

    /// <summary>
    /// Gets or sets the actual cursor position.
    /// </summary>
    public Position CursorPosition { get; set; } = new Position(0, 0);

    /// <summary>
    /// Gets or sets the start position of the cursor.
    /// </summary>
    public Position CursorStartPosition { get; set; } = new Position(0, 0);

    /// <summary>
    /// Gets or sets the array of frames.
    /// </summary>
    public Frame[]? Frames { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Window"/> class with the specified dimensions.
    /// </summary>
    /// <param name="width">The width of the window.</param>
    /// <param name="height">The height of the window.</param>
    public Window(int width, int height) : base(width, height)
    {
        WindowBuffer = new FrameBuffer(width, height);
    }

    /// <summary>
    /// Renders the entire window to the console.
    /// </summary>
    public void Render()
    {
        _pendingFB = WindowBuffer;

        if (Frames != null)
        {
            foreach (var frame in Frames)
            {
                if (frame?.WindowBuffer == null) continue;
                SetPendingBFFromFrameBuffer(frame);
            }
        }

        RenderBuffer(_pendingFB);
        _currentFB = _pendingFB;
    }

    /// <summary>
    /// Renders only the parts of the window that have changed.
    /// </summary>
    public void RenderPartial()
    {
        if (_currentFB == null) return;
        RenderBuffer(_pendingFB, _currentFB);
        _currentFB = _pendingFB;
    }

    /// <summary>
    /// Sets the pending buffer from a frame buffer.
    /// </summary>
    /// <param name="frame">The frame to copy from.</param>
    private void SetPendingBFFromFrameBuffer(Frame frame)
    {
        int windowWidth = WindowBuffer.Console.GetLength(0);
        int windowHeight = WindowBuffer.Console.GetLength(1);
        int frameWidth = frame.WindowBuffer.Console.GetLength(0);
        int frameHeight = frame.WindowBuffer.Console.GetLength(1);

        int minWidth = Math.Min(windowWidth, frameWidth);
        int minHeight = Math.Min(windowHeight, frameHeight);

        int offsetX = frame.CursorStartPosition.X;
        int offsetY = frame.CursorStartPosition.Y;

        for (int x = 0; x < minWidth; x++)
        {
            for (int y = 0; y < minHeight; y++)
            {
                _pendingFB.Console[x + offsetX, y + offsetY] = frame.WindowBuffer.Console[x, y];
            }
        }
    }

    /// <summary>
    /// Renders the buffer to the console.
    /// </summary>
    /// <param name="buffer">The buffer to render.</param>
    /// <param name="previousBuffer">The previous buffer for partial rendering (optional).</param>
    private void RenderBuffer(FrameBuffer buffer, FrameBuffer? previousBuffer = null)
    {
        int width = buffer.Console.GetLength(0);
        int height = buffer.Console.GetLength(1);
        int cursorStartX = CursorStartPosition.X;
        int cursorStartY = CursorStartPosition.Y;

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (previousBuffer != null && buffer.Console[x, y] == previousBuffer.Console[x, y]) continue;

                Console.SetCursorPosition(x + cursorStartX, y + cursorStartY);
                Console.Write(buffer.Console[x, y].ToString());
            }
        }
    }

    /// <summary>
    /// Sets the frame buffer for a specific frame.
    /// </summary>
    /// <param name="frameIndex">The index of the frame.</param>
    /// <param name="frameBuffer">The frame buffer to set.</param>
    public void SetFrameBuffer(int frameIndex, FrameBuffer frameBuffer)
    {
        if (Frames == null || frameIndex < 0 || frameIndex >= Frames.Length || Frames[frameIndex] == null)
        {
            return;
        }
        Frames[frameIndex].WindowBuffer = frameBuffer;
    }

    /// <summary>
    /// Gets the frame buffer for a specific frame.
    /// </summary>
    /// <param name="frameIndex">The index of the frame.</param>
    /// <returns>The frame buffer, or null if not found.</returns>
    public FrameBuffer? GetFrameBuffer(int frameIndex)
    {
        if (Frames == null || frameIndex < 0 || frameIndex >= Frames.Length || Frames[frameIndex] == null)
        {
            return null;
        }
        return Frames[frameIndex].WindowBuffer;
    }
}
