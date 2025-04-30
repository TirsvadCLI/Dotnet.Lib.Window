namespace TirsvadCLI.Window.Model;
using TirsvadCLI.AnsiCode;

/// <summary>
/// Represents a character holder with properties for symbol and colors.
/// </summary>
public class SymbolHolder
{
    /// <summary>
    /// Gets or sets the symbol.
    /// </summary>
    public char Symbol { get; set; }

    /// <summary>
    /// Gets or sets the foreground color.
    /// </summary>
    public string FgColor { get; set; }

    /// <summary>
    /// Gets or sets the background color.
    /// </summary>
    public string BgColor { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SymbolHolder"/> class with the specified symbol, foreground color, and background color.
    /// </summary>
    /// <param name="symbol">The symbol to represent.</param>
    /// <param name="fgColor">The foreground color of the symbol.</param>
    /// <param name="bgColor">The background color of the symbol.</param>
    public SymbolHolder(char symbol, string fgColor, string bgColor)
    {
        Symbol = symbol;
        FgColor = fgColor;
        BgColor = bgColor;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SymbolHolder"/> class with the specified symbol and default colors.
    /// </summary>
    /// <param name="symbol">The symbol to represent.</param>
    public SymbolHolder(char symbol)
        : this(symbol, AnsiCode.WHITE, AnsiCode.BLACK)
    {
    }

    /// <summary>
    /// Returns a string representation of the character holder, including its symbol and colors.
    /// </summary>
    /// <returns>A string containing the symbol with ANSI color codes.</returns>
    public override string ToString()
    {
        return $"{FgColor}{BgColor}{Symbol}{AnsiCode.ANSI_RESET}";
    }
}
