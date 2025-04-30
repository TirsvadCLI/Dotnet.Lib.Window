namespace TirsvadCLI.Window.Model;

/// <summary>
/// Represents a position with X and Y coordinates.
/// </summary>
public class Position
{
    /// <summary>
    /// Gets or sets the X coordinate.
    /// </summary>
    public int X { get; set; }

    /// <summary>
    /// Gets or sets the Y coordinate.
    /// </summary>
    public int Y { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Position"/> class with the specified coordinates.
    /// </summary>
    /// <param name="x">The X coordinate.</param>
    /// <param name="y">The Y coordinate.</param>
    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Position"/> class with default coordinates (0, 0).
    /// </summary>
    public Position() : this(0, 0)
    {
    }
}
