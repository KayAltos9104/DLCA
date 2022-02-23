using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLCA
{
    internal class Input
    {
        public static void GetDiameter(string diameter_of_cell, out int d_of_cell)
        {
            d_of_cell = int.Parse(diameter_of_cell);

            switch (d_of_cell % 2)
            {
                case 0:
                    d_of_cell = 2;
                    Console.WriteLine("Только нечётные диаметры!");
                    break;

                default:
                    break;
            }
        }

        public static void GetNullCoords(string x_and_y, out int x, out int y)
        {
            string[] coords = x_and_y.Split();

            x = int.Parse(coords[0]);
            y = int.Parse(coords[1]);
        }
    }
}