namespace TirsvadCLI.Window.Model;

public class Position
{
    public int X { get; set; } ///> X coordinate
    public int Y { get; set; } ///> Y coordinate
    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
    public Position()
        : this(0, 0)
    {
    }
}
