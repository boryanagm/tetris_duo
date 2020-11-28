using System;

public static class ConsoleSetup
{
    public static void InitialConsoleSetup()
    {
        Console.Title = Constants.CONSOLE_TITLE; 

        Console.WindowWidth = Constants.CONSOLE_WINDOW_WIDTH; 
        Console.WindowHeight = Constants.CONSOLE_WINDOW_HEIGH; 
        Console.BufferWidth = Constants.CONSOLE_BUFFER_WIDTH; 
        Console.BufferHeight = Constants.CONSOLE_BUFFER_HEIGHT; 

        Console.CursorVisible = false;
    }
}
