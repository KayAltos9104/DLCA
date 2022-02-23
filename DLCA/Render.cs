using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLCA
{
    internal class Render
    {
        public static void Draw(int[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == 1)
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(field[i, j]);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}