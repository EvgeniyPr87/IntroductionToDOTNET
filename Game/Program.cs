using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] map =
              {
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
                {'#',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ','#','*',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ','*',' ','#' },
                {'#',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ',' ','*',' ',' ','#',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#' },
                {'#','#','#','#','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ','*',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ','#','#','#','#','#','#','#',' ',' ','#','#',' ','#','#','#','#','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ','*',' ','#' },
                {'#',' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' ',' ','*',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ','#','#','#','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ',' ',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' ',' ','*',' ',' ','#' },
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' }
            };

            int userX = 3;
            int userY = 3;
            int count = 0;

            while (true)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine($"SCORE: {count}");

                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(userY, userX);
                Console.Write('@');
                Console.CursorVisible = false;

                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (map[userX - 1, userY] != '#') { userX--; }
                        break;

                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if (map[userX + 1, userY] != '#') { userX++; }
                        break;

                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        if (map[userX, userY - 1] != '#') { userY--; }
                        break;

                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        if (map[userX, userY + 1] != '#') { userY++; }
                        break;
                }
                if (map[userX, userY] == '*') { map[userX, userY] = ' '; count++; }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
