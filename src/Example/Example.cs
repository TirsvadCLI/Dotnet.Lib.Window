namespace Example;

using TirsvadCLI.AnsiCode;
using TirsvadCLI.Window;
using TirsvadCLI.Window.Model;

internal class Example
{
    static Window window;

    static public void Example1()
    {
        window = new Window(80, 40); ///> Create a new window with 80 columns and 40 rows
        window.CursorStartPosition = new Position(0, 0); ///> Set the cursor start position to (0, 0)
        window.Frames = new Frame[3]; ///> Create an array of 3 frames
        window.Frames[0] = new Frame(20, 20, ' ', "", ""); ///> Create a new frame with 80 columns and 40 rows
        window.Frames[0].CursorStartPosition = new Position(0, 0); ///> Set the cursor start position to (0, 0)
        window.Frames[1] = new Frame(20, 20, ' ', AnsiCode.BLUE, AnsiCode.BG_BRIGHT_BLACK); ///> Create a new frame with 80 columns and 40 rows
        window.Frames[1].CursorStartPosition = new Position(0, 20); ///> Set the cursor start position to (0, 0)
        window.Frames[2] = new Frame(60, 40, ' ', "", AnsiCode.BG_BRIGHT_BLUE); ///> Create a new frame with 80 columns and 40 rows
        window.Frames[2].CursorStartPosition = new Position(20, 0); ///> Set the cursor start position to (0, 0)
        window.Render(); ///> Render the window
    }
    static void Main(string[] args)
    {
        Example1();
    }
}
