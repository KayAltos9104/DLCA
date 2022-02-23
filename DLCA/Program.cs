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
            int d_of_cell;

            do
            {
                Input.GetDiameter(Console.ReadLine(), out d_of_cell);
            }
            while (d_of_cell == 2);

            Input.GetNullCoords(Console.ReadLine(), out int x, out int y);

            General.Start(d_of_cell, x, y);
        }
    }
}