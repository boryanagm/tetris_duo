using System;
using static Constants;


public static class ConsoleSetup
{
    public static void InitialConsoleSetup(GameMatrix matrix)
    {
        Console.Title = CONSOLE_TITLE;

        Console.WindowWidth = CONSOLE_WINDOW_WIDTH;
        Console.WindowHeight = CONSOLE_WINDOW_HEIGH;
        Console.BufferWidth = CONSOLE_BUFFER_WIDTH;
        Console.BufferHeight = CONSOLE_BUFFER_HEIGHT;

        Console.CursorVisible = false;

        SetupBorder(matrix);
    }

    private static void SetupBorder(GameMatrix matrix)
    {
        DrawBorder(matrix);

        Console.ForegroundColor = ConsoleColor.Yellow;
        DrawCorners(matrix);
    }

    private static void DrawBorder(GameMatrix matrix)
    {
        for (int col = -1; col <= matrix.Width + 1; col++) 
        {
            Console.SetCursorPosition(matrix.TopLeftCorner.Y + col, matrix.TopLeftCorner.X - 1); 
            Console.Write(BOLD_BLOCK);
        }

        for (int row = -1; row <= matrix.Height + 1; row++)
        {
            Console.SetCursorPosition(matrix.TopRightCorner.X + 1, matrix.TopRightCorner.Y + row);
            Console.Write(BOLD_BLOCK);
        }

        for (int col = -1; col <= matrix.Width + 1; col++)
        {
            Console.SetCursorPosition(matrix.BottomLeftCorner.X + col, matrix.BottomLeftCorner.Y + 1);
            Console.Write(BOLD_BLOCK);
        }

        for (int row = -1; row <= matrix.Height + 1; row++)
        {
            Console.SetCursorPosition(matrix.TopLeftCorner.X - 1, matrix.TopLeftCorner.Y + row);
            Console.Write(BOLD_BLOCK);
        }
    }

    private static void DrawCorners(GameMatrix matrix)
    {
        Console.SetCursorPosition(matrix.TopLeftCorner.X, matrix.TopLeftCorner.Y);
        Console.Write(BOLD_BLOCK);

        Console.SetCursorPosition(matrix.TopRightCorner.X, matrix.TopRightCorner.Y);
        Console.Write(BOLD_BLOCK);

        Console.SetCursorPosition(matrix.BottomLeftCorner.X, matrix.BottomLeftCorner.Y);
        Console.Write(BOLD_BLOCK);

        Console.SetCursorPosition(matrix.BottomRightCorner.X, matrix.BottomRightCorner.Y);
        Console.Write(BOLD_BLOCK);
    }
}