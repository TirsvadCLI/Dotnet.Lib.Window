using TirsvadCLI.Window.Model;

namespace TirsvadCLI.Window.Base;

public abstract class Frame
{
    public int FrameWidth { get; } ///> IFrame width
    public int FrameHeight { get; } ///> IFrame height
    public FrameBuffer WindowBuffer { get; set; } ///> IFrame buffer object

    public Frame(int width, int height)
    {
        FrameWidth = width;
        FrameHeight = height;
        WindowBuffer = new FrameBuffer(width, height);
    }
}
