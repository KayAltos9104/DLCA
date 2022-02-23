using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLCA
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размеры поля в формате 1x2");

            string[] field_sizes = Console.ReadLine().Split(new char[] { 'x', 'X' });

            int a = int.Parse(field_sizes[0]);
            int b = int.Parse(field_sizes[1]);

            int[,] field = new int[a, b];
            int d_of_cell;

            do
            {
                Input.GetDiameter(Console.ReadLine(), out d_of_cell);
                if (d_of_cell == 2)
                    Console.WriteLine("Только нечётные диаметры!");
            }
            while (d_of_cell == 2);

            Input.GetNullCoords(Console.ReadLine(), out int x, out int y);

            General.Start(d_of_cell, x, y, field);

            Render.Draw(field);
        }
    }
}