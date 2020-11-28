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
        //for (int col = -1; col <= MATRIX_WIDTH + 1; col++)
        //{
        //    Console.SetCursorPosition(MATRIX_TOP_LEFT_CORNER_X + col, MATRIX_TOP_LEFT_CORNER_Y - 1);
        //    Console.Write(BOLD_BLOCK);
        //}
        
        //for (int row = -1; row <= MATRIX_HEIGHT + 1; row++)
        //{
        //    Console.SetCursorPosition(MATRIX_TOP_LEFT_CORNER_X - 1, MATRIX_TOP_LEFT_CORNER_Y + row);
        //    Console.Write(BOLD_BLOCK);
        //}
        
        //for (int col = -1; col <= MATRIX_WIDTH + 1; col++)
        //{
        //    Console.SetCursorPosition(MATRIX_TOP_LEFT_CORNER_X + col, MATRIX_HEIGHT + MATRIX_TOP_LEFT_CORNER_Y + 1);
        //    Console.Write(BOLD_BLOCK);
        //}
        
        //for (int row = -1; row <= MATRIX_HEIGHT + 1; row++)
        //{
        //    Console.SetCursorPosition(MATRIX_WIDTH + MATRIX_TOP_LEFT_CORNER_X + 1, MATRIX_TOP_LEFT_CORNER_Y + row);
        //    Console.Write(BOLD_BLOCK);
        //}
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