using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLCA
{
    internal class Render
    {
        internal static void Draw(Cell[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j].State == 1)
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(field[i, j].State);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}