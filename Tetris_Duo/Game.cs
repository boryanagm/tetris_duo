using System;
using static Constants;

public class Game
{
    static void Main()
    {
        ConsoleSetup.InitialConsoleSetup();

        SetupMatrix();

        Console.ReadKey();
    }

    private static void SetupMatrix()
    {
        Position matrixPivot = new Position(MATRIX_TOP_LEFT_CORNER_X, MATRIX_TOP_LEFT_CORNER_Y);
        GameMatrix matrix = new GameMatrix(matrixPivot, MATRIX_WIDTH, MATRIX_HEIGHT);
    }
}
