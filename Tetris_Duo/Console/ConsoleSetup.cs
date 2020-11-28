using System;
using static Constants;

public static class ConsoleSetup
{
    public static void InitialConsoleSetup()
    {
        Console.Title = CONSOLE_TITLE; 

        Console.WindowWidth = CONSOLE_WINDOW_WIDTH; 
        Console.WindowHeight = CONSOLE_WINDOW_HEIGH; 
        Console.BufferWidth = CONSOLE_BUFFER_WIDTH; 
        Console.BufferHeight = CONSOLE_BUFFER_HEIGHT; 

        Console.CursorVisible = false;

        SetupBorder();
    }

    private static void SetupBorder()
    {
        for (int col = -1; col <= MATRIX_WIDTH + 1; col++)
        {
            Console.SetCursorPosition(MATRIX_LEFT_OFFSET + col, MATRIX_TOP_OFFSET - 1);
            Console.Write(BOLD_BLOCK);
        }

        for (int row = -1; row <= MATRIX_HEIGHT + 1; row++)
        {
            Console.SetCursorPosition(MATRIX_LEFT_OFFSET - 1, MATRIX_TOP_OFFSET + row);
            Console.Write(BOLD_BLOCK);
        }

        for (int col = -1; col <= MATRIX_WIDTH + 1; col++)
        {
            Console.SetCursorPosition(MATRIX_LEFT_OFFSET + col, MATRIX_HEIGHT + MATRIX_TOP_OFFSET + 1);
            Console.Write(BOLD_BLOCK);
        }

        for (int row = -1; row <= MATRIX_HEIGHT + 1; row++)
        {
            Console.SetCursorPosition(MATRIX_WIDTH + MATRIX_LEFT_OFFSET + 1, MATRIX_TOP_OFFSET + row);
            Console.Write(BOLD_BLOCK);
        }
    }
}
