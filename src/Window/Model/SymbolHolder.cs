namespace TirsvadCLI.Window.Model;
using TirsvadCLI.AnsiCode;
/// <summary>
/// Represents a character holder with properties for symbol and colors.
/// </summary>
public class SymbolHolder
{
    public char Symbol { get; set; } ///> Symbol   
    public string FgColor { get; set; } ///> Foreground color  
    public string BgColor { get; set; } ///> Background color 

    /// <summary>
    /// Initializes a new instance of the <see cref="SymbolHolder"/> class with specified symbol, foreground color, and background color.
    /// </summary>
    public SymbolHolder(char symbol, string fgColor, string bgColor)
    {
        Symbol = symbol;
        FgColor = fgColor;
        BgColor = bgColor;
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="SymbolHolder"/> class with specified symbol and default colors.
    /// </summary>
    public SymbolHolder(char symbol)
        : this(symbol, AnsiCode.WHITE, AnsiCode.BLACK)
    {
    }
    /// <summary>
    /// Returns a string representation of the character holder, including its symbol and colors.
    /// </summary>
    /// <returns>Symbol with ANSI codes</returns>
    public override string ToString()
    {
        return $"{FgColor}{BgColor}{Symbol}{AnsiCode.ANSI_RESET}";
    }
}
