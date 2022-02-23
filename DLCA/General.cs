using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLCA
{
    internal class General
    {
        public static void Start(int d_of_cell, int x, int y, int[,] field)
        {
            int[,] _field = field;

            SpawnTheCell(d_of_cell, _field, x, y);
        }

        static void SpawnTheCell(int d_of_cell, int[,] field, int x, int y)
        {
            int r_of_cell = d_of_cell / 2;

            for (int i = y; i <= y + d_of_cell / 2; i++) // Заполнение клетки вниз.
            {
                for (int j = x - r_of_cell; j <= x + r_of_cell; j++)
                {
                    field[i, j] = 1;
                }
                r_of_cell--;
            }

            r_of_cell = d_of_cell / 2;

            for (int n = y; n >= y - d_of_cell / 2; n--) // Заполнение клетки выше центра.
            {
                for (int m = x - r_of_cell; m <= x + r_of_cell; m++)
                {
                    field[n, m] = 1;
                }
                r_of_cell--;
            }
        }
    }
}