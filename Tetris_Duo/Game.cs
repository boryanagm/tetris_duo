using System;
using static Constants;

public class Game
{
    static void Main()
    {
        GameMatrix matrix = SetupMatrix();

        ConsoleSetup.InitialConsoleSetup(matrix);

        Console.ReadKey();
    }

    private static GameMatrix SetupMatrix()
    {
        Position matrixPivot = new Position(MATRIX_TOP_LEFT_CORNER_X, MATRIX_TOP_LEFT_CORNER_Y);
        GameMatrix matrix = new GameMatrix(matrixPivot, MATRIX_WIDTH, MATRIX_HEIGHT);

        return matrix;
    }
}
