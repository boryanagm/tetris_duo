using System;

public static class ConsoleSetup
{
    public static void InitialConsoleSetup()
    {
        Console.Title = "Duo Tetris"; // CONSOLE_TITLE

        Console.WindowWidth = 40; // CONSOLE_WIDTH
        Console.WindowHeight = 30; // CONSOLE_HEIGHT
        Console.BufferWidth = 40; // CONSOLE_WIDTH
        Console.BufferHeight = 30; // CONSOLE_HEIGHT

        Console.CursorVisible = false;
    }
}
