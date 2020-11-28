using System;

public class Game
{
    static char[][] matrix = new char[3][]
    {
        new char[] { ' ', ' ', ' ' },
        new char[] { ' ', ' ', ' ' },
        new char[] { ' ', ' ', ' ' }
    };

    static void Main()
    {
        ConsoleSetup.InitialConsoleSetup();

        SetupMatrix();

        Console.ReadKey();
    }

    private static void SetupMatrix()
    {
        //new char[] { ' ', ' ', ' ' },
    }
}
