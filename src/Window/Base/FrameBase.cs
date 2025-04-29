namespace TirsvadCLI.Window.Base;
using TirsvadCLI.Window.Model;
public abstract class FrameBase
{
    public int FrameWidth { get; } ///> IFrame width
    public int FrameHeight { get; } ///> IFrame height
    public FrameBuffer WindowBuffer { get; set; } ///> IFrame buffer object

    public FrameBase(int width, int height)
    {
        FrameWidth = width;
        FrameHeight = height;
        WindowBuffer = new FrameBuffer(width, height);
    }
}
