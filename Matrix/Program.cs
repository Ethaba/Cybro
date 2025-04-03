using System;
using System.Linq;
using System.Threading;

class MatrixEffect
{
    static void Main()
    {
        // Set up the console window size
        Console.WindowHeight = 30;
        Console.WindowWidth = 100;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        // Define the symbols for the falling code effect
        string[] characters = new string[] { "0", "1", "|", "/", "\\", ":", ";", "$", "#", "@", "&", "%" };

        Random random = new Random();
        int columnWidth = Console.WindowWidth;

        // Infinite loop to simulate the falling code
        while (true)
        {
            for (int i = 0; i < columnWidth; i++)
            {
                // Randomize the starting position and speed of the falling characters
                if (random.Next(0, 10) > 7)
                {
                    // Random height for the column
                    int columnHeight = random.Next(3, Console.WindowHeight);
                    for (int j = 0; j < columnHeight; j++)
                    {
                        Console.SetCursorPosition(i, j);

                        // Pick a random character from the array
                        string charToPrint = characters[random.Next(0, characters.Length)];
                        Console.Write(charToPrint);

                        // Short delay to make the "falling" effect visible
                        Thread.Sleep(50);
                    }
                }
            }
        }
    }
}
